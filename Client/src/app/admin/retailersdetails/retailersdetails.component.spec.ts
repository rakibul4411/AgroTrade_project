import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RetailersdetailsComponent } from './retailersdetails.component';

describe('RetailersdetailsComponent', () => {
  let component: RetailersdetailsComponent;
  let fixture: ComponentFixture<RetailersdetailsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RetailersdetailsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RetailersdetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
