import { Injectable } from '@angular/core';
import { Collection } from '../models/Collection';
import {ActivatedRouteSnapshot, RouterStateSnapshot, Router, Resolve} from '@angular/router';
import { Observable, of} from 'rxjs';
import { CollectionsService } from './collections.service';
import { catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class CollectionsListingResolverService implements Resolve<Collection[]>{

constructor(private router: Router, private collectionsService: CollectionsService) { }

resolve(route: ActivatedRouteSnapshot, state: RouterStateSnapshot):
Observable<Collection[]> | Collection[] {
  return this.collectionsService.getAllCollections().pipe(
    catchError(err => {
      this.router.navigate(['/']);
      return of(null);
    })
    );

}
}
