import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LocaltradersdetailComponent } from './localtradersdetail.component';

describe('LocaltradersdetailComponent', () => {
  let component: LocaltradersdetailComponent;
  let fixture: ComponentFixture<LocaltradersdetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LocaltradersdetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LocaltradersdetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
