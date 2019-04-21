import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LocalproductsourceComponent } from './localproductsource.component';

describe('LocalproductsourceComponent', () => {
  let component: LocalproductsourceComponent;
  let fixture: ComponentFixture<LocalproductsourceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LocalproductsourceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LocalproductsourceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
