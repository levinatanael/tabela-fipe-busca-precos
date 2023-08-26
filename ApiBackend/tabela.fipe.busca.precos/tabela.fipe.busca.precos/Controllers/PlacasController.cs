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
            try
            {
                var placas = await _tabelaFipeDbContext.Placas.ToListAsync();

                return Ok(placas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("consultar/{codigo}/{ano}")]
        public IActionResult ConsultarPreco(string codigo, int ano)
        {
            try
            {
                var placa = _fipeService.ConsultaPreco(codigo, ano);

                return Ok(placa);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("consultarplaca/{placa}")]
        public async Task<IActionResult> ConsultarPlaca(string placa)
        {
            try
            {
                var placas = await _tabelaFipeDbContext.Placas
                    .Where(p => p.Codigo.Equals(placa)).ToListAsync();

                Placa? placaEncontrada = null;
                if (placas.Any())
                {
                    placaEncontrada = placas.FirstOrDefault();
                }

                return Ok(placaEncontrada);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarPlaca([FromBody] Placa placaRequest)
        {
            try
            {
                placaRequest.Id = Guid.NewGuid();
                placaRequest.Codigo = placaRequest.Codigo.ToUpper();
                await _tabelaFipeDbContext.Placas.AddAsync(placaRequest);
                await _tabelaFipeDbContext.SaveChangesAsync();

                return Ok(placaRequest);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
