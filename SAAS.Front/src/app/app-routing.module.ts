import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MedicoComponent } from './medico/medico.component';
import { EspecialidadeComponent } from './especialidade/especialidade.component';
import { AreaTrabalhoComponent } from './area-trabalho/area-trabalho.component';
import { CommonModule } from '@angular/common';

const routes: Routes = [
  { path: 'area-trabalho/area-trabalho.component', component: AreaTrabalhoComponent },
  { path: 'medico', component: MedicoComponent },
  { path: 'especialidade', component: EspecialidadeComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes), CommonModule],
  exports: [RouterModule]
})
export class AppRoutingModule { }
