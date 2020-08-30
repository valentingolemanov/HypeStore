import { Component, OnInit,ViewChild, ElementRef } from '@angular/core';
import { FormGroup, Validators, FormBuilder, FormControl } from '@angular/forms';
import { ProductsService } from './../../../services/products.service';


@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css']
})
export class AddProductComponent implements OnInit {

  addProductForm: FormGroup;
  checked = false;
  indeterminate = false;
  labelPosition: 'before' | 'after' = 'after';
  disabled = false;
  showForm = false;
  files  = [];
  newProduct: any = {};

  constructor(private service: ProductsService,
     private fb: FormBuilder) {

   }

  //Getter method for all form controls
  // get title(){
  //   return this.addProductForm.get('title') as FormControl;
  // }

  // get description(){
  //   return this.addProductForm.get('description') as FormControl;
  // }

  // get price(){
  //   return this.addProductForm.get('price') as FormControl;
  // }


  ngOnInit() {

    this.createAddProductForm();
  }

  onClick(){

  }

  createAddProductForm(): void {
    this.addProductForm = this.fb.group({
     title: [null, [Validators.required]],
     description: [null, [Validators.required]],
     price: [null, [Validators.required]],
    });
  }

  toggleForm(){
    this.showForm = !this.showForm;
  }

  onSubmit(){
    console.log(this.addProductForm);
   this.newProduct = Object.assign(this.newProduct, this.addProductForm.value);

    console.log(this.newProduct);
    this.service.createProduct(this.newProduct).subscribe(res => {
      console.log(res);
    });
  }

}
