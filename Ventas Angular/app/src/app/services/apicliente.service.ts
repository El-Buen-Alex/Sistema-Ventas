import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {response} from '../Model/response';
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
}

