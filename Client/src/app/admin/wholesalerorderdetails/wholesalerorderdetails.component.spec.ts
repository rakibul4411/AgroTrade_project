import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WholesalerorderdetailsComponent } from './wholesalerorderdetails.component';

describe('WholesalerorderdetailsComponent', () => {
  let component: WholesalerorderdetailsComponent;
  let fixture: ComponentFixture<WholesalerorderdetailsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WholesalerorderdetailsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WholesalerorderdetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
