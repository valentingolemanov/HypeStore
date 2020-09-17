import { Component, OnInit } from '@angular/core';
import { ProductsService } from '../services/products.service';
import {Product} from './../models/Product';
import {ActivatedRoute} from '@angular/router';
import { Brand } from '../models/brand';
import { Collection } from '../models/Collection';



@Component({
  selector: 'app-catalog',
  templateUrl: './catalog.component.html',
  styleUrls: ['./catalog.component.css']
})
export class CatalogComponent implements OnInit {

  showFiller = false;
  showSpinner = false;
  products: Array<Product> = [];
  brands: Array<Brand> = [];
  collections: Array<Collection> = [];

  constructor(private route: ActivatedRoute, private productsService: ProductsService) { }

  ngOnInit() {

    this.route.data.subscribe(
      (data: Product) => {
        this.showSpinner =true;
        this.products = data['prd_listing'];
        this.brands = data['brnd_listing'];
        this.collections = data['cltn_listing'];
      },
      (err) => console.log(err),
      () =>{

      }
    );



  }

}
