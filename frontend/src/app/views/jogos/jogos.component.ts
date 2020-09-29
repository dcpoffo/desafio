import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HeaderService } from 'src/app/services/header.service';

@Component({
  selector: 'app-jogos',
  templateUrl: './jogos.component.html',
  styleUrls: ['./jogos.component.scss']
})
export class JogosComponent implements OnInit {

  constructor(
    private router: Router,
    private headerService: HeaderService
  ) {
    headerService.headerData = {
      title: 'Tabela de Jogos',
      icon: 'sports_basketball',
      routeUrl: '/jogos'
    };
  }

  ngOnInit() {
  }

  novaPontuacao(): void {
    this.router.navigate(['/jogos/create']);
  }
}
