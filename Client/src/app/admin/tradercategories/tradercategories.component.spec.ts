import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TradercategoriesComponent } from './tradercategories.component';

describe('TradercategoriesComponent', () => {
  let component: TradercategoriesComponent;
  let fixture: ComponentFixture<TradercategoriesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TradercategoriesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TradercategoriesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
