import { Component, OnInit } from '@angular/core';
import {Product} from './../../models/Product';
import {ActivatedRoute} from '@angular/router';
import {AddProductComponent} from './add-product/add-product.component';
import {MatDialog} from '@angular/material/dialog';
import {Brand} from './../../models/brand';
import { Collection } from 'src/app/models/Collection';

@Component({
  selector: 'app-dashboard-products',
  templateUrl: './dashboard-products.component.html',
  styleUrls: ['./dashboard-products.component.css']
})
export class DashboardProductsComponent implements OnInit {

  products: Array<Product> = [];
  brands: Array<Brand> = [];
  collections: Array<Collection> = [];

  constructor(private route: ActivatedRoute,
    public dialog: MatDialog) { }

  ngOnInit() {
    this.route.data.subscribe(
      (data: Product) => {
        this.products = data['prd_listing'];
        this.brands = data['brnd_listing'];
        this.collections = data['cltn_listing'];
      }
    );
  }

  openAddProductDialog() {
    const dialogRef = this.dialog.open(AddProductComponent,
      {
        data: {
          brands: this.brands,
          collections: this.collections
        }
      });

    dialogRef.afterClosed().subscribe(result => {
      console.log(`Dialog result: ${result}`);
    });
  }

}
