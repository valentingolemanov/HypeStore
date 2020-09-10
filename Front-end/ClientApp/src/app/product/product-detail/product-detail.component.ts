import { Component, OnInit } from '@angular/core';
import { IProduct } from '../IProduct.interface';
import { ProductsService } from 'src/app/services/products.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-product-detail',
  templateUrl: './product-detail.component.html',
  styleUrls: ['./product-detail.component.css']
})
export class ProductDetailComponent implements OnInit {

  product: IProduct ;
  constructor(private route: ActivatedRoute,
    private router: Router,
    private productsService: ProductsService) { }

  public productId;

  ngOnInit(): void {
      this.productId = +this.route.params['id'];

      this.route.params.subscribe(
        (params) => {
          this.productId = +params['id'];
          this.productsService.getProduct(this.productId).subscribe(
            (data: IProduct) => {
              console.log(data);
              this.product = data;
            },
            (err) => console.log(err),
            () =>  console.log(this.product)
          )
        }
      )
  }

}
