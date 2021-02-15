import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditoutletComponent } from './editoutlet.component';

describe('EditoutletComponent', () => {
  let component: EditoutletComponent;
  let fixture: ComponentFixture<EditoutletComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditoutletComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EditoutletComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
