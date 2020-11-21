import { Component, Inject, OnInit } from '@angular/core'
import { FormBuilder, FormGroup, Validators } from '@angular/forms'
import { MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog'

import { ToastrService } from 'ngx-toastr'

import { WalletService } from 'src/app/services/wallet.service'

import AddWalletRequestModel from 'src/app/models/wallet/RequestModels/AddWalletRequestModel'
import UpdateWalletRequestModel from 'src/app/models/wallet/RequestModels/UpdateWalletRequestModel'

@Component({
  selector: 'app-update-add-wallet-modal',
  templateUrl: './add-update-wallet-modal.component.html'
})

export class AddUpdateWalletModalComponent implements OnInit {
  constructor(@Inject(MAT_DIALOG_DATA) private modalData: ModalData,
    private formBuilder: FormBuilder,
    public dialogRef: MatDialogRef<AddUpdateWalletModalComponent>,
    private toastrService: ToastrService,
    private walletService: WalletService) {
    if (this.modalData.type === 1) {
      this.title = 'New Wallet'
    }
    else if (this.modalData.type === 2) {
      this.title = 'Update Wallet'
    }
  }

  addWalletFormGroup: FormGroup

  addWalletRequestModel: AddWalletRequestModel
  updateWalletRequestModel: UpdateWalletRequestModel

  title: string

  ngOnInit(): void {
    this.createAddWalletForm()
  }

  save(): void {
    console.log('data', this.modalData)

    const form = this.addWalletFormGroup.value

    if (this.modalData.type === 1) {
      console.log('add')

      this.addWalletRequestModel = new AddWalletRequestModel(form.name, form.startDate, form.endDate)

      this.walletService.add(this.addWalletRequestModel)
    }
    else if (this.modalData.type === 2) {
      console.log('update')

      this.updateWalletRequestModel = new UpdateWalletRequestModel(this.modalData.id, form.name, form.startDate, form.endDate)

      this.walletService.add(this.updateWalletRequestModel)
    }

    this.addWalletFormGroup.reset()

    this.toastrService.success('Added Successfully')

    this.toastrService.error('Error :/')
  }

  cancel(): void {
    this.dialogRef.close()
  }

  createAddWalletForm(): void {
    this.addWalletFormGroup = this.formBuilder.group({
      name: ['value', Validators.compose([Validators.required, Validators.minLength(3), Validators.maxLength(40)])],
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

interface ModalData {
  type: number
  id: string
}
