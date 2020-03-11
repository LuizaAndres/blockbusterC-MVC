using System;
using Models;
using Controllers;

namespace View {
    public class ClienteView {
    
        private static void inserirCliente () {
        int id = Controllers.ClienteController.returnCliente().Count+1;
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
            clientes.Count,
            nome,
            dtNasc,
            cpf,
            qtdDias
        );

        // Insert the costumer on "db"
        clientes.Add (cliente);
    }
        public static void GetClientes(){
            
            foreach (Cliente cliente in ClienteController.Clientes())
            {
                Console.WriteLine(cliente);   
            }
        }
    }
}