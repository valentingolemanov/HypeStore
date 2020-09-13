/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { ProductDetailsResolverService } from './product-details-resolver.service';

describe('Service: ProductDetailsResolver', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ProductDetailsResolverService]
    });
  });

  it('should ...', inject([ProductDetailsResolverService], (service: ProductDetailsResolverService) => {
    expect(service).toBeTruthy();
  }));
});
