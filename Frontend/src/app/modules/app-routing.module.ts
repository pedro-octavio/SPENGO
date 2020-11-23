import { NgModule } from '@angular/core'
import { BrowserModule } from '@angular/platform-browser'
import { Routes, RouterModule } from '@angular/router'

import { WalletIndexComponent } from '../components/wallet/wallet-index/wallet-index.component'
import { WalletShowComponent } from '../components/wallet/wallet-show/wallet-show.component'

const routes: Routes = [
  { path: 'wallet', component: WalletIndexComponent },
  { path: 'wallet/:id', component: WalletShowComponent },
  { path: '', redirectTo: '/wallet', pathMatch: 'full' }
]

@NgModule({
  imports: [BrowserModule, RouterModule.forRoot(routes, { useHash: true })],
  exports: [RouterModule]
})

export class AppRoutingModule {

}
