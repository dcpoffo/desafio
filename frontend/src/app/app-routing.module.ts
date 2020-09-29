import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './views/home/home.component';

import { JogosComponent } from './views/jogos/jogos.component';
import { JogoCreateComponent } from './components/jogo/jogo-create/jogo-create.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'jogos', component: JogosComponent },
  { path: 'jogos/create', component: JogoCreateComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
