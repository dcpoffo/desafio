import { Component, OnInit } from '@angular/core';
import { Jogo } from 'src/app/models/Jogo';
import { JogoService } from 'src/app/services/jogo.service';

@Component({
  selector: 'app-jogo-read',
  templateUrl: './jogo-read.component.html',
  styleUrls: ['./jogo-read.component.scss']
})
export class JogoReadComponent implements OnInit {

  jogos: Jogo[];

  displayedColumns = ['id', 'placar', 'pontuacaoMinimaTemporada', 'pontuacaoMaximaTemporada', 'quantidadeRecordMinimoQuebrado', 'quantidadeRecordMaximoQuebrado' ];

  constructor(
    private jogoServico: JogoService
  ) { }

  ngOnInit() {
    this.jogoServico.getAll().subscribe(jogos => {
      this.jogos = jogos;

      // MEU TESTE
      if (jogos.length === 0) {
        console.log('NÃO TEM NADA CADASTRADO');
      }
      else
      {
        console.log('JÁ TEM CADASTRO ');
      }
    });
  }

}
