import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PlacasListaComponent } from './components/placas/placas-lista/placas-lista.component';

const routes: Routes = [
  {
    path: '',
    component: PlacasListaComponent
  },
  {
    path: 'placas',
    component: PlacasListaComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
