import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TradercategoryListComponent } from './tradercategory-list.component';

describe('TradercategoryListComponent', () => {
  let component: TradercategoryListComponent;
  let fixture: ComponentFixture<TradercategoryListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TradercategoryListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TradercategoryListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
