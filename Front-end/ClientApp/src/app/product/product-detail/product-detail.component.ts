import { Component, OnInit } from '@angular/core';
import { IProduct } from '../IProduct.interface';
import { ProductsService } from 'src/app/services/products.service';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.css']
})
export class ProductDetailComponent implements OnInit {

  product: IProduct;
  constructor(private productsService: ProductsService) { }

  ngOnInit(): void {

  }

}
