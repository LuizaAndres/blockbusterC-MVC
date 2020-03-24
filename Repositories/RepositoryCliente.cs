using System;
using System.Collections.Generic;
using Models;

namespace Repositories {
    public static class RepositoryCliente {
        public static List<Models.Cliente> clientes = new List<Models.Cliente>();
        public static List<Cliente> Clientes(){
            return clientes;
        }
    }
}