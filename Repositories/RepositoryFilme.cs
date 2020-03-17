using System;
using System.Collections.Generic;
using Models;

namespace Repositories {
    public static class RepositoryFilme {
        public static readonly List<Models.Filme> filmes = new List<Models.Filme>();

        public static List<Filme> Filmes(){
            return filmes;
        }
        public static void AddFilme(Filme filme){
            filmes.Add(filme);
        }
    }
}