import { Component, OnInit } from '@angular/core';
import { MedicoService } from './medico.service';
import { Medico } from '../../models/Medico';

@Component({
  selector: 'app-medico',
  templateUrl: './medico.component.html',
  styleUrls: ['./medico.component.css']
})
export class MedicoComponent implements OnInit {

  medicos: Array<Medico> = new Array();

  constructor(private medicoService: MedicoService) { this.medicoService = medicoService }

  ngOnInit(){
    this.listMedicos();
  }
  listMedicos(){
    this.medicoService.listMedicos().subscribe({
      next: resp => { this.medicos = resp; console.log(resp); },
      error: erro => { console.log('Erro ao executar a função listMedicos()!', erro)},
      complete: () => { console.log('Completo a função listMedicos()!')}
    })
  }
}
