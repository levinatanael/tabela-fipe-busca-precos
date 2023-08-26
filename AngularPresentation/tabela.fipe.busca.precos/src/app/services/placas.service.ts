import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Placa } from '../models/placa.model';
import { Observable, throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PlacasService {

  placaConsultada: Placa | undefined;

  baseApiUrl: string = environment.baseApiUrl + 'placas/';
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  constructor(private http: HttpClient) { }

  listarTodasPlacas(): Observable<Placa[]> {
    return this.http.get<Placa[]>(this.baseApiUrl);
  }

  consultar(codigo: string, ano: number): Observable<Placa> {
    return this.http.get<Placa>(this.baseApiUrl + 'consultar/' + codigo + '/' + ano);
  }

  add(addPlacaRequest: Placa): Observable<Placa> {
    return this.http.post<Placa>(this.baseApiUrl, addPlacaRequest);
  }
}
