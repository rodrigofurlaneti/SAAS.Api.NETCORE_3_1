import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EspecialidadeComponent } from './especialidade.component';

@NgModule({
  declarations: [EspecialidadeComponent],
  exports: [EspecialidadeComponent],
  imports: [
    CommonModule
  ]
})
export class EspecialidadeModule { }
