import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ImportedproductsourceComponent } from './importedproductsource.component';

describe('ImportedproductsourceComponent', () => {
  let component: ImportedproductsourceComponent;
  let fixture: ComponentFixture<ImportedproductsourceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ImportedproductsourceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ImportedproductsourceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
