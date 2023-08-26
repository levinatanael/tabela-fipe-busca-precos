import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PlacasListaComponent } from './components/placas/placas-lista/placas-lista.component';
import { AddPlacaComponent } from './components/placas/add-placa/add-placa.component';
import { ConsultaPlacaComponent } from './components/placas/consulta-placa/consulta-placa.component';

const routes: Routes = [
  {
    path: '',
    component: PlacasListaComponent
  },
  {
    path: 'placas',
    component: PlacasListaComponent
  },
  {
    path: 'placas/add',
    component: ConsultaPlacaComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
