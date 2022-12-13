namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        string placa = "";

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
        private void zeraPlaca(){
            placa = "";
        }

        public void AdicionarVeiculo()
        {
            bool cadastrado;
            
            cadastrado = false;

            zeraPlaca();
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placa = Console.ReadLine().ToUpper() ;

            if (! placa.Equals(""))
            { 
             
                foreach (string veiculo in veiculos)
                {
                    if (veiculo.ToUpper()  == placa.ToUpper())
                    {
                        cadastrado = true;
                        break; 
                    }
                }

                if (! cadastrado )
                {                
                    veiculos.Add(placa);
                }
                else
                {            
                    Console.WriteLine("Placa do veículo já cadastrada.");
                }
            }
            else
            {
                Console.WriteLine("Placa do veículo inválida.");
            }
            
        }

        public void RemoverVeiculo()
        {
            zeraPlaca();
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            placa = Console.ReadLine().ToUpper() ;

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                int horas = 0;
                decimal valorTotal = 0; 

                // Calculado valor a ser pago pelo proprietário do veículo.
                valorTotal = precoInicial + (precoPorHora * horas);

                // Remover a placa digitada da lista de veículos.
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
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
   
        }
        public void digitaTexto(string frase, int cor)        
        {

            switch (cor)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            
            //Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(frase);
            Console.ResetColor();
        }   
    }
   
}
