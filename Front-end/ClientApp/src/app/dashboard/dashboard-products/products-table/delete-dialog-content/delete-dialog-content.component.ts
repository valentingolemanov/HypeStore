import { Component, OnInit } from '@angular/core';
import {Router} from '@angular/router';
import {AlertifyService} from '../../../../services/alertify.service';
import {MatDialog} from '@angular/material/dialog';
import { ProductsService } from 'src/app/services/products.service';
import {MAT_DIALOG_DATA, MatDialogRef} from "@angular/material/dialog";
import { Inject } from '@angular/core';

@Component({
  selector: 'app-delete-dialog-content',
  templateUrl: './delete-dialog-content.component.html',
  styleUrls: ['./delete-dialog-content.component.css']
})
export class DeleteDialogContentComponent implements OnInit {

  productId: number;


  constructor(private service: ProductsService,
    private router: Router,
    private alertify: AlertifyService,
    public dialog: MatDialog,
    @Inject(MAT_DIALOG_DATA) data) {
      this.productId = data.productId;
     }


  ngOnInit() {
  }

  onDelete(){
    this.service.deleteProduct(this.productId).subscribe(
      res => { console.log(res)},
      (err) => console.log(err),
      () =>{
         this.alertify.success('Congrats! You successfully deleted the product');
         this.router.navigate(['/dashboard-products']);
        }
    )
  }

}
