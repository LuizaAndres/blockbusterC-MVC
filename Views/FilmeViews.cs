using System;
using Models;
using Controllers;

namespace Views {
    public class FilmeView {

        public static void InserirFilme () {
            Console.WriteLine ("Informações sobre o filme: ");
            Console.WriteLine ("Informe o nome: ");
            String nome = Console.ReadLine ();
            Console.WriteLine ("Informe a data de lançamento (dd/mm/yyyy): ");
            String sDtLancamento = Console.ReadLine ();
            Console.WriteLine ("Informe a Sinopse: ");
            String cpf = Console.ReadLine ();
            Console.WriteLine ("Informe o valor para locação: ");
            double valor = Convert.ToDouble (Console.ReadLine ());
            Console.WriteLine ("Informe a quantidade em estoque: ");
            int estoque = Convert.ToInt32 (Console.ReadLine ());
            
            FilmeController.InserirFilme (nome, sDtLancamento, cpf, valor, estoque);
        }

        public static void ListarFilmes () {
            Console.WriteLine ("Lista de Filmes: ");
            FilmeController.GetFilmes().ForEach (filme => Console.WriteLine (filme.ToString (true)));
        }
        public static void ConsultarFilme () {
            Filme filme;

            do {
                Console.WriteLine ("Informe o filme que deseja consultar: ");
                int idFilme = Convert.ToInt32 (Console.ReadLine ());
                filme = null;
                try {
                    filme = FilmeController.GetFilme(idFilme);
                    if (filme == null) { 
                        Console.WriteLine ("Filme não localizado, favor digitar outro id.");
                    }
                } catch {
                    Console.WriteLine ("Filme não localizado, favor digitar outro id.");
                }
            } while (filme == null);
            Console.WriteLine (filme.ToString ());
        }
    }
}