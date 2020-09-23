import { Component, OnInit } from '@angular/core';
import { Collection } from '../models/Collection';
import {ActivatedRoute} from '@angular/router';
import { Product } from '../models/Product';
import { getLocaleDateTimeFormat } from '@angular/common';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})


export class HomeComponent implements OnInit {


  showFiller = false;

  homeDisplayCollections: Array<Collection> = [];
  newProducts: Array<Product> = [];
  constructor(private route: ActivatedRoute) {

   }





  ngOnInit(): void {
    this.route.data.subscribe(
      (data: Collection) => {
       this.homeDisplayCollections = data['cltn_listing'];
       console.log(this.homeDisplayCollections);


       this.newProducts = data['prd_listing'];
       const compareFn = (a: Product, b: Product) => {
        const aDate = Date.parse(a.AddedOn);
        const bDate = Date.parse(b.AddedOn);

        if(aDate > bDate ){
          return -1;
        }else if(aDate < bDate){
          return 1;
        }else{
          return 0;
        }
      };


        this.newProducts = this.newProducts.sort(compareFn);



    }
    )
  }




}

