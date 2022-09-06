import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RoomsComponent } from './rooms/rooms.component';
import { CustomersComponent } from './customers/customers.component';
import { ReservationsComponent } from './reservations/reservations.component';

@NgModule({
  declarations: [
    RoomsComponent,
    CustomersComponent,
    ReservationsComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    RoomsComponent,
    CustomersComponent,
    ReservationsComponent
  ]
})
export class ModulesModule { }
