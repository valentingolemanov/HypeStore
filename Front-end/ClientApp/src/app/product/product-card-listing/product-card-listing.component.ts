import { Component, OnInit, Input } from '@angular/core';
import {Product} from '../../models/Product';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-card-listing.component.html',
  styleUrls: ['./product-card-listing.component.css']
})
export class ProductCardListingComponent implements OnInit {

  constructor() {}

  @Input() products: Array<Product> = [];

  SearchInput = '';
  SearchOption = '';

  ngOnInit(): void {

  }



}
