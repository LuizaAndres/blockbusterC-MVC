using System;
using Models;
using Controllers;

namespace View {
    public class ClienteView {
        public static void AddBasicCliente () {

        Cliente cliente = new Cliente (
            Cliente.GetClientes().Count,
            "Amanda Carolina Giovana Araújo",
            new DateTime (1999, 08, 19),
            "628.602.153-10",
            5
        );
        ClienteController.AddCliente(cliente);

        cliente = new Cliente (
                Cliente.GetClientes().Count,
                "Gabriel João Caio dos Santos",
                new DateTime (1953, 12, 17),
                "800.404.403-46",
                10
            );
        ClienteController.AddCliente(cliente);
        }
     
        public static void AddCliente () {
        int id = Controllers.ClienteController.Clientes().Count+1;
        Console.WriteLine ("Informações sobre o cliente: ");
        Console.WriteLine ("Informe o nome: ");
        String nome = Console.ReadLine ();
        Console.WriteLine ("Informe a data de nascimento (dd/mm/yyyy): ");
        String sDtNasc = Console.ReadLine ();
        DateTime dtNasc;
        try {
            dtNasc = Convert.ToDateTime (sDtNasc);
        } catch {
            Console.WriteLine ("Formato inválido de data, será utilizada a data atual pra cadastro");
            dtNasc = DateTime.Now;
        }
        Console.WriteLine ("Informe o C.P.F.: ");
        String cpf = Console.ReadLine ();
        Console.WriteLine ("Informe a quantidade de dias para devolução: ");
        int qtdDias = Convert.ToInt32 (Console.ReadLine ());

        Cliente cliente = new Cliente (
            Cliente.GetClientes().Count,
            nome,
            dtNasc,
            cpf,
            qtdDias
        );
        // colocando cliente no control
        ClienteController.AddCliente(cliente);
    }
        public static void GetClientes(){
            
            foreach (Cliente cliente in ClienteController.Clientes())
            {
                Console.WriteLine(cliente);   
            }
        }
    }
}