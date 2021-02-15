import { ComponentFixture, TestBed } from '@angular/core/testing';

import { OutletsearchComponent } from './outletsearch.component';

describe('OutletsearchComponent', () => {
  let component: OutletsearchComponent;
  let fixture: ComponentFixture<OutletsearchComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ OutletsearchComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(OutletsearchComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
