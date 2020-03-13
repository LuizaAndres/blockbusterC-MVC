using System;
using Models;
using Controllers;

namespace View {
    public class LocacaoView {
        

        public static void GetLocacoes(){
            LocacaoController.AddLocacao(1, "Jackson");
            LocacaoController.AddLocacao(2, "João");
            LocacaoController.AddLocacao(1, "José");
            foreach (Locacao locacao in LocacaoController.Locacoes())
            {
                Console.WriteLine(locacao);   
            }
        }
    }
}