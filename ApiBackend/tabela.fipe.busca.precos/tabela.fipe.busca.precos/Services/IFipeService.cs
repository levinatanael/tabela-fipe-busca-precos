using tabela.fipe.busca.precos.Models;

namespace tabela.fipe.busca.precos.Services
{
    public interface IFipeService
    {
        public Placa? ConsultaPreco(string codigo, int ano);
    }
}
