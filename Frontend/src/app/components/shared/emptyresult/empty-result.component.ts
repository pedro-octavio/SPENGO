import { Component, Input } from '@angular/core'

@Component({
  selector: 'app-empty-result',
  templateUrl: './empty-result.component.html'
})

export class EmptyresultComponent {
  constructor() {

  }

  @Input() message: string
}
