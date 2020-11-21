import { Component, OnInit } from '@angular/core'
import { FormBuilder, FormGroup } from '@angular/forms'
import { MatDialogRef } from '@angular/material/dialog'

import { ToastrService } from 'ngx-toastr'

@Component({
  selector: 'app-add-wallet-modal',
  templateUrl: './add-wallet-modal.component.html'
})

export class AddWalletModalComponent implements OnInit {
  constructor(private formBuilder: FormBuilder,
    public dialogRef: MatDialogRef<AddWalletModalComponent>,
    private toastrService: ToastrService) {

  }

  addWalletFormGroup: FormGroup

  ngOnInit(): void {
    this.createAddWalletForm()
  }

  cancel(): void {
    this.dialogRef.close()
  }

  save(): void {
    console.log(this.addWalletFormGroup.value)

    this.toastrService.success('Added Successfully')

    this.toastrService.error('Error :/')
  }

  createAddWalletForm(): void {
    this.addWalletFormGroup = this.formBuilder.group({
      name: [''],
      startDate: [''],
      endDate: ['']
    })
  }
}
