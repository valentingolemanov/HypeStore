import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormBuilder, FormControl } from '@angular/forms';
import { ProductsService } from '../../../../services/products.service';
import { AlertifyService } from 'src/app/services/alertify.service';
import {Router} from '@angular/router';
import * as BalloonEditor from '@ckeditor/ckeditor5-build-balloon';




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


  public Editor = BalloonEditor;

  constructor(private service: ProductsService,
     private fb: FormBuilder, private alertify: AlertifyService,
     private router: Router) { }

  ngOnInit() {
    this.createAddProductForm();
    this.isFormValid = this.addProductForm.valid;
  }

    //Getter method for all form controls
  get title(){
    return this.addProductForm.get('title') as FormControl;
  }

  get description(){
    return this.addProductForm.get('description') as FormControl;
  }

  get price(){
    return this.addProductForm.get('price') as FormControl;
  }

  createAddProductForm(): void {
    this.addProductForm = this.fb.group({
     title: [null, [Validators.required, Validators.minLength(3), Validators.maxLength(30)]],
     description: [null, [Validators.required, Validators.maxLength(300)]],
     price: [null, [Validators.required]],
     imageUrl: [null, [Validators.required]]
    });
  }

  onSubmit(){
    if(this.addProductForm.valid){

      this.newProduct = Object.assign(this.newProduct, this.addProductForm.value);
      let newProductId;
      this.service.createProduct(this.newProduct).subscribe(res => {
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
  }
}
