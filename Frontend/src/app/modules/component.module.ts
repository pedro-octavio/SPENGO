import { NgModule } from '@angular/core'
import { CommonModule } from '@angular/common'
import { ReactiveFormsModule } from '@angular/forms'

import { FooterComponent } from '../components/shared/footer/footer.component'
import { NavbarComponent } from '../components/shared/navbar/navbar.component'
import { AddWalletModalComponent } from '../components/wallet/add-wallet-modal/add-wallet-modal.component'
import { WalletIndexComponent } from '../components/wallet/wallet-index/wallet-index.component'

@NgModule({
    imports: [
        CommonModule,
        ReactiveFormsModule
    ],
    declarations: [
        AddWalletModalComponent,
        FooterComponent,
        NavbarComponent,
        WalletIndexComponent
    ],
    exports: [
        AddWalletModalComponent,
        FooterComponent,
        NavbarComponent,
        WalletIndexComponent
    ],
})

export class ComponentModule {

}
