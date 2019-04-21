import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LocalproductsourceListComponent } from './localproductsource-list.component';

describe('LocalproductsourceListComponent', () => {
  let component: LocalproductsourceListComponent;
  let fixture: ComponentFixture<LocalproductsourceListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LocalproductsourceListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LocalproductsourceListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
