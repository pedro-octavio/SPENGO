import { ComponentFixture, TestBed } from '@angular/core/testing'

import { WalletIndexComponent } from './wallet-index.component'

describe('WalletIndexComponent', () => {
  let component: WalletIndexComponent
  let fixture: ComponentFixture<WalletIndexComponent>

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ WalletIndexComponent ]
    })
    .compileComponents()
  })

  beforeEach(() => {
    fixture = TestBed.createComponent(WalletIndexComponent)
    component = fixture.componentInstance
    fixture.detectChanges()
  })

  it('should create', () => {
    expect(component).toBeTruthy()
  })
})
