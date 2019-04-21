import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TraderslistsComponent } from './traderslists.component';

describe('TraderslistsComponent', () => {
  let component: TraderslistsComponent;
  let fixture: ComponentFixture<TraderslistsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TraderslistsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TraderslistsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
