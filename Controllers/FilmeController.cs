using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers {
    public class FilmeController : Controller {
        public static List<Filme> Filmes(){
            return Filme.Filmes();
        }

        public static void AddFilme(int id, string nome){
            new Filme(id, nome);
        }
    }
}