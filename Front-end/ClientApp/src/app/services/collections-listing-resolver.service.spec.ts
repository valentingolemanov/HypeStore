/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { CollectionsListingResolverService } from './collections-listing-resolver.service';

describe('Service: CollectionsListingResolver', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [CollectionsListingResolverService]
    });
  });

  it('should ...', inject([CollectionsListingResolverService], (service: CollectionsListingResolverService) => {
    expect(service).toBeTruthy();
  }));
});
