import { TestBed } from '@angular/core/testing';

import { LocaltradersdetailService } from './localtradersdetail.service';

describe('LocaltradersdetailService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: LocaltradersdetailService = TestBed.get(LocaltradersdetailService);
    expect(service).toBeTruthy();
  });
});
