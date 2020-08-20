import { Component, OnInit } from '@angular/core';
import { ProductsService } from 'src/app/services/products.service';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {

  constructor(private service: ProductsService) {}

  products: any;

  ngOnInit(): void {
    this.service.getAllProducts().subscribe(data => {
      this.products = data;
      console.log(data);
    });
  }

}
