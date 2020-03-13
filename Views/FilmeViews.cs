using System;
using Models;
using Controllers;

namespace View {
    public class FilmeView {
        

        public static void GetFilme(){
            FilmeController.AddFilme(1, "Filme");
            FilmeController.AddFilme(2, "filme2");
            FilmeController.AddFilme(1, "José");
            foreach (Filme filme in FilmeController.Filmes())
            {
                Console.WriteLine(filme);   
            }
        }
    }
}