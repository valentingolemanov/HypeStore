import { Component, OnInit, Input } from '@angular/core';
import {IProduct} from '../IProduct.interface';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-card-listing.component.html',
  styleUrls: ['./product-card-listing.component.css']
})
export class ProductCardListingComponent implements OnInit {

  constructor() {}

  @Input() products: Array<IProduct>;

  SearchInput = '';
  SearchOption = '';

  ngOnInit(): void {

  }



}
