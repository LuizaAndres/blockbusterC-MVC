using System;
using Models;
using Controllers;

namespace Views {
    public class ClienteView {
        public static void InserirCliente () {
            Console.WriteLine ("Informações sobre o cliente: ");
            Console.WriteLine ("Informe o nome: ");
            String nome = Console.ReadLine ();
            Console.WriteLine ("Informe a data de nascimento (dd/mm/yyyy): ");
            String sDtNasc = Console.ReadLine ();
            Console.WriteLine ("Informe o C.P.F.: ");
            String cpf = Console.ReadLine ();
            Console.WriteLine ("Informe a quantidade de dias para devolução: ");
            int qtdDias = Convert.ToInt32 (Console.ReadLine ());

            ClienteController.InserirCliente(nome, sDtNasc, cpf, qtdDias);
        }

        public static void ListarClientes () {
            Console.WriteLine ("Lista de Clientes: ");
            ClienteController.GetClientes().ForEach (
                cliente => Console.WriteLine (cliente.ToString (true)));
        }

        public static void ConsultarCliente () {
            Cliente cliente;

            do {
                Console.WriteLine ("Informe o cliente que deseja consultar: ");
                int idCliente = Convert.ToInt32 (Console.ReadLine ());
                cliente = null;
                try {
                    cliente = ClienteController.GetCliente(idCliente);
                    if (cliente == null) {
                        Console.WriteLine ("Cliente não localizado, favor digitar outro id.");
                    }
                } catch {
                    Console.WriteLine ("Cliente não localizado, favor digitar outro id.");
                }
            } while (cliente == null);
            Console.WriteLine (cliente.ToString ());
        }
    }
}