import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductunitListComponent } from './productunit-list.component';

describe('ProductunitListComponent', () => {
  let component: ProductunitListComponent;
  let fixture: ComponentFixture<ProductunitListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProductunitListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductunitListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
