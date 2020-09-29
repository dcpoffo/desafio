using System;
using backend.models;

namespace backend.services
{
     public class CalculoMinimoTemporadaServico
     {
          public int CalcularMinimoTemporada(Jogo jogo, int quantidadeJogadas, int placarMinimo, int recordMinimo)
          {
               if (quantidadeJogadas == 0 || jogo.Placar < placarMinimo)
               {
                    AtualizaQuebraRecordMinimoServico atualizaMinimo = new AtualizaQuebraRecordMinimoServico();
                    jogo.QuantidadeRecordMinimoQuebrado = atualizaMinimo.AtualizaQuebraRecordMinimo(jogo, quantidadeJogadas, recordMinimo, placarMinimo);

                    return jogo.Placar;
               }
               return placarMinimo;
          }
     }
}