import { Component, OnInit } from '@angular/core';
import { ProductsService } from '../services/products.service';
import {Product} from './../models/Product';
import {ActivatedRoute} from '@angular/router';


@Component({
  selector: 'app-catalog',
  templateUrl: './catalog.component.html',
  styleUrls: ['./catalog.component.css']
})
export class CatalogComponent implements OnInit {

  showFiller = false;
  showSpinner = false;
  products: Array<Product> = [];

  constructor(private route: ActivatedRoute, private productsService: ProductsService) { }

  ngOnInit() {

    this.route.data.subscribe(
      (data: Product) => {
        this.showSpinner =true;
        this.products = data['prd_listing'];
      },
      (err) => console.log(err),
      () =>{
        this.showSpinner = false;
      }
    );

  // this.productsService.getAllProducts().subscribe(data => {
  //     this.products = data;
  //     console.log(data);
  //   });

  }

}
