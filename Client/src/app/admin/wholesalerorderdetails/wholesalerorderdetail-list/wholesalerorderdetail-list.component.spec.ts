import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WholesalerorderdetailListComponent } from './wholesalerorderdetail-list.component';

describe('WholesalerorderdetailListComponent', () => {
  let component: WholesalerorderdetailListComponent;
  let fixture: ComponentFixture<WholesalerorderdetailListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WholesalerorderdetailListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WholesalerorderdetailListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
