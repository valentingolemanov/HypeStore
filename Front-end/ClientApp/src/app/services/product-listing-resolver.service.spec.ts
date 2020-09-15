/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { ProductListingResolverService } from './product-listing-resolver.service';

describe('Service: ProductListingResolver', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ProductListingResolverService]
    });
  });

  it('should ...', inject([ProductListingResolverService], (service: ProductListingResolverService) => {
    expect(service).toBeTruthy();
  }));
});
