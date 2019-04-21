import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TraderslistComponent } from './traderslist.component';

describe('TraderslistComponent', () => {
  let component: TraderslistComponent;
  let fixture: ComponentFixture<TraderslistComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TraderslistComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TraderslistComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
