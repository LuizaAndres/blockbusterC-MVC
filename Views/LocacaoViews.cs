using System;
using Models;
using System.Collections.Generic;
using Controllers;
namespace View {
    public class LocacaoView {
        public static void AddBasicLocacao() {
            Cliente cliente = Cliente.GetClientes()[1];
            List<Filme> locacaoFilmes = new List<Filme>();
            locacaoFilmes.Add(Repositories.RepositoryFilme.filmes[1]);
            locacaoFilmes.Add(Repositories.RepositoryFilme.filmes[6]);
            LocacaoController.AddLocacao(cliente, locacaoFilmes);
            cliente = Cliente.GetClientes()[1];
            locacaoFilmes = new List<Filme>();
            locacaoFilmes.Add(Repositories.RepositoryFilme.filmes[5]);
            LocacaoController.AddLocacao(cliente, locacaoFilmes);
            cliente = Cliente.GetClientes()[2];
            locacaoFilmes = new List<Filme>();
            locacaoFilmes.Add(Repositories.RepositoryFilme.filmes[0]);
            LocacaoController.AddLocacao(cliente, locacaoFilmes);
            cliente = Cliente.GetClientes()[3];
            locacaoFilmes = new List<Filme>();
            locacaoFilmes.Add(Repositories.RepositoryFilme.filmes[4]);
            LocacaoController.AddLocacao(cliente, locacaoFilmes);
        }
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
            foreach(Locacao l in Repositories.RepositoryLocacao.locacoes){
                Console.WriteLine("\n----------------------------");
                Console.WriteLine("Cliente:");
                Console.WriteLine($"Id cliente: {l.Cliente.ID+1} |Nome: {l.Cliente.Nome}");
                foreach(Filme f in l.Filmes){
                    Console.WriteLine($"Locacao: {l.ID+1}");
                    
                    Console.WriteLine($"Id: {f.IdFilme+1} |Filme: {f.NomeFilme} |Valor:R$ {f.Valor}");
                }
                double valor = LocacaoController.ValorLocacao(l);
                Console.WriteLine($"valor da locação R$: {valor}");
            }
        }
    }
}