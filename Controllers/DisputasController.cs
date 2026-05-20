using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RpgApi.Data;
using RpgApi.Models;

namespace RpgApi.Controllers
{
    [Route("[controller]")]
    public class DisputasController : Controller
    {
        public readonly DataContext _context;
        public DisputasController(DataContext context)
        {
            _context = context;
        }

        [HttpPost("Arma")]
        public async Task<IActionResult> AtaqueComArmaAsync(Disputa d)
        {
            try
            {
                //Programação dos próximos passos aqui
                Personagem? atacante = await _context.TB_PERSONAGENS
                  .Include(p => p.Arma)
                  .FirstOrDefaultAsync(p => p.Id == d.AtacanteId );


                 Personagem? oponente = await _context.TB_PERSONAGENS
                  .Include(p => p.Arma)
                  .FirstOrDefaultAsync(p => p.Id == d.OponenteId );

                  int dano = atacante.Arma.Dano + (new Random().Next(atacante.Forca));

                  dano = dano - new Random().Next(oponente.Defesa);

                  if (dano > 0)
                    oponente.PontosVida = oponente.PontosVida - (int)dano;
                  if(oponente.PontosVida <= 0)
                    d.Narracao = $"{oponente.Nome} foi derrotado!"; 

                    _context.TB_PERSONAGENS.Update(oponente);
                    await _context.SaveChangesAsync(); 

                    StringBuilder dados = new StringBuilder();
                    dados.AppendFormat("Atacante: {0}. ", atacante.Nome);
                    dados.AppendFormat("Oponente: {0}. ", oponente.Nome);
                    dados.AppendFormat("Pontos de vida do atacante: {0}. ", atacante.PontosVida);
                    dados.AppendFormat("Pontos de vida do oponente: {0}. ", oponente.PontosVida);
                    dados.AppendFormat("Arma Utilizada: {0}. ", atacante.Arma.Nome);
                    dados.AppendFormat("Dano: {0}. ", dano);

                    d.Narracao += dados.ToString();
                    d.DataDisputa = DateTime.Now;
                    _context.TB_DISPUTAS.Add(d);
                    _context.SaveChanges();
                    
                return Ok(d);

            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}