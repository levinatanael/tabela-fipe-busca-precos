namespace tabela.fipe.busca.precos.Models
{
    public class Placa
    {
        public Guid Id { get; set; }
        public string Codigo { get; set; }
        public string Valor { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoModelo { get; set; }
        public string Combustivel { get; set; }
        public string CodigoFipe { get; set; }
        public string MesReferencia { get; set; }
        public int TipoVeiculo { get; set; }
        public string SiglaCombustivel { get; set; }
        public string DataConsulta { get; set; }
    }
}
