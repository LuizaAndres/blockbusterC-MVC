using System;
using Models;
using Controllers;

namespace View {
    public class ClienteView {
    
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