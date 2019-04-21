import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LocaltraderorderdetailListComponent } from './localtraderorderdetail-list.component';

describe('LocaltraderorderdetailListComponent', () => {
  let component: LocaltraderorderdetailListComponent;
  let fixture: ComponentFixture<LocaltraderorderdetailListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LocaltraderorderdetailListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LocaltraderorderdetailListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
