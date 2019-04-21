import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RetailersdetailListComponent } from './retailersdetail-list.component';

describe('RetailersdetailListComponent', () => {
  let component: RetailersdetailListComponent;
  let fixture: ComponentFixture<RetailersdetailListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RetailersdetailListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RetailersdetailListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
