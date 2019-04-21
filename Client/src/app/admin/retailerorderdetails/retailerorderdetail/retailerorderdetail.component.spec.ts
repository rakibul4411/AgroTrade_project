import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RetailerorderdetailComponent } from './retailerorderdetail.component';

describe('RetailerorderdetailComponent', () => {
  let component: RetailerorderdetailComponent;
  let fixture: ComponentFixture<RetailerorderdetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RetailerorderdetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RetailerorderdetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
