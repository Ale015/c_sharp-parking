using System;
using System.Collections.Generic;

//utilização de REGEX para validação da placa inserida.
using System.Text.RegularExpressions;

namespace DesafioFundamentos.Models
{
    // Criação da Classe Estacionamento
    public class Estacionamento
    {


        // Criação das variáveis precoInicial e precoPorHora, e da lista de veículos (Tipo List para comportar inserção de veículos sem dimensão pré-definida como em arrays).
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;

        private List<string> listaDeVeiculos = new List<string>();

        // Constructor para definir os dois atributos básicos do objeto instanciado
        public Estacionamento( decimal precoInicial, decimal precoPorHora){
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        
        public void AdicionarVeiculo(){

            bool loop_add = true;
            while (loop_add){
                Console.WriteLine("Por favor, insira a placa do veículo que deseja adicionar: ");
                Console.WriteLine("(Digite 'exit' ou 'sair'))");
                string plate = Convert.ToString(Console.ReadLine().Trim().ToUpper().Replace("-",""));

                if (plate == "EXIT" || plate == "SAIR" ){
                break;
                } else {
                    if ( validacaoPlaca(plate)){
                        listaDeVeiculos.Add(plate);
                        Console.WriteLine($"O veículo de placa {plate} foi adicionado com sucesso ao estacionamento.");
                        break;
                    } else {
                        Console.WriteLine($"O veículo não foi adicionado ao estacionamento. \n Tente novamente");
                        continue;
                    }
                }

            }
        }

        // Função privada à classe, com verificação se a placa informada é igual a placa Padrão
        private bool validacaoPlaca(string placa){
            string padraoPlaca = @"^[A-Z]{3}[0-9][0-9A-Z][0-9]{2}$";
            return Regex.IsMatch(placa.ToUpper(), padraoPlaca);
        }

        public void RemoverVeiculo(){
            string placaRemocao = "";
            bool loopRemove = true;

            if(listaDeVeiculos.Count <= 0){
                Console.WriteLine("Sinto muito, não existem carros estacionados para poder remover.");
            }else{ 
                while(loopRemove == true){

                System.Console.WriteLine("Digite a placa do veículo para remover: ");
                placaRemocao = Convert.ToString(Console.ReadLine());

                placaRemocao = placaRemocao.Trim().ToUpper().Replace("-","");
                
                    if (listaDeVeiculos.Contains(placaRemocao)){
                        System.Console.WriteLine("Digite a quantidade de Horas que o veículo permaneceu estacionado: ");
                        int tempoEstacionado = int.Parse(Console.ReadLine());

                        decimal valorTotal = this.precoInicial + this.precoPorHora * tempoEstacionado;
                        
                        Console.WriteLine($"O veículo {placaRemocao} ficou estacionado por {tempoEstacionado} e seu preço total foi de: R$ {valorTotal}.");
                        listaDeVeiculos.Remove(placaRemocao);

                        loopRemove = false;
                    } else {
                        Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                    }
                }
            }
            Console.WriteLine("Pressione uma tecla para continuar: ");
            Console.ReadKey();
        }

        public void ListarVeiculos(){
            if (listaDeVeiculos.Count > 0){ 
                Console.WriteLine("Os veículos estacionados são:");
                for (int i = 0; i < listaDeVeiculos.Count; i++){
                    Console.WriteLine($"{listaDeVeiculos[i]}");
                }
            } else {
                System.Console.WriteLine("Você ainda não inseriu nenhum veículo.");
            }
            Console.WriteLine("Pressione uma tecla para continuar: ");
            Console.ReadKey();
        }












    }


    // public class Estacionamento
    // {
    //     private decimal precoInicial = 0;
    //     private decimal precoPorHora = 0;
    //     private List<string> veiculos = new List<string>();

    //     public Estacionamento(decimal precoInicial, decimal precoPorHora)
    //     {
    //         this.precoInicial = precoInicial;
    //         this.precoPorHora = precoPorHora;
    //     }

    //     public void AdicionarVeiculo()
    //     {
    //         // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
    //         // *IMPLEMENTE AQUI*
    //         Console.WriteLine("Digite a placa do veículo para estacionar:");
    //     }

    //     public void RemoverVeiculo()
    //     {
    //         Console.WriteLine("Digite a placa do veículo para remover:");

    //         // Pedir para o usuário digitar a placa e armazenar na variável placa
    //         // *IMPLEMENTE AQUI*
    //         string placa = "";

    //         // Verifica se o veículo existe
    //         if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
    //         {
    //             Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

    //             // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
    //             // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
    //             // *IMPLEMENTE AQUI*
    //             int horas = 0;
    //             decimal valorTotal = 0; 

    //             // TODO: Remover a placa digitada da lista de veículos
    //             // *IMPLEMENTE AQUI*

    //             Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
    //         }
    //         else
    //         {
    //             Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
    //         }
    //     }

    //     public void ListarVeiculos()
    //     {
    //         // Verifica se há veículos no estacionamento
    //         if (veiculos.Any())
    //         {
    //             Console.WriteLine("Os veículos estacionados são:");
    //             // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
    //             // *IMPLEMENTE AQUI*
    //         }
    //         else
    //         {
    //             Console.WriteLine("Não há veículos estacionados.");
    //         }
    //     }
    // }
}
