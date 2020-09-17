/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { BrandsListingResolverService } from './brands-listing-resolver.service';

describe('Service: BrandsListingResolver', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [BrandsListingResolverService]
    });
  });

  it('should ...', inject([BrandsListingResolverService], (service: BrandsListingResolverService) => {
    expect(service).toBeTruthy();
  }));
});
