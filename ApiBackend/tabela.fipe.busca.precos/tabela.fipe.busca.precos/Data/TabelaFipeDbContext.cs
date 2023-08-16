using Microsoft.EntityFrameworkCore;
using tabela.fipe.busca.precos.Models;

namespace tabela.fipe.busca.precos.Data
{
    /// <summary>
    /// Contexto do Banco de Dados
    /// </summary>
    public class TabelaFipeDbContext : DbContext
    {
        public TabelaFipeDbContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>
        /// Tabela de Placas
        /// </summary>
        public DbSet<Placa> Placas { get; set; }
    }
}
