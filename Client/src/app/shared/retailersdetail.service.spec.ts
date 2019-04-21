import { TestBed } from '@angular/core/testing';

import { RetailersdetailService } from './retailersdetail.service';

describe('RetailersdetailService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: RetailersdetailService = TestBed.get(RetailersdetailService);
    expect(service).toBeTruthy();
  });
});
