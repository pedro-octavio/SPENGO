import { Injectable } from '@angular/core'

import GetAllWallet from '../models/wallet/GetAllWallet'

@Injectable({
  providedIn: 'root'
})

export class WalletService {
  constructor() {

  }

  getAllWallet: GetAllWallet[] = [
    {
      id: 'MA01PEGXÇA',
      name: 'February Wallet',
      lastUpdateDate: '01/02/2020',
      isOpen: false
    },
    {
      id: 'LA02GE7XAO',
      name: 'March Wallet',
      lastUpdateDate: '01/03/2020',
      isOpen: true
    },
    {
      id: 'MA01PEGXÇA',
      name: 'Januray Wallet',
      lastUpdateDate: '01/01/2020',
      isOpen: true
    }
  ]

  getAll() {
    return this.getAllWallet
  }
}
