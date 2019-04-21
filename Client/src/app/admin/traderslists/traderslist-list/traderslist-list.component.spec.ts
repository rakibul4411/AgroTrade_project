import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TraderslistListComponent } from './traderslist-list.component';

describe('TraderslistListComponent', () => {
  let component: TraderslistListComponent;
  let fixture: ComponentFixture<TraderslistListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TraderslistListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TraderslistListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
