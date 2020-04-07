using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;
using Repositories;
namespace Controllers {
    public class FilmeController : Controller {
        public static List<Filme> Filmes(){
            return Filme.GetFilmes();
        }
        public static void AddFilme(string nomeFilme, DateTime dtLancamento,string sinopse,double valor,int qtdEstoque){
           Filme filme = new Filme (
            Filme.GetFilmes().Count+1,
            nomeFilme,
            dtLancamento,
            sinopse,
            valor,
            qtdEstoque
            );
            var db = new Context();
            db.Filmes.Add(filme);
            db.SaveChanges();
        }
    }
}