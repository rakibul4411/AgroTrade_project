import { TestBed } from '@angular/core/testing';

import { ProductunitService } from './productunit.service';

describe('ProductunitService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ProductunitService = TestBed.get(ProductunitService);
    expect(service).toBeTruthy();
  });
});
