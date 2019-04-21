import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductunitComponent } from './productunit.component';

describe('ProductunitComponent', () => {
  let component: ProductunitComponent;
  let fixture: ComponentFixture<ProductunitComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProductunitComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductunitComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
