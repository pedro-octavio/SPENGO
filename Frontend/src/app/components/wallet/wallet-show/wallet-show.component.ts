import { Component, OnInit } from '@angular/core'
import { ActivatedRoute } from '@angular/router'

@Component({
  selector: 'app-wallet-show',
  templateUrl: './wallet-show.component.html'
})

export class WalletShowComponent implements OnInit {
  constructor(private route: ActivatedRoute) {
    this.route.params.subscribe(res => this.walletId = res.id)

    console.log(`Wallet Id: ${this.walletId}`)
  }

  walletId: string

  ngOnInit(): void {

  }
}
