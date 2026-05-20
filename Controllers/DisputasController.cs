using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
                return Ok(d);

            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}