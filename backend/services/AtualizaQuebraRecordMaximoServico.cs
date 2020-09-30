using backend.models;

namespace backend.services
{
    public class AtualizaQuebraRecordMaximoServico
    {
        public int AtualizaQuebraRecordMinimo(Jogo jogo, int quantidadeJogadas, int recordMaximo, int placarMaximo)
          {
               if (quantidadeJogadas == 0)
               {
                    return recordMaximo;
               }
               else
               {
                    if (jogo.Placar > placarMaximo)
                    {
                         return recordMaximo + 1;
                    }
               }
               return recordMaximo;
          }
    }
}