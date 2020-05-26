using System;
using System.Drawing;
using System.Windows.Forms;
using Controllers;
using Models;
using static System.Windows.Forms.View;

namespace Views
{
    public class TodasLocacoes : Form {
        Form parent;
        ListView lvLocacoes;
        Button btnVoltar;
        Locacao locacao;
        
        public TodasLocacoes(Form parent){
            this.parent = parent;

            this.Text = "Locacoes";
            this.BackColor = Color.Beige;
            this.Size = new Size(300,400);

            lvLocacoes = new ListView();
            lvLocacoes.Size = new Size(200,220);
            lvLocacoes.Location = new Point (20,30);
            lvLocacoes.View = Details;

            foreach(Locacao locacao in LocacaoController.GetLocacoes()){

                ListViewItem lvLocacoes = new ListViewItem(locacao.Cliente.Nome);
                foreach (FilmeLocacao filmeLocacao in locacao.Filmes){
                lvLocacoes.SubItems.Add(filmeLocacao.Filme.NomeFilme);
                }
            }
            lvLocacoes.FullRowSelect = true;
            lvLocacoes.Columns.Add("Cliente", -2, HorizontalAlignment.Left);
            lvLocacoes.Columns.Add("filme", -2, HorizontalAlignment.Left);
            this.Controls.Add(lvLocacoes);

            btnVoltar = new Button();
            btnVoltar.Size = new Size(80, 20);
            btnVoltar.Location = new Point(120, 270);
            btnVoltar.Text = "Voltar";
            this.Controls.Add(btnVoltar);
            btnVoltar.Click += new EventHandler(btnVoltarClick);
        }
        
        private void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }
    }
}