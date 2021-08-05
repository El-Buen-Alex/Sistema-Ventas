import { Component, OnInit } from '@angular/core';
import { ApiclienteService } from '../services/apicliente.service';
import {response} from '../Model/response';
import { dialogClienteComponent } from './dialog/dialogcliente.component';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-cliente',
  templateUrl: './cliente.component.html',
  styleUrls: ['./cliente.component.scss']
})
export class ClienteComponent implements OnInit {

  public lista!: any[];
  public columnas : string[]=['id','nombre'];
  constructor(
    private apiCliente : ApiclienteService,
    public dialog: MatDialog
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
  openAdd(){
    const dialogRef= this.dialog.open(dialogClienteComponent,{
      width: "300"
    });
    dialogRef.afterClosed().subscribe(result=>{
      this.getClientes();
    })
  }
}
