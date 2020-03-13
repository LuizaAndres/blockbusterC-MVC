using System;
using System.Collections.Generic;
using Models;

namespace Repositories {
    public static class RepositoryLocacao {
        private static readonly List<Models.Locacao> locacoes = new List<Models.Locacao>();

        public static List<Locacao> Locacoes(){
            return locacoes;
        }

        public static void AddLocacao(Locacao locacao){
            locacoes.Add(locacao);
        }
    }
}