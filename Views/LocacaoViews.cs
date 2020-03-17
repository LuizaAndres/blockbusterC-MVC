using System;
using Models;
using System.Collections.Generic;
using Controllers;

namespace View {
    public class LocacaoView {

        public static void AddLocacoes(){
           
        }
         public static void GetLocacoes(){
            foreach (Locacao locacao in LocacaoController.GetLocacoes())
            {
                Console.WriteLine(locacao);   
            }
        }
        public static void AddBasicLocacao() {

            int idLocacao = Locacao.GetLocacoes().Count;
            Cliente cliente = Cliente.GetClientes()[1];
            string dtLocacao = DateTime.Now.ToString();
            List<Filme> locacaoFilmes = new List<Filme>();
            locacaoFilmes.Add(Repositories.RepositoryFilme.filmes[1]);
            
            
        LocacaoController.AddLocacao(cliente, locacaoFilmes);

        }
        
    }
}