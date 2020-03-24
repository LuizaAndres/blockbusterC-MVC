using System;
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
            RepositoryLocacao.locacoes.Add(new Locacao(cliente, locacaoFilmes));
        }
        
    }
}