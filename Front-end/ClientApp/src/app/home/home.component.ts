import { Component, OnInit } from '@angular/core';
import { Collection } from '../models/Collection';
import {ActivatedRoute} from '@angular/router';
import { WHITE_ON_BLACK_CSS_CLASS } from '@angular/cdk/a11y/high-contrast-mode/high-contrast-mode-detector';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {


  showFiller = false;

  collections: Array<Collection> = [];
  constructor(private route: ActivatedRoute) { }

  tiles: Tile[];



  ngOnInit(): void {
    this.route.data.subscribe(
      (data: Collection) => {
       this.collections = data['cltn_listing'];
       this.tiles = [
        {
          cols: 1,
          rows: 2,
          color: 'blue',
          collection: this.collections[0]
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
          color: 'green',
          collection: this.collections[3]
        },
        {
          cols: 1,
          rows: 2,
          color: 'orange',
          collection: this.collections[1]
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
