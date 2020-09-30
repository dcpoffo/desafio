import { JogoService } from './../../../services/jogo.service';
import { Component, OnInit } from '@angular/core';
import { Jogo } from 'src/app/models/Jogo';
import { Router } from '@angular/router';
import { MensagemService } from 'src/app/services/mensagem.service';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-jogo-create',
  templateUrl: './jogo-create.component.html',
  styleUrls: ['./jogo-create.component.scss']
})
export class JogoCreateComponent implements OnInit {

  form = new FormGroup({
    placar: new FormControl('', [Validators.required, Validators.max(999)])
  });

  jogo: Jogo = {
    // placar: 0,
    pontuacaoMinimaTemporada: 0,
    pontuacaoMaximaTemporada: 0,
    quantidadeRecordMinimoQuebrado: 0,
    quantidadeRecordMaximoQuebrado: 0,
  };

  constructor(
    private jogoServico: JogoService,
    private router: Router,
    private mensagemServico: MensagemService
  ) { }

  ngOnInit() { }

  cadastrarNovoJogo(): void {
    this.jogoServico.post(this.jogo).subscribe(() => {
      this.mensagemServico.showMessage('Jogo cadastrado com sucesso!');
      this.router.navigate(['/jogos']);
    });
  }

  cancelar(): void {
    this.router.navigate(['/jogos']);
  }

  public hasError = (controlName: string, errorName: string) =>{
    return this.form.controls[controlName].hasError(errorName);
  }
}
