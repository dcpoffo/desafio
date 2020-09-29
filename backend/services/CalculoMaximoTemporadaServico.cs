using backend.models;

namespace backend.services
{
    public class CalculoMaximoTemporadaServico
    {
        public int CalcularMaximoTemporada(Jogo jogo, int quantidadeJogadas, int placaMaximo)
          {
               if (quantidadeJogadas == 0 || jogo.Placar > placaMaximo)
               {
                    return jogo.Placar;
               }
               return placaMaximo;
          }
    }
}