import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LocaltraderorderdetailComponent } from './localtraderorderdetail.component';

describe('LocaltraderorderdetailComponent', () => {
  let component: LocaltraderorderdetailComponent;
  let fixture: ComponentFixture<LocaltraderorderdetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LocaltraderorderdetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LocaltraderorderdetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
