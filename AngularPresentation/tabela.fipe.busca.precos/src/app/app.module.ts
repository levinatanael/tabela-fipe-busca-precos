import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PlacasListaComponent } from './components/placas/placas-lista/placas-lista.component';
import { HttpClientModule } from '@angular/common/http';
import { AddPlacaComponent } from './components/placas/add-placa/add-placa.component';
import { FormsModule } from '@angular/forms';
import { ConsultaPlacaComponent } from './components/placas/consulta-placa/consulta-placa.component';

@NgModule({
  declarations: [
    AppComponent,
    PlacasListaComponent,
    AddPlacaComponent,
    ConsultaPlacaComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
