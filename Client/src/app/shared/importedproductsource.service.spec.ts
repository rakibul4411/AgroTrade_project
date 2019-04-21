import { TestBed } from '@angular/core/testing';

import { ImportedproductsourceService } from './importedproductsource.service';

describe('ImportedproductsourceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ImportedproductsourceService = TestBed.get(ImportedproductsourceService);
    expect(service).toBeTruthy();
  });
});
