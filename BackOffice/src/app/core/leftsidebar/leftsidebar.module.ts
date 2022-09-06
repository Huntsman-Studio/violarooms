import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LeftsidebarComponent } from './leftsidebar.component';
import { AppRoutingModule } from 'src/app/app-routing.module';



@NgModule({
  declarations: [
    LeftsidebarComponent
  ],
  imports: [
    CommonModule,
    AppRoutingModule
  ],
  exports: [
    LeftsidebarComponent
  ]
})
export class LeftsidebarModule { }
