import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LocaltraderorderdetailsComponent } from './localtraderorderdetails.component';

describe('LocaltraderorderdetailsComponent', () => {
  let component: LocaltraderorderdetailsComponent;
  let fixture: ComponentFixture<LocaltraderorderdetailsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LocaltraderorderdetailsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LocaltraderorderdetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
