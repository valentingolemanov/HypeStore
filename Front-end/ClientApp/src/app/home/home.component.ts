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

  collections: Array<Collection> = [];
  newProducts: Array<Product> = [];
  constructor(private route: ActivatedRoute) { }

  tiles: Tile[];



  ngOnInit(): void {
    this.route.data.subscribe(
      (data: Collection) => {
       this.collections = data['cltn_listing'];
       this.newProducts = data['prd_listing'];
       const compareFn = (a: Product, b: Product) => {
        let aDate = Date.parse(a.ReleasedOn);
        let bDate = Date.parse(b.ReleasedOn);

        if(aDate > bDate ){
          return -1;
        }else if(aDate < bDate){
          return 1;
        }else{
          return 0;
        }
      };
        console.log(this.newProducts);
        this.newProducts = this.newProducts.sort(compareFn);
        this.newProducts.forEach(x => console.log(x.ReleasedOn));
       console.log(this.newProducts);
       this.tiles = [
        {
          cols: 1,
          rows: 2,
          color: 'blue',
          collection: this.collections[0]
        },
        {
          cols: 1,
          rows: 2,
          color: 'orange',
          collection: this.collections[1]
        },
        {
          cols: 2,
          rows: 1,
          color: 'green',
          collection: this.collections[3]
        },
        {
          cols: 1,
          rows: 1,
          color: 'red',
          collection: this.collections[2]
        },

        {
          cols: 1,
          rows: 1,
          color: 'yellow',
          collection: this.collections[4]
        },
      ]
    }
    )
  }

}

export interface Tile {
  cols: number;
  color: string;
  rows: number;
  collection: Collection;
}
