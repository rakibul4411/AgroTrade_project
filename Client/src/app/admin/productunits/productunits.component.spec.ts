import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductunitsComponent } from './productunits.component';

describe('ProductunitsComponent', () => {
  let component: ProductunitsComponent;
  let fixture: ComponentFixture<ProductunitsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProductunitsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductunitsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
