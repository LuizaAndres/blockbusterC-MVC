using System;
using Models;
using System.Collections.Generic;
using Controllers;
namespace View {
    public class LocacaoView {
        
        public static void AddLocacaoView(){
            Console.WriteLine("Criando Locação:");
            Console.WriteLine("Digite id do cliente");
            int idC = Convert.ToInt32 (Console.ReadLine ());
            int op;
            Cliente cliente = Cliente.GetClientes()[idC-1];
            List<Filme> locacaoFilmes = new List<Filme>();
            do{
            Console.WriteLine("Digite id do filme");
            int idF = Convert.ToInt32 (Console.ReadLine ());
            locacaoFilmes.Add(Repositories.RepositoryFilme.filmes[idF-1]);
            Console.WriteLine("Deseja adicionar outro filme?");
            Console.WriteLine("0 - não");
            Console.WriteLine("1 - sim");
            op = Convert.ToInt32 (Console.ReadLine ());
            }while (op==1);
            LocacaoController.AddLocacao(cliente, locacaoFilmes);
        }
        public static void listarLocacoes(){
            foreach(Locacao locacao in Repositories.RepositoryLocacao.locacoes){
                Console.WriteLine("\n----------------------------");
                Console.WriteLine("Cliente:");
                Console.WriteLine($"Id cliente: {locacao.Cliente.ClienteId+1} |Nome: {locacao.Cliente.Nome}");
                foreach(Filme filme in locacao.Filmes){
                    Console.WriteLine($"Locacao: {locacao.LocacaoId+1}");
                    
                    Console.WriteLine($"Id: {filme.FilmeId+1} |Filme: {filme.NomeFilme} |Valor:R$ {filme.Valor}");
                }
                double valor = LocacaoController.ValorLocacao(locacao);
                Console.WriteLine($"valor da locação R$: {valor}");
            }
        }
    }
}