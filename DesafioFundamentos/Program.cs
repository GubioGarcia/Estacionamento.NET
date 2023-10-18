using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!");

// Valida entrada de 'precoInicial' como um decimal válido
bool precoInicialValido = false;
while (!precoInicialValido) {
    Console.Write("Digite o preço inicial: ");

    if (decimal.TryParse(Console.ReadLine(), out precoInicial)) {
        precoInicialValido = true;
    } else {
        Console.Clear();
        Console.WriteLine("Valor inválido. Digite um número decimal válido.");
    }
}

// Valida entrada de 'precoPorHora' como um decimal válido
bool precoPorHoraValido = false;
while (!precoPorHoraValido) {
    Console.Clear();
    Console.Write("Agora, digite o preço por hora: ");

    if (decimal.TryParse(Console.ReadLine(), out precoPorHora)) {
        precoPorHoraValido = true;
    } else {
        Console.Clear();
        Console.WriteLine("Valor inválido. Digite um número decimal válido.");
    }
}

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento estacionamento = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu) {
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine()) {
        case "1":
            estacionamento.AdicionarVeiculo();
            break;

        case "2":
            estacionamento.RemoverVeiculo();
            break;

        case "3":
            estacionamento.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("\nPressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
