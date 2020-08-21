import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-area-trabalho',
  templateUrl: './area-trabalho.component.html',
  styleUrls: ['./area-trabalho.component.css']
})
export class AreaTrabalhoComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit(){
  }
  abrirMedico(){
    this.router.navigate(['medico'])
  }
  abrirEspecialidade(){
    this.router.navigate(['especialidade'])
  }

}
