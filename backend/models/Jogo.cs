namespace backend.models
{
     public class Jogo
     {
          public int Id { get; set; }
          public int Placar { get; set; }
          public int PontuacaoMinimaTemporada { get; set; }
          public int PontuacaoMaximaTemporada { get; set; }
          public int QuantidadeRecordMinimoQuebrado { get; set; }
          public int QuantidadeRecordMaximoQuebrado { get; set; }

          public Jogo() { }

          public Jogo(int id, int placar, int pontuacaoMinimaTemporada, int pontuacaoMaximaTemporada, int quantidadeRecordMinimoQuebrado, int quantidadeRecordMaximoQuebrado)
          {
               Id = id;
               Placar = placar;
               PontuacaoMinimaTemporada = pontuacaoMinimaTemporada;
               PontuacaoMaximaTemporada = pontuacaoMaximaTemporada;
               QuantidadeRecordMinimoQuebrado = quantidadeRecordMinimoQuebrado;
               QuantidadeRecordMaximoQuebrado = quantidadeRecordMaximoQuebrado;
          }
     }
}