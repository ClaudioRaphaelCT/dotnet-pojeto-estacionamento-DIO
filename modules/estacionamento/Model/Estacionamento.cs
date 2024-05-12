using Utils;

namespace Model
{
    public class Estacionamento
    {
        private decimal PrecoInicial { get; set; }
        private decimal PrecoPorHora { get; set; }
        private List<string> Veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            PrecoInicial = precoInicial;
            PrecoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            string veiculo = Input.InputString("Digite a placa do veículo para estacionar");
            if (veiculo != null && veiculo.Length == 6)
            {
                Veiculos.Add(veiculo);
            }
            else
            {
                Console.WriteLine($"O valor: {veiculo} é nulo ou menor 6 digitos");
            }

        }
        public void RemoverVeiculo()
        {
            string veiculoRemover = Input.InputString("Digite a placa do veículo para Remover");
            if (Veiculos.Contains(veiculoRemover))
            {
                int horas = Input.InputInt("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                decimal valorTotal = (PrecoInicial + PrecoPorHora) * horas;
                Veiculos.Remove(veiculoRemover);
                Console.WriteLine($"Veículo removido com sucesso. Valor total a ser pago: {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (Veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string veiculo in Veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

    }
}