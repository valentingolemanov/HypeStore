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

  slides = [
    'https://image.goat.com/crop/500/attachments/product_template_additional_pictures/images/039/610/547/original/603678_01.jpg.jpeg?1595259268',
   'https://image.goat.com/crop/500/attachments/product_template_additional_pictures/images/039/750/456/original/603678_03.jpg.jpeg?1595455218',
  'https://gsr.dev/material2-carousel/assets/demo.png',
 'https://gsr.dev/material2-carousel/assets/demo.png',
 'https://gsr.dev/material2-carousel/assets/demo.png'
];


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
