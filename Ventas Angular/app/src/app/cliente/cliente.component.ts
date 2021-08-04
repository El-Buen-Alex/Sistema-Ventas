import { Component, OnInit } from '@angular/core';
import { ApiclienteService } from '../services/apicliente.service';
import {response} from '../Model/response';
@Component({
  selector: 'app-cliente',
  templateUrl: './cliente.component.html',
  styleUrls: ['./cliente.component.scss']
})
export class ClienteComponent implements OnInit {

  public lista!: any[];
  public columnas : string[]=['id','nombre'];
  constructor(
    private apiCliente : ApiclienteService
  ) {
    
   }
  ngOnInit(): void {
    this.getClientes();
  }
  getClientes(){
    this.apiCliente.getClients().subscribe(response => {
      this.lista=response.data;
    })
  }
}
