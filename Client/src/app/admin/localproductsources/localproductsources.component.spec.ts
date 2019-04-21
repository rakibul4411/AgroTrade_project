import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LocalproductsourcesComponent } from './localproductsources.component';

describe('LocalproductsourcesComponent', () => {
  let component: LocalproductsourcesComponent;
  let fixture: ComponentFixture<LocalproductsourcesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LocalproductsourcesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LocalproductsourcesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
