import { NgModule } from '@angular/core'
import { Routes, RouterModule } from '@angular/router'

import { WalletIndexComponent } from '../components/wallet/wallet-index/wallet-index.component'

const routes: Routes = [
  { path: 'wallet', component: WalletIndexComponent },
  { path: '', redirectTo: 'wallet', pathMatch: 'full' }
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule {

}
