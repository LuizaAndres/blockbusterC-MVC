using System;
using Models;
using System.Collections.Generic;
namespace Controllers {
    public class FilmeController {
        public static void InserirFilme(string nome, string sDtLancamento, string sinopse, double valor, int estoque)
        {
            DateTime dtLancamento;
            if(nome.Length==0){
                throw new Exception ("Digite um nome válido");
            }
            try {
                dtLancamento = Convert.ToDateTime (sDtLancamento);
            } catch {
                dtLancamento = DateTime.Now;
            }
            Filme.InserirFilme (nome, dtLancamento, sinopse, valor, estoque);
            if(valor <= 0){
                throw new Exception ("Digite um valor válido");
            }
            if (estoque <=0){
                throw new Exception ("Digite a quantidade em estoque");
            }
        }
        public static Filme GetFilme (int idFilme){
            return Filme.GetFilme(idFilme);
        }
        public static List<Filme> GetFilmes (){
            return Filme.GetFilmes();
        }
    }
}