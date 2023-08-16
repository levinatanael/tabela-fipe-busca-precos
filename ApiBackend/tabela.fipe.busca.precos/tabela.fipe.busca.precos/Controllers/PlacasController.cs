using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tabela.fipe.busca.precos.Data;
using tabela.fipe.busca.precos.Models;

namespace tabela.fipe.busca.precos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlacasController : Controller
    {
        private readonly TabelaFipeDbContext _tabelaFipeDbContext;

        public PlacasController(TabelaFipeDbContext tabelaFipeDbContext) {
            _tabelaFipeDbContext = tabelaFipeDbContext;
        }

        [HttpGet]        
        public async Task<IActionResult> ListarTodasPlacas()
        {
            var placas = await _tabelaFipeDbContext.Placas.ToListAsync();

            return Ok(placas);
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarPlaca([FromBody] Placa placaRequest)
        {
            placaRequest.Id = Guid.NewGuid();
            await _tabelaFipeDbContext.Placas.AddAsync(placaRequest);
            await _tabelaFipeDbContext.SaveChangesAsync();

            return Ok(placaRequest);
        }
    }
}
