using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using Controllers;
using Models;
using static System.Windows.Forms.View;

namespace Views
{
    public class CadastraLocacao : Form {
        Form parent;
        Label lblCliente;
        Label lblFilme;
        ListView lvFilmes;
        Button btnConfirma;
        Button btnCancela;
        Cliente clienteLocal;
        Locacao locacao;
        public CadastraLocacao(Form parent,Cliente clienteDetalhaCliente){
            this.parent = parent;

            this.clienteLocal = clienteDetalhaCliente;

            this.Text = "Locacao";
            this.BackColor = Color.Beige;
            this.Size = new Size(300,400);

            lblCliente = new Label();
            lblCliente.Location = new Point(20,20);
            lblCliente.Text = clienteLocal.Nome;
            this.Controls.Add(lblCliente);

            lblFilme = new Label();
            lblFilme.Location = new Point(20,50);
            lblFilme.Text = "Filme";
            this.Controls.Add(lblFilme);

            lvFilmes = new ListView();
            lvFilmes.Size = new Size(200,220);
            lvFilmes.Location = new Point(20,80);
            lvFilmes.View = Details;
            ListViewItem filmes = new ListViewItem();
            lvFilmes.CheckBoxes = true;
            foreach (Filme filme in FilmeController.GetFilmes())
            {
                ListViewItem lvFilme = new ListViewItem(filme.FilmeId.ToString());
                lvFilme.SubItems.Add(filme.NomeFilme);
                lvFilme.SubItems.Add(filme.Valor.ToString());
                lvFilmes.Items.Add(lvFilme);
            }
            lvFilmes.FullRowSelect = true;
            lvFilmes.Columns.Add("ID", -2, HorizontalAlignment.Left);
            lvFilmes.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            lvFilmes.Columns.Add("Valor", -2, HorizontalAlignment.Left);
            this.Controls.Add(lvFilmes);
            
            btnConfirma = new Button();
            btnConfirma.Size = new Size(80, 20);
            btnConfirma.Location = new Point(20, 300);
            btnConfirma.Text = "Confirma";
            this.Controls.Add(btnConfirma);
            btnConfirma.Click += new EventHandler(btnConfirmaClick);

            btnCancela = new Button();
            btnCancela.Size = new Size(80, 20);
            btnCancela.Location = new Point(120, 300);
            btnCancela.Text = "Cancela";
            this.Controls.Add(btnCancela);
            btnCancela.Click += new EventHandler(btnCancelaClick);
        }
        private void btnConfirmaClick(object sender, EventArgs e)
        {
            locacao=new Locacao();
            locacao.ClienteId=clienteLocal.ClienteId;
            locacao.Cliente=clienteLocal;
            string lstFilm = "";
            double vl = 0;
            foreach( ListViewItem filme in lvFilmes.CheckedItems)
                {
                        lstFilm += lstFilm + filme.SubItems[1].Text.ToString();
                }
            
            DialogResult result = MessageBox.Show(
                $"Nome: {this.clienteLocal.Nome}\n" + 
                $"Filmes Locados: "+lstFilm+
                $"Valor da Locação: " ,
                "Confirma Locação?",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
           );
            if (result == DialogResult.OK){
                Locacao.InserirLocacao(clienteLocal, DateTime.Now);
                foreach( Filme filme in lvFilmes.CheckedItems)
                {
                    LocacaoController.InserirFilme(locacao, filme);
                }

           }
            this.Close();
            parent.Show();
        }
        private void btnCancelaClick(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }
    }
}