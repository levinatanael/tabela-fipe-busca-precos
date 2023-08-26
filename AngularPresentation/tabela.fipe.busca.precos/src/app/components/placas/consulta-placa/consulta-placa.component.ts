import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Placa } from 'src/app/models/placa.model';
import { PlacasService } from 'src/app/services/placas.service';

@Component({
  selector: 'app-consulta-placa',
  templateUrl: './consulta-placa.component.html',
  styleUrls: ['./consulta-placa.component.css']
})
export class ConsultaPlacaComponent {
  formData = {
    codigo: '',
    ano: '',
    placa: ''
  };

  dadosPlaca: Placa | undefined;
  dadosNaoEncontrado: boolean = false;
  camposNaoPreenchidos: boolean = false;
  placaNaoPreenchida: boolean = false;

  constructor(private placasService: PlacasService, private router: Router) { }

  onSubmit() {
    if (this.formData.codigo != '' && this.formData.ano != '') {
      this.camposNaoPreenchidos = false;
      this.dadosNaoEncontrado = false;
      this.formData.placa = '';
      this.placasService.consultar(this.formData.codigo, Number(this.formData.ano))
        .subscribe({
          next: (placa) => {
            this.dadosPlaca = placa;
            if (placa == null) {
              this.dadosNaoEncontrado = true;
            }
          },
          error: (response) => {
            console.log(response);
          }
        });
    }
    else {
      this.camposNaoPreenchidos = true;
    }
  }

  onSubmitFipe() {
    if (this.formData.placa != '' && this.dadosPlaca) {
      this.dadosPlaca.codigo = this.formData.placa;
      this.placasService.add(this.dadosPlaca)
        .subscribe({
          next: (placa) => {
            this.router.navigate(['/placas']);
          },
          error: (response) => {
            console.log(response);
          }
        });
    } else {
      this.placaNaoPreenchida = true;
    }
  }

  cancelar() {
    this.dadosPlaca = undefined;
    this.dadosNaoEncontrado = false;
    this.camposNaoPreenchidos = false;
    this.placaNaoPreenchida = false;
  }
}
