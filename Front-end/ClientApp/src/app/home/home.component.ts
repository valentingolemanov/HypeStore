import { Component, OnInit } from '@angular/core';
import { Collection } from '../models/Collection';
import {ActivatedRoute} from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {


  showFiller = false;

  collections: Array<Collection> = [];
  constructor(private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.route.data.subscribe(
      (data: Collection) => {
       this.collections = data['cltn_listing'];
      }
    )
  }

}
