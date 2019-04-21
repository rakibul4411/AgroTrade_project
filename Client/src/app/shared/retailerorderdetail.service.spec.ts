import { TestBed } from '@angular/core/testing';

import { RetailerorderdetailService } from './retailerorderdetail.service';

describe('RetailerorderdetailService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: RetailerorderdetailService = TestBed.get(RetailerorderdetailService);
    expect(service).toBeTruthy();
  });
});
