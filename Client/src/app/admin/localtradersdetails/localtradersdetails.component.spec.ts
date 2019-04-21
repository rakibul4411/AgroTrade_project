import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LocaltradersdetailsComponent } from './localtradersdetails.component';

describe('LocaltradersdetailsComponent', () => {
  let component: LocaltradersdetailsComponent;
  let fixture: ComponentFixture<LocaltradersdetailsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LocaltradersdetailsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LocaltradersdetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
