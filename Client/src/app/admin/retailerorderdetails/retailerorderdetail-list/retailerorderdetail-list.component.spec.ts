import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RetailerorderdetailListComponent } from './retailerorderdetail-list.component';

describe('RetailerorderdetailListComponent', () => {
  let component: RetailerorderdetailListComponent;
  let fixture: ComponentFixture<RetailerorderdetailListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RetailerorderdetailListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RetailerorderdetailListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
