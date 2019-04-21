import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LocaltradersdetailListComponent } from './localtradersdetail-list.component';

describe('LocaltradersdetailListComponent', () => {
  let component: LocaltradersdetailListComponent;
  let fixture: ComponentFixture<LocaltradersdetailListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LocaltradersdetailListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LocaltradersdetailListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
