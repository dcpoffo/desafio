using backend.models;

namespace backend.services
{
     public class AtualizaQuebraRecordMinimoServico
     {
          public int AtualizaQuebraRecordMinimo(Jogo jogo, int quantidadeJogadas, int recordMinimo, int placarMinimo)
          {
               if (quantidadeJogadas == 0)
               {
                    return recordMinimo;
               }
               else
               {
                    if (jogo.Placar < placarMinimo)
                    {
                         return recordMinimo + 1;
                    }
               }
               return recordMinimo;
          }
     }
}