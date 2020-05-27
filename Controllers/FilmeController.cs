using System;
using Models;
using System.Collections.Generic;
namespace Controllers {
    public class FilmeController {
        public static void InserirFilme(string nome, string sDtLancamento, string sinopse, double valor, int estoque)
        {
            DateTime dtLancamento;
            try {
                dtLancamento = Convert.ToDateTime (sDtLancamento);
            } catch {
                dtLancamento = DateTime.Now;
            }
            Filme.InserirFilme (nome, dtLancamento, sinopse, valor, estoque);
        }
        public static Filme GetFilme (int idFilme){
            return Filme.GetFilme(idFilme);
        }
        public static List<Filme> GetFilmes (){
            return Filme.GetFilmes();
        }
    }
}