using System.Reflection.Emit;
using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;




decimal precoInicial = 0;
decimal precoPorHora = 0;


System.Console.WriteLine("Bem vindo ao Sistema de Gerenciamento de Estacionamentos C#");
System.Console.WriteLine("Por favor informe o Preço inicial: R$");
precoInicial =  Convert.ToDecimal(Console.ReadLine());
System.Console.WriteLine("Por favor informe o Preço por hora: R$");
precoPorHora =  Convert.ToDecimal(Console.ReadLine());


// Instanciamento do objeto parking a partir da classe Estacionamento.
Estacionamento parking = new Estacionamento(precoInicial, precoPorHora);

// Booleano para manter loop ativo até que break seja ativado na 4° opção
bool loopInterface = true;
string opcaoDesejada = "";

while ( loopInterface == true){
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar veículo \n2 - Remover veículo \n3 - Listar veículos \n4- Encerrar");

    opcaoDesejada = Convert.ToString(Console.ReadLine().Trim().ToLower());

    if(opcaoDesejada == "1" || opcaoDesejada == "cadastrar veiculo" || opcaoDesejada =="cadastrar ve├¡culo"){
        parking.AdicionarVeiculo();
    }
    else if (opcaoDesejada == "2" || opcaoDesejada == "remover veiculo" || opcaoDesejada == "remover ve├¡culo"){
        break;
    }
    else if (opcaoDesejada == "3" || opcaoDesejada == "listar veiculos" || opcaoDesejada == "listar ve├¡culos"){

    }
    else if (opcaoDesejada == "4" || opcaoDesejada == "encerrar" || opcaoDesejada == "exit"){
        loopInterface = false;
    } else {
        Console.WriteLine("Por favor insira uma opção válida, você pode optar por escrever o número referente à opção ou escrever a instrução por completo.");
        continue;
    }

}


































// decimal precoInicial = 0;
// decimal precoPorHora = 0;

// Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
//                   "Digite o preço inicial:");
// precoInicial = Convert.ToDecimal(Console.ReadLine());

// Console.WriteLine("Agora digite o preço por hora:");
// precoPorHora = Convert.ToDecimal(Console.ReadLine());

// // Instancia a classe Estacionamento, já com os valores obtidos anteriormente
// Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

// string opcao = string.Empty;
// bool exibirMenu = true;

// // Realiza o loop do menu
// while (exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar veículo");
//     Console.WriteLine("2 - Remover veículo");
//     Console.WriteLine("3 - Listar veículos");
//     Console.WriteLine("4 - Encerrar");

//     switch (Console.ReadLine())
//     {
//         case "1":
//             es.AdicionarVeiculo();
//             break;

//         case "2":
//             es.RemoverVeiculo();
//             break;

//         case "3":
//             es.ListarVeiculos();
//             break;

//         case "4":
//             exibirMenu = false;
//             break;

//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }

//     Console.WriteLine("Pressione uma tecla para continuar");
//     Console.ReadLine();
// }

// Console.WriteLine("O programa se encerrou");
