import { BrowserModule } from '@angular/platform-browser'
import { NgModule } from '@angular/core'

import { AppRoutingModule } from './app-routing.module'

import { AppComponent } from './app.component'

import { NavbarComponent } from './components/shared/navbar/navbar.component'
import { FooterComponent } from './components/shared/footer/footer.component'

import { WalletIndexComponent } from './components/wallet/wallet-index/wallet-index.component'

@NgModule({
  declarations: [
    AppComponent,
    WalletIndexComponent,
    NavbarComponent,
    FooterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})

export class AppModule { }
