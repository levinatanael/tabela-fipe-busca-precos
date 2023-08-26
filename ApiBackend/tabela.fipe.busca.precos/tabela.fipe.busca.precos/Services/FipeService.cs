using Newtonsoft.Json;
using RestSharp;
using tabela.fipe.busca.precos.Models;

namespace tabela.fipe.busca.precos.Services
{
    public class FipeService : IFipeService
    {
        private readonly string _apiFipe;
        public FipeService(IConfiguration configuration) => _apiFipe = configuration["EndPointApiFipe:Precos"];

        public Placa? ConsultaPreco(string codigo, int ano)
        {
            Placa? placa = null;

            var client = new RestClient(string.Concat(_apiFipe, codigo));
            var request = new RestRequest();
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = response.Content;
                dynamic json = JsonConvert.DeserializeObject(content);

                var listaPlacas = json.ToObject<List<Placa>>();

                placa = ConstultaPorAno(listaPlacas, codigo, ano);
            }
            return placa;
        }

        private static Placa? ConstultaPorAno(List<Placa> listaPlacas, string codigo, int ano)
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
