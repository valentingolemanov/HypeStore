import { Component, Inject, OnInit } from '@angular/core';
import {
  FormGroup,
  Validators,
  FormBuilder,
  FormControl,
  FormArray,
} from '@angular/forms';
import { ProductsService } from '../../../services/products.service';
import { AlertifyService } from '../../../services/alertify.service';
import { Router } from '@angular/router';
import { BrandsService } from '../../../services/brands.service';
import { IBrand } from '../../../models/IBrand';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Collection } from './../../../models/Collection';
import { ICreateProduct } from 'src/app/product/ICreateProduct.interface';
import { Product } from 'src/app/models/Product';

@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css'],
})
export class AddProductComponent implements OnInit {
  addProductForm: FormGroup;
  checked = false;
  indeterminate = false;
  labelPosition: 'before' | 'after' = 'after';
  disabled = false;
  showForm = false;
  files = [];
  newProduct: any = {};
  brands: IBrand[];
  collectionsList: Collection[];
  collections = new FormControl();

  constructor(
    private productsService: ProductsService,
    private brandsService: BrandsService,
    private fb: FormBuilder,
    private alertify: AlertifyService,
    private router: Router,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {

    this.brands = this.data['brands'];
    this.collectionsList = this.data['collections'];
  }

  ngOnInit() {
    this.createAddProductForm();
    console.log(this.addProductForm);


  }

  // -----------------------------------
  // Getter method for all form controls
  // -----------------------------------
  get title() {
    return this.addProductForm.get('title') as FormControl;
  }
  get description() {
    return this.addProductForm.get('description') as FormControl;
  }
  get price() {
    return this.addProductForm.get('price') as FormControl;
  }
  get brandId() {
    return this.addProductForm.get('brand') as FormControl;
  }
  get collectionIds() {
    return this.addProductForm.get('collectionIds') as FormControl;
  }
  get imagesUrl() {
    return this.addProductForm.get('imagesUrl') as FormArray;
  }
  get imagesControls() {
    return this.addProductForm.get('imagesUrl')['controls'];
  }

  createAddProductForm(): void {
    this.addProductForm = this.fb.group({
      title: [
        null,
        [
          Validators.required,
          Validators.minLength(5),
          Validators.maxLength(100),
        ],
      ],
      description: [
        null,
        [
          Validators.required,
          Validators.minLength(40),
          Validators.maxLength(1000),
        ],
      ],
      price: [null, [Validators.required]],
      brandId: [null, [Validators.required]],
      collectionIds: [[], []],
      imagesUrl: this.fb.array([this.newImage()]),
    });
  }

  newImage(): FormGroup {
    return this.fb.group({
      url: '',
    });
  }

  addImage() {
    this.imagesUrl.push(this.newImage());
  }

  removeImage(i: number) {
    this.imagesUrl.removeAt(i);
  }

  // updateProduct(data: Product) {
  //   this.addProductForm.patchValue({
  //     id: data.Id,
  //     title: data.Title,
  //     description: data.Description,
  //     price: data.Price,
  //     imagesUrl: data.ImagesUrl,
  //     brandId: data.BrandId,
  //     collectionIds: data.CollectionIds,
  //   });
  // }

  // getProduct(id: number) {
  //   this.productsService.getProduct(this.existingProductId).subscribe(
  //     (data: Product) => {
  //       this.updateProduct(data);
  //     },
  //     (err) => console.log(err),
  //     () => {}
  //   );
  // }

  onSubmit() {
    if (this.addProductForm.valid) {
      this.newProduct = Object.assign(
        this.newProduct,
        this.addProductForm.value
      );
      this.productsService.createProduct(this.newProduct).subscribe(
        (res) => {},
        (err) => console.log(err),
        () => {
          this.alertify.success('Congrats, you added a new product!');
          this.addProductForm.reset();
          this.router.navigate([`/dashboard-products`]);
        }
      );

      this.alertify.error('Please provide valid information in all fields!');

      console.log(this.addProductForm);
    }
  }
}
