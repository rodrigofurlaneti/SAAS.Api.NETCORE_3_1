import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AreaTrabalhoComponent } from './area-trabalho.component';
import { MedicoModule } from '../medico/medico.module';

@NgModule({
  declarations: [
    AreaTrabalhoComponent
  ],
  exports:[
    AreaTrabalhoComponent
  ],
  imports: [
    CommonModule,
    MedicoModule
  ]
})
export class AreaTrabalhoModule { }
