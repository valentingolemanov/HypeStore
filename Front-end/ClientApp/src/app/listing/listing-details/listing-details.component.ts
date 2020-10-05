import { Component, OnInit } from '@angular/core';
import { ProductsService } from '../../services/products.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Product } from './../../models/Product';


@Component({
  selector: 'app-product-detail',
  templateUrl: './listing-details.component.html',
  styleUrls: ['./listing-details.component.css'],
})
export class ListingDetailsComponent implements OnInit {

  product: Product;
  relatedProducts: Product[];

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private productsService: ProductsService
  ) {}

  ngOnInit(): void {
    this.route.data.subscribe((data: Product) => {
      console.log(data);
      this.product = data['prd_details'];
      console.log(this.product);
      this.relatedProducts = data['prd_listing'].filter(
        (x: Product) =>
          x.BrandName === this.product.BrandName && x.Id !== this.product.Id
      );
    });
  }
}
