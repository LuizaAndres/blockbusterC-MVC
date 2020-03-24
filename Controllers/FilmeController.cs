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
        public static void AddFilme(Filme filme){
            RepositoryFilme.AddFilme(filme);
        }
    }
}