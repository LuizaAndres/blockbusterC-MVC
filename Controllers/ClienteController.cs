using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers {
    public class ClienteController : Controller {
        public static List<Cliente> Clientes(){
            return Cliente.Clientes();
        }

        public static void AddCliente(int id, string nome, string cpf, string qtdDias){
            new Cliente(id, nome, cpf, qtdDias);
        }
    }
}