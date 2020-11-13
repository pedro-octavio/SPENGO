import { Component, OnInit } from '@angular/core'

import { WalletService } from 'src/app/services/wallet.service'

import GetAllWallet from 'src/app/models/wallet/GetAllWallet'

@Component({
  selector: 'app-wallet-index',
  templateUrl: './wallet-index.component.html'
})

export class WalletIndexComponent implements OnInit {
  constructor(private walletService: WalletService) {

  }

  getAllWallet: GetAllWallet[]

  ngOnInit() {
    this.getAllWallet = this.walletService.getAll()
  }
}
