using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;
using Repositories;
namespace Controllers {
    public class ClienteController : Controller {
        public static List<Cliente> Clientes(){
            return Cliente.GetClientes();
        }
        public static void AddCliente(string nome, DateTime dtNasc, string cpf, int qtdDias ){
            Cliente cliente = new Cliente (
            Cliente.GetClientes().Count+1,
            nome,
            dtNasc,
            cpf,
            qtdDias);
            RepositoryCliente.clientes.Add(cliente);
            var db = new Context();
            db.Clientes.Add(cliente);
            db.SaveChanges();
        }
    }
}