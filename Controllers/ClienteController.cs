using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;
using Repositories;
using System;

namespace Controllers {
    public class ClienteController : Controller {
        public static List<Cliente> Clientes(){
            return Cliente.GetClientes();
        }
        public static void AddCliente(Cliente cliente){
            RepositoryCliente.clientes.Add(cliente);
        }
        
    }
}