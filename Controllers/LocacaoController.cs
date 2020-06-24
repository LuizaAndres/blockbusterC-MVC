using System;
using Models;
using System.Collections.Generic;

namespace Controllers {
    public class LocacaoController {
        public static void InserirFilme(
            Locacao locacao,
            Filme filme
        ){
            locacao.InserirFilme(filme);
        }
        public static List<Locacao> GetLocacoes (){
            return Locacao.GetLocacoes();
        }
        public static double GetValorTotal (Locacao locacao) {
            double valorTotal = 0;
            foreach (FilmeLocacao filme in locacao.Filmes){
                valorTotal += filme.Filme.Valor;
            }
            return valorTotal;
        }
        public static DateTime GetDataDevolucao (DateTime DtLocacao, Cliente Cliente) {
            return DtLocacao.AddDays (Cliente.Dias);
        }
    }
}