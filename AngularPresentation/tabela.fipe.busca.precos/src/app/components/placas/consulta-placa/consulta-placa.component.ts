import { Component } from '@angular/core';
import { PlacasService } from 'src/app/services/placas.service';

@Component({
  selector: 'app-consulta-placa',
  templateUrl: './consulta-placa.component.html',
  styleUrls: ['./consulta-placa.component.css']
})
export class ConsultaPlacaComponent {
  formData = {
    codigo: '',
    ano: ''
  };

  constructor(private placasService: PlacasService) { }

  onSubmit() {
    this.placasService.consultar(this.formData.codigo, Number(this.formData.ano))
      .subscribe({
        next: (placa) => {
          console.log(placa);
        },
        error: (response) => {
          console.log(response);
        }
      });
  }
}
