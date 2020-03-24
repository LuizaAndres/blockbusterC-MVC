using System;
using System.Collections.Generic;
using Models;

namespace Repositories {
    public static class RepositoryLocacao {
        public static List<Models.Locacao> locacoes = new List<Models.Locacao>();
        public static List<Locacao> Locacoes(){
            return locacoes;
        }
    }
}