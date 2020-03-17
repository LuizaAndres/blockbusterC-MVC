using System;
using Models;
using Controllers;

namespace View {
    public class FilmeView {
        public static void GetFilme(){
            Console.WriteLine("ID - Filme - Valor"); 
            foreach (Filme filme in FilmeController.Filmes())
            {
                Console.WriteLine(filme);   
            }
        }
        public static void AddBasicFilme () {
            Filme filme = new Filme (
                Filme.GetFilmes().Count,
                "La La Land - Cantando Estações",
                new DateTime (2016, 1, 1),
                "Em Los Angeles, a aspirante a atriz Mia (Emma Stone) e o pianista de jazz Sebastian (Ryan Gosling) se apaixonam e juntos passam a perseguir seus sonhos e vontades. Conforme buscam o que desejam, os dois tentam fazer seu relacionamento dar certo. Vencedor de 6 Oscars.",
                Convert.ToDouble ("15,5"),
                1
            );
            FilmeController.AddFilme(filme);    
            filme = new Filme (
                Filme.GetFilmes().Count,
                "Titanic",
                new DateTime (1997, 1, 1),
                "A bordo do luxuoso transatlântico, Rose, uma jovem da alta sociedade, se sente pressionada com a vida que leva. Ao conhecer Jack, um artista pobre e aventureiro, os dois se apaixonam. Mas eles terão que enfrentar um desafio ainda maior que o preconceito social com o destino trágico do navio.",
                10,
                2
            );
            FilmeController.AddFilme(filme);
            filme = new Filme (
                Filme.GetFilmes().Count,
                "Pulp Fiction - Tempo De Violência",
                new DateTime (1994, 1, 1),
                "Os assassinos Vincent e Jules passam por imprevistos ao recuperar uma mala para um mafioso. O boxeador Butch é pago pelo mesmo mafioso para perder uma luta, e a esposa do criminoso fica sob responsabilidade de Vincent por uma noite. Essas histórias se relacionam numa teia repleta de violência.",
                15,
                3
            );
            FilmeController.AddFilme(filme);
            filme = new Filme (
                Filme.GetFilmes().Count,
                "Rocky - Um Lutador",
                new DateTime (1976, 1, 1),
                "Rocky (Sylvester Stallone) é um lutador de boxe desconhecido que é desafiado pelo campeão dos pesos pesados, Apollo Creed (Carl Weathers). Rocky vê a luta como uma oportunidade e começa a treinar intensivamente para ser o vencedor. Vencedor do Oscar de Melhor Filme, Melhor Diretor e Melhor Edição.",
                25,
                4
            );
            FilmeController.AddFilme(filme);
            filme = new Filme (
                Filme.GetFilmes().Count,
                "Vingadores: Guerra Infinita",
                new DateTime (2018, 1, 1),
                "O cruel Thanos pretende reunir todas as Jóias do Infinito em sua manopla para tornar-se o mais poderoso da galáxia e ser capaz de decidir o futuro da humanidade. Os Vingadores então se unem aos Guardiões da Galáxia e ao Pantera Negra na maior guerra de todos os tempos para impedir os planos do vilão.",
                30,
                5
            );
            FilmeController.AddFilme(filme);
            filme = new Filme (
                Filme.GetFilmes().Count,
                "Bohemian Rhapsody",
                new DateTime (2018, 1, 1),
                "Juntos, Freddie Mercury (Rami Malek), Brian May (Gwilym Lee), Roger Taylor (Ben Hardy) e John Deacon (Joe Mazzello) começam a banda Queen, que revoluciona o cenário da música nos anos 70. Mercury é um cantor talentoso e de personalidade singular, mas os excessos começam a representar um problema para o futuro da banda. Baseado em fatos reais, o filme foi vencedor de quatro Oscars.",
                Convert.ToDouble ("25,6"),
                6
            );
            FilmeController.AddFilme(filme);
            filme = new Filme (
                Filme.GetFilmes().Count,
                "Azul É A Cor Mais Quente",
                new DateTime (2013, 1, 1),
                "A estudante Adèle (Adèle Exarchopoulos) vive em uma fase de autoconhecimento. Quando conhece Emma (Léa Seydoux), uma garota lésbica, ela se sente atraída e as duas começam a passar muito tempo juntas. Com isso, as colegas de Adèle a pressionam sobre sua sexualidade ao passo que o laço com Emma fica cada vez mais forte. Vencedor de 3 Palmas de Ouro no Festival de Cannes.",
                10,
                7
            );
            FilmeController.AddFilme(filme);
        }  
    }
}