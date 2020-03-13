using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Repositories;

namespace Models {
    public class Filme {
        public int ID { get; set; }
        public string Nome { get; set; }

        public Filme (int id, string nome){
            ID = id;
            Nome = nome;
            RepositoryFilme.AddFilme(this);
        }
        public static List<Filme> Filmes () {
            return RepositoryFilme.Filmes();
        }

        public override string ToString(){
            return $"{ID} - {Nome}";
        }
    }
}