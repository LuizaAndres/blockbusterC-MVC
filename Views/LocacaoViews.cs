using System;
using Models;
using System.Collections.Generic;
using Controllers;
namespace View {
    public class LocacaoView {
        // public static void AddLocacoes(){
        // }
        //  public static void GetLocacoes(){
        //     foreach (Locacao locacao in LocacaoController.GetLocacoes())
        //     {
        //         Console.WriteLine(locacao);   
        //     }
        // }
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
        public static void listarLocacoes(){
            foreach(Locacao l in Repositories.RepositoryLocacao.locacoes){
                Console.WriteLine("\n----------------------------");
                Console.WriteLine("Cliente:");
                Console.WriteLine(l.Cliente.Nome);
                foreach(Filme f in l.Filmes){
                    Console.WriteLine($"Locacao: {l.ID+1}");
                    
                    Console.WriteLine(f.NomeFilme);
                }
                double valor = l.ValorLocacao();
                Console.WriteLine($"valor da locação R$: {valor}");
            //    foreach(Cliente c in Repositories.RepositoryCliente.clientes){
            //     Console.WriteLine(c.Nome);
            //     foreach(Locacao loc in c.locacoes){
            //         Console.WriteLine(loc.DataLocacao);
            //         foreach(Filme fi in loc.Filmes){
            //             Console.WriteLine(fi.NomeFilme);
            //         }
            //     }
            //}
        }
    }
}
}