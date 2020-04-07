using System;
using Models;
using Controllers;

namespace View {
    public class LocacaoView {

        public static void InserirLocacao () {
            Console.WriteLine ("Informações sobre a locação: ");
            Cliente cliente;
            Filme filme;

            do {
                Console.WriteLine ("Informe o id do cliente: ");
                int ClienteId = Convert.ToInt32 (Console.ReadLine ());
                cliente = null;
                try {
                    cliente = ClienteController.GetCliente(ClienteId);
                    if (cliente == null) {
                        Console.WriteLine ("Cliente não localizado, favor digitar outro id.");
                    }
                } catch {
                    Console.WriteLine ("Cliente não localizado, favor digitar outro id.");
                }

            } while (cliente == null);

            Locacao locacao = LocacaoController.InserirLocacao(cliente);

            int filmOpt = 0;
            do {
                Console.WriteLine ("Informe o id do filme alugado: ");
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

                if (filme != null) {
                    LocacaoController.InserirFilme (locacao, filme);
                    Console.WriteLine ("Deseja informar outro filme? " +
                        "Informar 1 para Não ou qualquer outro valor para Sim.");
                    filmOpt = Convert.ToInt32 (Console.ReadLine ());
                }
            } while (filmOpt != 1);
        }

        public static void ConsultarLocacao () {
            Locacao locacao;

            do {
                Console.WriteLine ("Informe a locacao que deseja consultar: ");
                int idLocacao = Convert.ToInt32 (Console.ReadLine ());
                locacao = null;
                try {
                    locacao = LocacaoController.GetLocacao(idLocacao);
                    if (locacao == null) { 
                        Console.WriteLine ("Locação não localizada, favor digitar outro id.");
                    }
                } catch {
                    Console.WriteLine ("Locação não localizada, favor digitar outro id.");
                }
            } while (locacao == null);
            Console.WriteLine (locacao.ToString ());
        }
    }
}