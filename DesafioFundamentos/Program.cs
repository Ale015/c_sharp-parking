﻿using System.Reflection.Emit;
using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;




decimal precoInicial = 0;
decimal precoPorHora = 0;

bool loopPrecoInicial = true;
bool loopPrecoPorHora = true;

System.Console.WriteLine("Bem vindo ao Sistema de Gerenciamento de Estacionamentos C#");
while(loopPrecoInicial == true){
    System.Console.WriteLine("Por favor informe o Preço inicial: R$");
    try
    {
        precoInicial =  Convert.ToDecimal(Console.ReadLine());
        loopPrecoInicial = false;
    }
    catch 
    {
        Console.WriteLine("Por favor insira um valor válido");
        continue;
    }
};

while(loopPrecoPorHora == true){
    System.Console.WriteLine("Por favor informe o Preço por hora: R$");
    try
    {
        precoPorHora =  Convert.ToDecimal(Console.ReadLine());
        loopPrecoPorHora = false;
    }
    catch
    {
        Console.WriteLine("Por favor insira um valor válido");
        continue;
    }
};

// Instanciamento do objeto parking a partir da classe Estacionamento.
Estacionamento parking = new Estacionamento(precoInicial, precoPorHora);

// Booleano para manter loop ativo até que break seja ativado na 4° opção
bool loopInterface = true;
string opcaoDesejada = "";

while ( loopInterface == true){
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar veículo \n2 - Remover veículo \n3 - Listar veículos \n4 - Encerrar");

    opcaoDesejada = Convert.ToString(Console.ReadLine().Trim().ToLower());

    if(opcaoDesejada == "1" || opcaoDesejada == "cadastrar veiculo" || opcaoDesejada =="cadastrar ve├¡culo"){
        parking.AdicionarVeiculo();
    }
    else if (opcaoDesejada == "2" || opcaoDesejada == "remover veiculo" || opcaoDesejada == "remover ve├¡culo"){
        parking.RemoverVeiculo();
    }
    else if (opcaoDesejada == "3" || opcaoDesejada == "listar veiculos" || opcaoDesejada == "listar ve├¡culos"){
        parking.ListarVeiculos();
    }
    else if (opcaoDesejada == "4" || opcaoDesejada == "encerrar" || opcaoDesejada == "exit"){
        loopInterface = false;
    } else {
        Console.WriteLine("Por favor insira uma opção válida, você pode optar por escrever o número referente à opção ou escrever a instrução por completo.");
        continue;
    }

}

Console.WriteLine("Press any Key to finish:");
Console.ReadKey();

