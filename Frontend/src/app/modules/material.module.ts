import { NgModule } from '@angular/core'
import { BrowserAnimationsModule } from '@angular/platform-browser/animations'
import { MatDialogModule } from '@angular/material/dialog'
import { CommonModule } from '@angular/common'

@NgModule({
    imports: [
        BrowserAnimationsModule,
        CommonModule,
        MatDialogModule
    ],
    exports: [
        BrowserAnimationsModule,
        MatDialogModule
    ]
})

export class MaterialModule {

}
