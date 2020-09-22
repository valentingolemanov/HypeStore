import { Component, OnInit } from '@angular/core';
import { ProductsService } from 'src/app/services/products.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Product } from 'src/app/models/Product';
import { NgxGalleryOptions, NgxGalleryImage, NgxGalleryAnimation, NgxGalleryImageSize, NgxGalleryOrder } from 'ngx-gallery-9';

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
          console.log(data);
          this.product = data['prd_details'];
          console.log(this.product);
          this.relatedProducts = data['prd_listing'].filter((x: Product) => x.BrandName === this.product.BrandName);
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
            thumbnailsPercent: 23,
            thumbnailMargin: 10,
            thumbnailSize: NgxGalleryImageSize.Contain,
            previewBullets: true,
            arrowPrevIcon: 'fa fa-caret-left',
            arrowNextIcon: 'fa fa-caret-right',
            thumbnailsArrows: false,
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

        this.galleryImages = this.product.ImagesUrl.map(x => new NgxGalleryImage(
          {
             small: x,
             medium: x,
             big: x
        }
          ));
  }

}
