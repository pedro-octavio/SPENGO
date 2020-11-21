import { HttpClient } from '@angular/common/http'
import { Injectable } from '@angular/core'

import AddWalletRequestModel from '../models/wallet/RequestModels/AddWalletRequestModel'
import GetAllWalletRequestModel from '../models/wallet/RequestModels/GetAllWalletRequestModel'

@Injectable({
  providedIn: 'root'
})

export class WalletService {
  constructor(private http: HttpClient) {

  }

  getAll(requestModel: GetAllWalletRequestModel): void {

  }

  add(requestModel: AddWalletRequestModel): void {

  }
}
