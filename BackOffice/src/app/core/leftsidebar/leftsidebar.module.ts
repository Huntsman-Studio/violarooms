import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LeftsidebarComponent } from './leftsidebar.component';



@NgModule({
  declarations: [
    LeftsidebarComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    LeftsidebarComponent
  ]
})
export class LeftsidebarModule { }
