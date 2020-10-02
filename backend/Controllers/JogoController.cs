using System;
using System.Linq;
using System.Threading.Tasks;
using backend.data;
using backend.models;
using backend.services;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
     [ApiController]
     [Route("[controller]")]
     public class JogoController : ControllerBase
     {
         private readonly IRepository _repositorio;

          public JogoController(IRepository repositorio)
          {
               _repositorio = repositorio;
          }

          [HttpGet]
          public async Task<IActionResult> GetAll()
          {
               try
               {
                    var result = await _repositorio.GetAllJogos();
                    return Ok(result);
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao obter Tabela de Jogos: \n{ex.Message}");
               }
          }         

          [HttpPost]
          public async Task<IActionResult> Post(Jogo jogo)
          {    
               var retorno = await _repositorio.GetAllJogos();          
               var quantidadeJogadas = retorno.Length;
               int placarMinimo = 0, placarMaximo = 0, recordMinimo = 0, recordMaximo = 0;

               foreach (var item in retorno)
               {
                    placarMinimo = item.PontuacaoMinimaTemporada;
                    placarMaximo = item.PontuacaoMaximaTemporada;
                    recordMinimo = item.QuantidadeRecordMinimoQuebrado;
                    recordMaximo = item.QuantidadeRecordMaximoQuebrado;
               }
               
               try
               {     
                    CalculoMinimoTemporadaServico calculoMinimo = new CalculoMinimoTemporadaServico();
                    jogo.PontuacaoMinimaTemporada = calculoMinimo.CalcularMinimoTemporada(jogo, quantidadeJogadas, placarMinimo, recordMinimo);

                    AtualizaQuebraRecordMinimoServico atualizaMinimo = new AtualizaQuebraRecordMinimoServico();
                    jogo.QuantidadeRecordMinimoQuebrado = atualizaMinimo.AtualizaQuebraRecordMinimo(jogo, quantidadeJogadas, recordMinimo, placarMinimo);

                    CalculoMaximoTemporadaServico calcumoMaximo = new CalculoMaximoTemporadaServico();
                    jogo.PontuacaoMaximaTemporada = calcumoMaximo.CalcularMaximoTemporada(jogo, quantidadeJogadas, placarMaximo);                    
                                        
                    AtualizaQuebraRecordMaximoServico atualizaMaximo = new AtualizaQuebraRecordMaximoServico();
                    jogo.QuantidadeRecordMaximoQuebrado = atualizaMaximo.AtualizaQuebraRecordMinimo(jogo, quantidadeJogadas, recordMaximo, placarMaximo);
                    
                    _repositorio.Add(jogo);
                    if (await _repositorio.SaveChangesAsync())
                    {
                         return Ok(jogo);
                    }
               }
               catch (Exception ex)
               {
                    return BadRequest($"Erro ao salvar Jogo: {ex.Message}");
               }
               return BadRequest();
          }

     }
}