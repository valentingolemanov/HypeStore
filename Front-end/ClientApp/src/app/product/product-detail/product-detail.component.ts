import { Component, OnInit } from '@angular/core';
import { IProduct } from '../IProduct.interface';
import { ProductsService } from 'src/app/services/products.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Product } from 'src/app/models/Product';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.css']
})
export class ProductDetailComponent implements OnInit {

  product: IProduct;


  constructor(private route: ActivatedRoute,
    private router: Router,
    private productsService: ProductsService) { }



  ngOnInit(): void {
      this.route.data.subscribe(
        (data: Product) => {
          this.product = data['prd'];
        }
      );
  }

}
