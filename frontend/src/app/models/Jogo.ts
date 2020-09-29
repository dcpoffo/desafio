export class Jogo {
  id?: number;
  placar?: number;
  pontuacaoMinimaTemporada: number;
  pontuacaoMaximaTemporada: number;
  quantidadeRecordMinimoQuebrado: number;
  quantidadeRecordMaximoQuebrado: number;

  constructor() {
    this.id = 0;
    this.placar = 0;
    this.pontuacaoMinimaTemporada = 0;
    this.pontuacaoMaximaTemporada = 0;
    this.quantidadeRecordMinimoQuebrado = 0;
    this.quantidadeRecordMaximoQuebrado = 0;
  }
}
