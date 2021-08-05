import {Component} from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { cliente } from 'src/app/Model/cliente';
import { ApiclienteService } from 'src/app/services/apicliente.service';

@Component({
    templateUrl: 'dialogcliente.component.html'
})

export class dialogClienteComponent{
    public nombre:string='';
    constructor(
        public dilogRef: MatDialogRef<dialogClienteComponent>,
        public apiCliente: ApiclienteService,
        public snackBar : MatSnackBar
    ){
       
    }
    close(){
        this.dilogRef.close();
    }
    addCliente(){
        const cliente :cliente ={nombre:this.nombre};
        this.apiCliente.addClient(cliente).subscribe(response=>{
            if(response.exito===1){
                this.dilogRef.close();
                this.snackBar.open("Cliente einsertado con exito",'',{
                    duration: 2000
                });
            }
        });
    }
}