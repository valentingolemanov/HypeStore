import { Component, OnInit } from '@angular/core';
import { ProductsService } from 'src/app/services/products.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Product } from 'src/app/models/Product';
import { NgxGalleryOptions, NgxGalleryImage, NgxGalleryAnimation, NgxGalleryLayout, NgxGalleryImageSize, NgxGalleryOrder } from 'ngx-gallery-9';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.css']
})
export class ProductDetailComponent implements OnInit {

  product: Product;
  relatedProducts: Product[];

  galleryOptions: NgxGalleryOptions[];
    galleryImages: NgxGalleryImage[];


  constructor(private route: ActivatedRoute,
    private router: Router,
    private productsService: ProductsService) {

    }



  ngOnInit(): void {
      this.route.data.subscribe(
        (data: Product) => {
          this.product = data['prd_details'];
          this.relatedProducts = data['prd_listing'];
          this.relatedProducts = this.relatedProducts.filter(x => x.BrandName === this.product.BrandName);
        }
      );
      this.galleryOptions = [
        {
            width: '90%',
            height: '90%',
            thumbnailsColumns: 4,
            imageAnimation: NgxGalleryAnimation.Slide,
            imagePercent: 100,
            imageSwipe: true,
            imageSize: NgxGalleryImageSize.Contain,
            imageInfinityMove: true,
            imageBullets: true,
            thumbnailsPercent: 23,
            thumbnailMargin: 10,
            thumbnailSize: NgxGalleryImageSize.Contain,
            previewBullets: true,
            arrowPrevIcon: 'fa fa-caret-left',
            arrowNextIcon: 'fa fa-caret-right'

        },
        // max-width 800
        {
            breakpoint: 800,
            width: '100%',
            height: '600px',
            imagePercent: 80,
            thumbnailsPercent: 20,
            thumbnailsMargin: 20,
            thumbnailMargin: 20
        },
        // max-width 400
        {
            breakpoint: 400,
            preview: false
        }
    ];

    this.galleryImages = [
      {
          small: this.product.ImagesUrl[0],
          medium: this.product.ImagesUrl[0],
          big: this.product.ImagesUrl[0]
      },
      {
          small: this.product.ImagesUrl[0],
          medium: this.product.ImagesUrl[0],
          big: this.product.ImagesUrl[0]
      },
      {
          small:this.product.ImagesUrl[0],
          medium: this.product.ImagesUrl[0],
          big: this.product.ImagesUrl[0]
      },
      {
        small:this.product.ImagesUrl[0],
        medium: this.product.ImagesUrl[0],
        big: this.product.ImagesUrl[0]
    }
  ];
  }

}
