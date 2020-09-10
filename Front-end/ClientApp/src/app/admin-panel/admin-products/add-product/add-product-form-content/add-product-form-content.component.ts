import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormBuilder, FormControl } from '@angular/forms';
import { ProductsService } from '../../../../services/products.service';
import { AlertifyService } from 'src/app/services/alertify.service';
import {Router} from '@angular/router';
import * as BalloonEditor from '@ckeditor/ckeditor5-build-balloon';
import {BrandsService} from '../../../../services/brands.service';
import {IBrand} from '../../../../models/IBrand';

@Component({
  selector: 'app-add-product-form-content',
  templateUrl: './add-product-form-content.component.html',
  styleUrls: ['./add-product-form-content.component.css']
})

export class AddProductFormContentComponent implements OnInit {

  addProductForm: FormGroup;
  checked = false;
  indeterminate = false;
  labelPosition: 'before' | 'after' = 'after';
  disabled = false;
  showForm = false;
  files  = [];
  newProduct: any = {};
  isFormValid: boolean;
  selectedValue: string;

  public brands: IBrand[];
  public Editor = BalloonEditor;

  constructor(private productsService: ProductsService,
    private brandsService: BrandsService,
    private fb: FormBuilder,
    private alertify: AlertifyService,
    private router: Router) { }

  ngOnInit() {
    this.createAddProductForm();
    this.isFormValid = this.addProductForm.valid;
     this.brandsService.getAllBrands().subscribe(
       data =>
       {
         this.brands = data;
        },
        (err) => console.log(err),
        () => console.log(this.brands)
     )
  }

  // -----------------------------------
  // Getter method for all form controls
  // -----------------------------------
  get title(){
    return this.addProductForm.get('title') as FormControl;
  }
  get description(){
    return this.addProductForm.get('description') as FormControl;
  }
  get price(){
    return this.addProductForm.get('price') as FormControl;
  }
  get imageUrl(){
    return this.addProductForm.get('imageUrl') as FormControl;
  }
  get brandId(){
    return this.addProductForm.get('brand') as FormControl;
  }

  createAddProductForm(): void {
    this.addProductForm = this.fb.group({
     title: [null, [Validators.required, Validators.minLength(5), Validators.maxLength(50)]],
     description: [null, [Validators.required, Validators.minLength(40), Validators.maxLength(400)]],
     price: [null, [Validators.required]],
     imageUrl: [null, [Validators.required]],
     brandId: [null, [Validators.required]]
    });
  }

  onSubmit(){
    if(this.addProductForm.valid){

      this.newProduct = Object.assign(this.newProduct, this.addProductForm.value);
      let newProductId;
      this.productsService.createProduct(this.newProduct).subscribe(res => {
        newProductId = res;

      },
      (err) => console.log(err),
      () => {
        this.alertify.success("Congrats, you added a new product!");
      this.addProductForm.reset();
       this.router.navigate([`/admin-products`]);
    });

    }else{
      console.log(this.addProductForm);
      this.alertify.error("Please provide valid information in all fields!");
    }

    console.log(this.addProductForm);
  }
}
