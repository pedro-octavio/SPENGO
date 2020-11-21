import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EmptyresultComponent } from './empty-result.component';

describe('EmptyresultComponent', () => {
  let component: EmptyresultComponent;
  let fixture: ComponentFixture<EmptyresultComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EmptyresultComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EmptyresultComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
