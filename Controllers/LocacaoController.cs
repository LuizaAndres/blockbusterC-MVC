using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;
using Repositories;
namespace Controllers {
    public class LocacaoController : Controller {
        public static List<Locacao> GetLocacoes(){
            return RepositoryLocacao.Locacoes();
        }
        public static void AddLocacao(Cliente cliente, List<Filme> locacaoFilmes ) {
            Locacao locacao = new Locacao (cliente, locacaoFilmes);
            RepositoryLocacao.locacoes.Add(locacao);
            foreach (Filme filme in locacaoFilmes){
                filme.VezesLocado.Add(locacao);
            }
            var db = new Context();
            db.Locacoes.Add(locacao);
            db.SaveChanges();
        }
         public static double ValorLocacao(Locacao locacao){
            double valor = 0;
            foreach(Filme filme in locacao.Filmes){
                valor = valor + filme.Valor;
            }
            return valor;
        }
    }
}