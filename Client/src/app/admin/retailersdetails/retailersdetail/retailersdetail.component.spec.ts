import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RetailersdetailComponent } from './retailersdetail.component';

describe('RetailersdetailComponent', () => {
  let component: RetailersdetailComponent;
  let fixture: ComponentFixture<RetailersdetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RetailersdetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RetailersdetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
