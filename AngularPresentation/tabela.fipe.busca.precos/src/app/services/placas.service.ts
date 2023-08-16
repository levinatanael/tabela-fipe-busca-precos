import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Placa } from '../models/placa.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PlacasService {

  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) { }

  listarTodasPlacas(): Observable<Placa[]> {
    return this.http.get<Placa[]>(this.baseApiUrl + 'api/placas');
  }
}
