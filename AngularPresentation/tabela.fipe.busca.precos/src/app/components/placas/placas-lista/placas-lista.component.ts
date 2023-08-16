import { Component, OnInit } from '@angular/core';
import { Placa } from 'src/app/models/placa.model';
import { PlacasService } from 'src/app/services/placas.service';

@Component({
  selector: 'app-placas-lista',
  templateUrl: './placas-lista.component.html',
  styleUrls: ['./placas-lista.component.css']
})
export class PlacasListaComponent implements OnInit {
  placas: Placa[] = [];

  constructor(private placasService: PlacasService) { }

  ngOnInit(): void {
    this.placasService.listarTodasPlacas()
      .subscribe({
        next: (placas) => {
          this.placas = placas;
        },
        error: (response) => {
          console.log(response);
        }
      });
  }
}
