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
        Label lblTodasLocacoes;
        ListView lvLocacoes;
        Button btnVoltar;
        public TodasLocacoes(Form parent){
            this.parent = parent;
            this.Text = "Locacoes";
            this.BackColor = Color.Beige;
            this.Size = new Size(300,400);

            lblTodasLocacoes = new Label();
            lblTodasLocacoes.Location = new Point(110,10);
            lblTodasLocacoes.Text = "Locações";
            this.Controls.Add(lblTodasLocacoes);

            lvLocacoes = new ListView();
            lvLocacoes.Size = new Size(250,220);
            lvLocacoes.Location = new Point (20,50);
            lvLocacoes.View = Details;
            lvLocacoes.Columns.Add("Cliente", -2, HorizontalAlignment.Left);
            lvLocacoes.Columns.Add("Filme", -2, HorizontalAlignment.Left);
            lvLocacoes.Columns.Add("Valor", -2, HorizontalAlignment.Left);
            foreach(Locacao locacao in LocacaoController.GetLocacoes()){
                locacao.setCliente();
                locacao.setLocacaoFilme();
                ListViewItem lvItemLocacoes = new ListViewItem(locacao.Cliente.Nome.ToString());
                string filmesLocados = "";
                foreach (FilmeLocacao filmeLocacao in locacao.Filmes){
                filmeLocacao.setFilme();
                filmesLocados =$"{filmesLocados} | " + $"{filmeLocacao.Filme.NomeFilme}\n";
                }
                lvItemLocacoes.SubItems.Add(filmesLocados);
                lvItemLocacoes.SubItems.Add(LocacaoController.GetValorTotal(locacao).ToString());
                lvLocacoes.Items.Add(lvItemLocacoes);
            }
            lvLocacoes.FullRowSelect = true;
            this.Controls.Add(lvLocacoes);

            btnVoltar = new Button();
            btnVoltar.Size = new Size(80, 20);
            btnVoltar.Location = new Point(180, 300);
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