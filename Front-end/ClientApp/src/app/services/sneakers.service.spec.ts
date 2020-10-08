/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { SneakersService } from './sneakers.service';

describe('Service: Sneakers', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [SneakersService]
    });
  });

  it('should ...', inject([SneakersService], (service: SneakersService) => {
    expect(service).toBeTruthy();
  }));
});
