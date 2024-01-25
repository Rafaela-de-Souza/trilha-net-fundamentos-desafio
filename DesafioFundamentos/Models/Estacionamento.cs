namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            Console.WriteLine("Digite o nome do cliente:");
            string nomeCliente = Console.ReadLine();

            string veiculo = $"{placa} - {nomeCliente}";
            veiculos.Add(veiculo);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            string veiculo = veiculos.FirstOrDefault(x => x.ToUpper().Contains(placa.ToUpper()));

            if (veiculo != null)
            {
                Console.WriteLine($"O veículo {veiculo} foi removido.");
                CalcularValorEstacionamento();
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        private void CalcularValorEstacionamento()
        {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            int horas = int.Parse(Console.ReadLine());

            decimal valorTotal = precoInicial + precoPorHora * horas;
            Console.WriteLine($"O preço total a ser pago é de: R$ {valorTotal}");
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                Console.WriteLine(string.Join(Environment.NewLine, veiculos));
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
