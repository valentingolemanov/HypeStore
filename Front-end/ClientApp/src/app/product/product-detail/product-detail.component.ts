import { Component, OnInit } from '@angular/core';
import { ProductsService } from 'src/app/services/products.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Product } from 'src/app/models/Product';
import {
  NgxGalleryOptions,
  NgxGalleryImage,
  NgxGalleryAnimation,
  NgxGalleryImageSize,
  NgxGalleryOrder,
} from 'ngx-gallery-9';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.css'],
})
export class ProductDetailComponent implements OnInit {
  product: Product;
  relatedProducts: Product[];

  galleryOptions: NgxGalleryOptions[];
  galleryImages: NgxGalleryImage[];

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
