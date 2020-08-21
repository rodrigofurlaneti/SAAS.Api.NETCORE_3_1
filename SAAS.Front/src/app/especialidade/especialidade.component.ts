import { Component, OnInit } from '@angular/core';
import { EspecialidadeService } from './especialidade.service';
import { Especialidade } from '../../models/Especialidade';

@Component({
  selector: 'app-especialidade',
  templateUrl: './especialidade.component.html',
  styleUrls: ['./especialidade.component.css']
})
export class EspecialidadeComponent implements OnInit {

  especialidades: Array<Especialidade> = new Array();

  constructor(private especialidadeService: EspecialidadeService) { this.especialidadeService = especialidadeService }

  ngOnInit(): void {
    this.listEspecialidades();
  }
  listEspecialidades(){
    this.especialidadeService.listEspecialidades().subscribe({
      next: resp => { this.especialidades = resp; console.log(resp); },
      error: erro => { console.log('Erro ao executar a função listEspecialidades()!', erro)},
      complete: () => { console.log('Completo a função listEspecialidades()!')}
    })
  }
}
