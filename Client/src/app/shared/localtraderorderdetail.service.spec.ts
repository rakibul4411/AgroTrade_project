import { TestBed } from '@angular/core/testing';

import { LocaltraderorderdetailService } from './localtraderorderdetail.service';

describe('LocaltraderorderdetailService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: LocaltraderorderdetailService = TestBed.get(LocaltraderorderdetailService);
    expect(service).toBeTruthy();
  });
});
