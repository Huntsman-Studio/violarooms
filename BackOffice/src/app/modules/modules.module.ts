import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RoomsComponent } from './rooms/rooms.component';
import { CustomersComponent } from './customers/customers.component';



@NgModule({
  declarations: [
    RoomsComponent,
    CustomersComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    RoomsComponent,
    CustomersComponent
  ]
})
export class ModulesModule { }
