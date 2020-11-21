import { Component, OnInit } from '@angular/core'
import { FormBuilder, FormGroup, Validators } from '@angular/forms'
import { MatDialogRef } from '@angular/material/dialog'

import { ToastrService } from 'ngx-toastr'

import AddWalletRequestModel from 'src/app/models/wallet/RequestModels/AddWalletRequestModel'

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

  addWalletRequestModel: AddWalletRequestModel

  ngOnInit(): void {
    this.createAddWalletForm()
  }

  save(): void {
    const form = this.addWalletFormGroup.value

    this.addWalletRequestModel = new AddWalletRequestModel(form.name, form.startDate, form.endDate)

    console.log(this.addWalletRequestModel)

    this.toastrService.success('Added Successfully')

    this.toastrService.error('Error :/')

    this.addWalletFormGroup.reset()
  }

  cancel(): void {
    this.dialogRef.close()
  }

  createAddWalletForm(): void {
    this.addWalletFormGroup = this.formBuilder.group({
      name: ['', Validators.compose([Validators.required, Validators.minLength(3), Validators.maxLength(40)])],
      startDate: [''],
      endDate: ['']
    })
  }

  get name() {
    return this.addWalletFormGroup.get('name')
  }

  get startDate() {
    return this.addWalletFormGroup.get('startDate')
  }

  get endDate() {
    return this.addWalletFormGroup.get('endDate')
  }
}
