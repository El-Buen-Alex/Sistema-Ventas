import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { cliente } from '../Model/cliente';
import {response} from '../Model/response';

const _httpOptions={
  headers:new HttpHeaders({
    'Contend-Type': 'application/json'
  })

}

//inyeccion de dependencias
@Injectable({
  providedIn: 'root'
})
export class ApiclienteService {
  url: string='https://localhost:44318/api/cliente';
  constructor(
    private _http: HttpClient
  ) { }

    getClients(): Observable<response> {
      return this._http.get<response>(this.url);
  }
  addClient(cliente: cliente): Observable<response>{
    return this._http.post<response>(this.url, cliente, _httpOptions);
  }
}

