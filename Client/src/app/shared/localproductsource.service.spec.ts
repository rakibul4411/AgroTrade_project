import { TestBed } from '@angular/core/testing';

import { LocalproductsourceService } from './localproductsource.service';

describe('LocalproductsourceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: LocalproductsourceService = TestBed.get(LocalproductsourceService);
    expect(service).toBeTruthy();
  });
});
