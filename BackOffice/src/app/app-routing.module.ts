import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CustomersComponent } from './modules/customers/customers.component';
import { RoomsComponent } from './modules/rooms/rooms.component';

const routes: Routes = [
  { path: "rooms", component: RoomsComponent },
  { path: "customers", component: CustomersComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
