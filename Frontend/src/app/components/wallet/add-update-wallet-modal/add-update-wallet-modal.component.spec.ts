import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddUpdateWalletModalComponent } from './add-update-wallet-modal.component';

describe('AddWalletModalComponent', () => {
  let component: AddUpdateWalletModalComponent;
  let fixture: ComponentFixture<AddUpdateWalletModalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [AddUpdateWalletModalComponent]
    })
      .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddUpdateWalletModalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
