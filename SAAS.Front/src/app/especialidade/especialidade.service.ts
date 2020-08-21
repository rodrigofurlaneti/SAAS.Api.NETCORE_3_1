import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Urls } from '../../helpers/Urls';
import { Especialidade } from '../../models/Especialidade';

@Injectable({
  providedIn: 'root'
})
export class EspecialidadeService {

  httpClient: HttpClient;

  constructor(httpClient: HttpClient) { this.httpClient = httpClient }

  listEspecialidades(): Observable<any>{
    let ep = Urls.Especialidades;
    return this.httpClient.get<Especialidade[]>(ep);
  }
}
