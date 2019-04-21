import { TestBed } from '@angular/core/testing';

import { TraderslistService } from './traderslist.service';

describe('TraderslistService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: TraderslistService = TestBed.get(TraderslistService);
    expect(service).toBeTruthy();
  });
});
