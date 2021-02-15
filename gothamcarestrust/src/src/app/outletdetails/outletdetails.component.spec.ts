import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OutletdetailsComponent } from './outletdetails.component';

describe('OutletdetailsComponent', () => {
  let component: OutletdetailsComponent;
  let fixture: ComponentFixture<OutletdetailsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OutletdetailsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OutletdetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
