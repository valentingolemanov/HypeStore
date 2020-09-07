import { Component, OnInit} from '@angular/core';

import {MatDialog} from '@angular/material/dialog';
import {AddProductFormContentComponent} from '../../admin-products/add-product/add-product-form-content/add-product-form-content.component';

@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css']
})
export class AddProductComponent implements OnInit {



  constructor(
     public dialog: MatDialog) {

   }




  ngOnInit() {


  }

  onClick(){

  }





  openDialog() {
    const dialogRef = this.dialog.open(AddProductFormContentComponent);

    dialogRef.afterClosed().subscribe(result => {
      console.log(`Dialog result: ${result}`);
    });
  }



}
