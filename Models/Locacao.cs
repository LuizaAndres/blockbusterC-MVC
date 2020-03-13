using System;
using System.Collections.Generic;


namespace Models {
    public class Locacao {
        

        // Criando atributos e seus getters e setters
        public DateTime Data = DateTime.Today;
        public int ID { get; set; }
        public Cliente Cliente { get; set; }
        public String DataLocacao { get; set; }
        public String DataDevolucao { get; set; }
        public float ValorTotal { get; set; }
        public List<Filme> Filmes = new List<Filme>();

        // Criando construtor
        public Locacao(int id, Cliente cliente){
            ID = id;
            Cliente = cliente;
            DataLocacao = Data.ToString().Substring(0,10);
        }
    }
}