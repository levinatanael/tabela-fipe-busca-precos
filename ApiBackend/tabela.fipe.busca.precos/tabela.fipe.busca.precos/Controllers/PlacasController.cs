using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tabela.fipe.busca.precos.Data;
using tabela.fipe.busca.precos.Models;
using tabela.fipe.busca.precos.Services;

namespace tabela.fipe.busca.precos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlacasController : Controller
    {
        private readonly TabelaFipeDbContext _tabelaFipeDbContext;
        private readonly IFipeService _fipeService;

        public PlacasController(TabelaFipeDbContext tabelaFipeDbContext, IFipeService fipeService)
        {
            _tabelaFipeDbContext = tabelaFipeDbContext;
            _fipeService = fipeService;
        }

        [HttpGet]
        public async Task<IActionResult> ListarTodasPlacas()
        {
            var placas = await _tabelaFipeDbContext.Placas.ToListAsync();

            return Ok(placas);
        }

        [HttpGet("consultar/{codigo}/{ano}")]
        public IActionResult ConsultarPlaca(string codigo, int ano)
        {
            var placa = _fipeService.ConsultaPreco(codigo, ano);

            return Ok(placa);
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
