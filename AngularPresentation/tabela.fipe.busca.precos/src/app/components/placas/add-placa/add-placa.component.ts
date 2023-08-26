import { Component, OnInit } from '@angular/core';
import { Placa } from 'src/app/models/placa.model';

@Component({
  selector: 'app-add-placa',
  templateUrl: './add-placa.component.html',
  styleUrls: ['./add-placa.component.css']
})
export class AddPlacaComponent implements OnInit {
  addPlacaRequest: Placa = {
    id: '',
    codigo: '',
    valor: '',
    marca: '',
    modelo: '',
    anoModelo: 0,
    combustivel: '',
    codigoFipe: '',
    mesReferencia: '',
    tipoVeiculo: 0,
    siglaCombustivel: '',
    dataConsulta: '',
  };

  constructor() { }

  ngOnInit(): void {
  }
}
