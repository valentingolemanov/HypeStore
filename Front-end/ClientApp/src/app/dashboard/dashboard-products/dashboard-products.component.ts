import { Component, OnInit } from '@angular/core';
import {Product} from './../../models/Product';
import {ActivatedRoute} from '@angular/router';

@Component({
  selector: 'app-dashboard-products',
  templateUrl: './dashboard-products.component.html',
  styleUrls: ['./dashboard-products.component.css']
})
export class DashboardProductsComponent implements OnInit {

  products: Array<Product> = [];

  constructor(private route: ActivatedRoute) { }

  ngOnInit() {
    this.route.data.subscribe(
      (data: Product) => {
        this.products = data['prd_listing'];
      }
    );
  }

}
