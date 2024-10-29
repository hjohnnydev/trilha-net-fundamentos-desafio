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

        public async void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuÃ¡rio digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuÃ¡rio digitar a placa e armazenar na variÃ¡vel placa
            string placa = "";
            placa = Console.ReadLine();

            // Verifica se o veÃ­culo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Pedir para o usuÃ¡rio digitar a quantidade de horas que o veÃ­culo permaneceu estacionado,
                // Realizar o seguinte cÃ¡lculo: "precoInicial + precoPorHora * horas" para a variÃ¡vel valorTotal  
                int horas = 0;
                decimal valorTotal = 0; 

                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = precoInicial + precoPorHora * horas;

                // Remover a placa digitada da lista de veÃ­culos

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se hÃ¡ veÃ­culos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // Realizar um laÃ§o de repetiÃ§Ã£o, exibindo os veÃ­culos estacionados
                foreach(string item in veiculos){
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
