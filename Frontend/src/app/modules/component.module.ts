import { NgModule } from '@angular/core'
import { CommonModule } from '@angular/common'
import { ReactiveFormsModule } from '@angular/forms'

import { FooterComponent } from '../components/shared/footer/footer.component'
import { NavbarComponent } from '../components/shared/navbar/navbar.component'
import { AddUpdateWalletModalComponent } from '../components/wallet/add-update-wallet-modal/add-update-wallet-modal.component'
import { WalletIndexComponent } from '../components/wallet/wallet-index/wallet-index.component'
import { EmptyresultComponent } from '../components/shared/emptyresult/empty-result.component'
import { WalletShowComponent } from '../components/wallet/wallet-show/wallet-show.component'

@NgModule({
    imports: [
        CommonModule,
        ReactiveFormsModule
    ],
    declarations: [
        AddUpdateWalletModalComponent,
        FooterComponent,
        NavbarComponent,
        WalletIndexComponent,
        EmptyresultComponent,
        WalletShowComponent
    ],
    exports: [
        AddUpdateWalletModalComponent,
        FooterComponent,
        NavbarComponent,
        WalletIndexComponent,
        EmptyresultComponent,
        WalletShowComponent
    ],
})

export class ComponentModule {

}
