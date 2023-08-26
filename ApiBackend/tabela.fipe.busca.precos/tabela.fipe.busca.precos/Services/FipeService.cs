using Newtonsoft.Json;
using RestSharp;
using tabela.fipe.busca.precos.Models;

namespace tabela.fipe.busca.precos.Services
{
    public class FipeService: IFipeService
    {
        private readonly string _apiFipe;
        public FipeService(IConfiguration configuration) => _apiFipe = configuration["EndPointApiFipe:Precos"];

        public Placa? ConsultaPreco(string codigo, int ano)
        {
            var listaPlacas = new List<Placa>();

            var client = new RestClient(string.Concat(_apiFipe, codigo));
            var request = new RestRequest();
            var response = client.Execute(request);

            var content = response.Content;
            dynamic json = JsonConvert.DeserializeObject(content);

            listaPlacas = json.ToObject<List<Placa>>();

            return ConstultaPorAno(listaPlacas, ano);
        }

        private static Placa? ConstultaPorAno(List<Placa> listaPlacas, int ano)
        {
            Placa? placa = null;
            if (listaPlacas.Any())
            {
                placa = listaPlacas.FirstOrDefault(p => p.AnoModelo.Equals(ano));
            }
            return placa;
        }
    }
}
