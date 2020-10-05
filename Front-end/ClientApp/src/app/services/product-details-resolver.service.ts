import { Injectable } from '@angular/core';
import {ActivatedRouteSnapshot, RouterStateSnapshot, Router, Resolve} from '@angular/router';
import { Observable, of} from 'rxjs';
import { catchError } from 'rxjs/operators';
import {ProductsService} from './products.service';
import {Product} from './../models/Product';

@Injectable({
  providedIn: 'root'
})
export class ProductDetailsResolverService implements Resolve<Product> {

constructor(private router: Router, private productsService: ProductsService) { }

resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot):
Observable<Product> | Product {
  const productId = route.params['id'];
  return this.productsService.getProduct(+productId).pipe(

    catchError(err => {
      this.router.navigate(['/']);
      return of(null);
    })
    );

}



}
