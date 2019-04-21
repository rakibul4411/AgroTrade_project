import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ImportedproductsourceListComponent } from './importedproductsource-list.component';

describe('ImportedproductsourceListComponent', () => {
  let component: ImportedproductsourceListComponent;
  let fixture: ComponentFixture<ImportedproductsourceListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ImportedproductsourceListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ImportedproductsourceListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
