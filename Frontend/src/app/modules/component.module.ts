import { NgModule } from '@angular/core'
import { CommonModule } from '@angular/common'
import { ReactiveFormsModule } from '@angular/forms'

import { FooterComponent } from '../components/shared/footer/footer.component'
import { NavbarComponent } from '../components/shared/navbar/navbar.component'
import { AddUpdateWalletModalComponent } from '../components/wallet/add-update-wallet-modal/add-update-wallet-modal.component'
import { WalletIndexComponent } from '../components/wallet/wallet-index/wallet-index.component'
import { EmptyresultComponent } from '../components/shared/emptyresult/empty-result.component'

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
        EmptyresultComponent
    ],
    exports: [
        AddUpdateWalletModalComponent,
        FooterComponent,
        NavbarComponent,
        WalletIndexComponent,
        EmptyresultComponent
    ],
})

export class ComponentModule {

}
