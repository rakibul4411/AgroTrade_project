import { TestBed } from '@angular/core/testing';

import { WholesalerorderdetailService } from './wholesalerorderdetail.service';

describe('WholesalerorderdetailService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: WholesalerorderdetailService = TestBed.get(WholesalerorderdetailService);
    expect(service).toBeTruthy();
  });
});
