import { TestBed } from '@angular/core/testing';

import { TradercategoryService } from './tradercategory.service';

describe('TradercategoryService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: TradercategoryService = TestBed.get(TradercategoryService);
    expect(service).toBeTruthy();
  });
});
