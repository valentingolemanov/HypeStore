import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { ProductsService } from 'src/app/services/products.service';

@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css']
})
export class AddProductComponent implements OnInit {

  addProductForm: FormGroup;

  constructor(private service: ProductsService) {
    this.addProductForm = new FormGroup( {
       title: new FormControl(null, [Validators.required, Validators.minLength(3), Validators.maxLength(30)]),
       description: new FormControl(null, [Validators.required, Validators.minLength(10), Validators.maxLength(200)]),
       category: new FormControl(null),
       price: new FormControl(null, [Validators.required])
    });
   }

  ngOnInit() {

  }

  onSubmit(){
    console.log(this.addProductForm);
    const product = {
      Title: this.addProductForm.value['title'],
      Description: this.addProductForm.value['description'],
      Price: this.addProductForm.value['price']
    };

    console.log(product);
    this.service.createProduct(product).subscribe(res => {
      console.log(res);
    });
  }

}
