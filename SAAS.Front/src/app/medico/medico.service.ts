import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Urls } from '../../helpers/Urls';
import { Medico } from '../../models/Medico';

@Injectable({
  providedIn: 'root'
})
export class MedicoService {

  httpClient: HttpClient;

  constructor(httpClient: HttpClient) { this.httpClient = httpClient }

  listMedicos(): Observable<any>{
    let ep = Urls.Medicos;
    return this.httpClient.get<Medico[]>(ep);
  }
  
}
