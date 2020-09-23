import { Component, OnInit, Input } from '@angular/core';
import {FormGroup, FormControl, Validators, FormBuilder} from '@angular/forms';
import { Brand } from 'src/app/models/brand';
import { Collection } from 'src/app/models/Collection';
import { AlertifyService } from 'src/app/services/alertify.service';
import {MatDialog} from '@angular/material/dialog';
import {ActivatedRoute, Router} from '@angular/router';
import {DeleteDialogContentComponent} from './../delete-dialog-content/delete-dialog-content.component';
import { Product } from 'src/app/models/Product';
import { ProductsService } from 'src/app/services/products.service';

@Component({
  selector: 'app-edit-product',
  templateUrl: './edit-product.component.html',
  styleUrls: ['./edit-product.component.css']
})
export class EditProductComponent implements OnInit {

  editProductForm: FormGroup;
  selectedBrand: string;
  selectedCollections: Number[];


  @Input() product: Product;
  @Input() brands: Brand[];
  @Input() collections: Collection[];

  constructor(private fb: FormBuilder,
    private route: ActivatedRoute,
    public dialog: MatDialog,
    private productsService: ProductsService,
    private router: Router,
    private alertify: AlertifyService) { }

  ngOnInit() {
    this.createEditProductForm();
  }

  createEditProductForm(): void {
    this.editProductForm = this.fb.group({
     id: [this.product.Id],
     title: [this.product.Title, [Validators.required, Validators.minLength(5), Validators.maxLength(100)]],
     description: [this.product.Description, [Validators.required, Validators.minLength(40), Validators.maxLength(1000)]],
     price: [this.product.Price, [Validators.required]],
     brandId: [this.product.BrandId, [Validators.required]],
     collectionIds: [[this.product.CollectionIds], []],
    });
  }

  openDeleteDialog(id: number) {

    this.dialog.open(DeleteDialogContentComponent,
      {data : {
        productId: id,
      }});

  }

  onSubmit(){
    this.product = Object.assign(this.product, this.editProductForm.value);
    console.log(this.product);
    this.productsService.updateProduct(this.product).subscribe(res => {
      console.log(this.product);
    },
    (err) => console.log(err),
    () => {
      this.alertify.success("Congrats, you updated this product info!");
      this.editProductForm.reset();
      this.router.navigate([`/dashboard-products`]);

    });
  }

}
