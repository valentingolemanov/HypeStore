import { Component, OnInit} from '@angular/core';
import { FormGroup, Validators, FormBuilder, FormControl } from '@angular/forms';
import { ProductsService } from './../../../services/products.service';
import { AlertifyService } from 'src/app/services/alertify.service';
import {Router} from '@angular/router';

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
     private fb: FormBuilder, private alertify: AlertifyService,
     private router: Router) {

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
     title: [null, [Validators.required, Validators.minLength(3), Validators.maxLength(60)]],
     description: [null, [Validators.required], Validators.minLength(20), Validators.maxLength(300)],
     price: [null, [Validators.required]],
    });
  }

  toggleForm(){
    this.showForm = !this.showForm;
  }

  onSubmit(){
    if(this.addProductForm.valid){
      this.newProduct = Object.assign(this.newProduct, this.addProductForm.value);
      this.service.createProduct(this.newProduct).subscribe(res => {
        console.log(res);
      });
      this.addProductForm.reset();
      this.alertify.success("Congrats, you added a new product!")
      this.router.navigateByUrl('/catalog');
    }else{
      this.alertify.error("Please provide valid information in all of the fields!")
    }
  }

}
