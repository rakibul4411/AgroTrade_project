import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RetailerorderdetailsComponent } from './retailerorderdetails.component';

describe('RetailerorderdetailsComponent', () => {
  let component: RetailerorderdetailsComponent;
  let fixture: ComponentFixture<RetailerorderdetailsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RetailerorderdetailsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RetailerorderdetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
