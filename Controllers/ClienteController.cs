using System;
using Models;
using System.Collections.Generic;

namespace Controllers {
    public class ClienteController { 
        public static void InserirCliente(
            string nome,
            string sDtNasc,
            string cpf,
            int qtdDias
            ) 
        {
            DateTime dtNasc;
            if(cpf.Length!=14)
            {
                throw new Exception ("CPF deve ter 11 digitos");
            }
            try {
                dtNasc = Convert.ToDateTime (sDtNasc);
            } catch {
               throw new Exception("Data inválida");
            }
            Cliente.InserirCliente (nome, dtNasc, cpf, qtdDias);
        }
        public static Cliente GetCliente (int idCliente){
            return Cliente.GetCliente(idCliente);
        }
        public static List<Cliente> GetClientes (){
            return Cliente.GetClientes();
        }
    }
}