import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LeftsidebarModule } from './leftsidebar/leftsidebar.module';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    LeftsidebarModule
  ],
  exports: [
    LeftsidebarModule
  ]
})
export class CoreModule { }
