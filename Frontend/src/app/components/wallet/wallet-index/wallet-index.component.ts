import { Component, OnInit } from '@angular/core'
import { FormBuilder, FormGroup } from '@angular/forms'
import { MatDialog } from '@angular/material/dialog'

import { WalletService } from 'src/app/services/wallet.service'

import GetAllWalletResponseModel from 'src/app/models/wallet/ResponseModels/GetAllWalletResponseModel'

import { AddUpdateWalletModalComponent } from '../add-update-wallet-modal/add-update-wallet-modal.component'

@Component({
  selector: 'app-wallet-index',
  templateUrl: './wallet-index.component.html'
})

export class WalletIndexComponent implements OnInit {
  constructor(private formBuilder: FormBuilder,
    private dialog: MatDialog,
    private walletService: WalletService) {

  }

  getAllWalletFormGroup: FormGroup

  getAllWalletResponseModel: GetAllWalletResponseModel[]

  createGetAllWallet(): void {
    this.getAllWalletFormGroup = this.formBuilder.group({
      startDate: [''],
      endDate: ['']
    })
  }

  ngOnInit(): void {
    this.createGetAllWallet()
  }

  openAddWalletDialog(): void {
    this.dialog.open(AddUpdateWalletModalComponent, { data: { type: 1, id: null } })
  }

  searchWallets(): void {
    console.log(this.getAllWalletFormGroup.value)

    this.getAllWalletResponseModel = [
      {
        id: 'dh38201pam',
        name: 'Wallet 1',
        isActive: true,
        endDate: null,
        startDate: null
      },
      {
        id: 'dh38201pam',
        name: 'Wallet 1',
        isActive: true,
        endDate: null,
        startDate: null
      },
      {
        id: 'dh38201pam',
        name: 'Wallet 1',
        isActive: true,
        endDate: null,
        startDate: null
      },
      {
        id: 'dh38201pam',
        name: 'Wallet 1',
        isActive: true,
        endDate: null,
        startDate: null
      }
    ]

    // this.walletService.getAll(this.datePipe.transform(this.startDate, 'MM-dd-yyyy'), this.datePipe.transform(this.endDate, 'MM-dd-yyyy')).subscribe(
    //   (_wallets: GetAllWalletResponseModel[]) => {

    //     this.getAllWallet = _wallets
    //   }, error => {

    //     alert(error)
    //   })
  }
}
