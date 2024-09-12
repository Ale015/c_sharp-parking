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
                        Console.WriteLine($"O veículo de placa {plate} foi adicionado com sucesso ao estacionamento.\n");
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
                Console.WriteLine("Sinto muito, não existem carros estacionados para poder remover.\n");
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
}
