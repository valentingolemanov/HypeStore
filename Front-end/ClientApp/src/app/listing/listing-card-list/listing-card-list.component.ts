import { Component, OnInit, Input } from '@angular/core';
import {Product} from './../../models/Product';

@Component({
  selector: 'app-listing-card-list',
  templateUrl: './listing-card-list.component.html',
  styleUrls: ['./listing-card-list.component.css']
})
export class ListingCardListComponent implements OnInit {

  constructor() {}

  @Input() products: Array<Product> = [];

  SearchInput = '';
  SearchOption = '';

  ngOnInit() {
  }

}
