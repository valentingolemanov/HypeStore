import { Injectable } from '@angular/core';
import {Brand} from './../models/brand';
import {ActivatedRouteSnapshot, RouterStateSnapshot, Router, Resolve} from '@angular/router';
import { Observable, of} from 'rxjs';
import { BrandsService } from './brands.service';
import { catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class BrandsListingResolverService implements Resolve<Brand[]>{

constructor(private brandsService: BrandsService,
  private router: Router) { }

resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot):
Observable<Brand[]> | Brand[] {
  return this.brandsService.getAllBrands().pipe(
    catchError(err => {
      this.router.navigate(['/']);
      return of(null);
    })
    );

}

}
