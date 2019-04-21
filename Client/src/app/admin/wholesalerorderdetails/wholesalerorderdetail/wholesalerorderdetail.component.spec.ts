import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WholesalerorderdetailComponent } from './wholesalerorderdetail.component';

describe('WholesalerorderdetailComponent', () => {
  let component: WholesalerorderdetailComponent;
  let fixture: ComponentFixture<WholesalerorderdetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WholesalerorderdetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WholesalerorderdetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
