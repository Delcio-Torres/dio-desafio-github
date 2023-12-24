using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 5;
decimal precoPorHora = 2;

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n Tabela de Preços: \n Preço inicial: R$ 5,00 - Preço/Hora: R$ 2,00 ");
    Console.WriteLine();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Entrada de veículo");
    Console.WriteLine("2 - Saída de veículo");
    Console.WriteLine("3 - Veículos no pátio");
    Console.WriteLine("4 - Encerrar");

    try
    {
        switch (Console.ReadLine())
        {
            case "1":
                es.AdicionarVeiculo();
                break;

            case "2":
                es.RemoverVeiculo();
                break;

            case "3":
                es.ListarVeiculos();
                break;

            case "4":
                exibirMenu = false;
                break;

            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }
    catch{
        Console.WriteLine("Opção inválida");
        Console.ReadLine();
    }
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
