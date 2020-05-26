using System;
using Models;

namespace Controllers {
    public class LocacaoController {
        

        public static void InserirFilme(
            Locacao locacao,
            Filme filme
        ){
            locacao.InserirFilme(filme);
        }

        public static double GetValorTotal (Locacao locacao) {
            double valorTotal = 0;
            
            foreach (FilmeLocacao filme in locacao.Filmes){
                valorTotal += filme.Filme.Valor;
            }
            return valorTotal;
        }
        public static string GetFilmesLocados (Locacao locacao){
            string todosFilmes = "";
            foreach (FilmeLocacao filme in locacao.Filmes){
                todosFilmes = todosFilmes +" "+ filme.Filme.NomeFilme;
            }
            return todosFilmes;
        }

        public static double GetQtdFilmes (Locacao locacao) {
            return locacao.Filmes.Count;
        }

        public static DateTime GetDataDevolucao (DateTime DtLocacao, Cliente Cliente) {
            return DtLocacao.AddDays (Cliente.Dias);
        }

        public static Locacao GetLocacao (int idLocacao){
            return Locacao.GetLocacao(idLocacao);
        }
    }
}