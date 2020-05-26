using System;
using System.Drawing;
using System.Windows.Forms;
using Controllers;
using Models;
using static System.Windows.Forms.View;

namespace Views
{
    public class ListaFilmes : Form {
        Form parent;
        ListView lvFilmes;
        Button btnConfirma;
        Button btnCancela;
        public ListaFilmes(Form parent){
            this.parent = parent;
            this.Text = "Lista Filmes";
            this.BackColor = Color.Beige;
            this.Size = new Size(300,400);

            lvFilmes = new ListView();
            lvFilmes.Size = new Size(200,220);
            lvFilmes.Location = new Point (20,30);
            lvFilmes.View = Details;
            ListViewItem Filmes = new ListViewItem();
            foreach(Filme filme in FilmeController.GetFilmes()){
                ListViewItem lvFilme = new ListViewItem(filme.NomeFilme);
                lvFilme.SubItems.Add(filme.Valor.ToString());
            } 
            
            lvFilmes.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            lvFilmes.Columns.Add("Valor", -2, HorizontalAlignment.Left);
            this.Controls.Add(lvFilmes);

            btnConfirma = new Button();
            btnConfirma.Size = new Size(80, 20);
            btnConfirma.Location = new Point(20, 270);
            btnConfirma.Text = "Confirma";
            this.Controls.Add(btnConfirma);
            btnConfirma.Click += new EventHandler(btnConfirmaClick);

            btnCancela = new Button();
            btnCancela.Size = new Size(80, 20);
            btnCancela.Location = new Point(120, 270);
            btnCancela.Text = "Cancela";
            this.Controls.Add(btnCancela);
            btnCancela.Click += new EventHandler(btnCancelaClick);
        }
        private void btnConfirmaClick(object sender, EventArgs e)
        {
            MessageBox.Show("Confirmado!!");
            parent.Show();
            this.Close();
        }
        private void btnCancelaClick(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }
    }
}