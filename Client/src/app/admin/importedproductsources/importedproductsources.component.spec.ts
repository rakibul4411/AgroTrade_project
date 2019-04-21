import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ImportedproductsourcesComponent } from './importedproductsources.component';

describe('ImportedproductsourcesComponent', () => {
  let component: ImportedproductsourcesComponent;
  let fixture: ComponentFixture<ImportedproductsourcesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ImportedproductsourcesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ImportedproductsourcesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
