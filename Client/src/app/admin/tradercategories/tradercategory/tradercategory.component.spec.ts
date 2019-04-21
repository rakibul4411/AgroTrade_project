import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TradercategoryComponent } from './tradercategory.component';

describe('TradercategoryComponent', () => {
  let component: TradercategoryComponent;
  let fixture: ComponentFixture<TradercategoryComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TradercategoryComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TradercategoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
