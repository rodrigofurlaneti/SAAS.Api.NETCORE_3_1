import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MedicoComponent } from './medico.component';

@NgModule({
  declarations: [MedicoComponent],
  exports: [MedicoComponent],
  imports: [
    CommonModule
  ],
  providers: []
})
export class MedicoModule { }
