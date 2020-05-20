using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using Controllers;
using Models;

namespace Views
{
    public class CadastraLocacao : Form {
        Form parent;
        Label lblCliente;
        Label lblFilme;
        CheckedListBox clbFilme;
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

            clbFilme = new CheckedListBox();
            clbFilme.Location = new Point(20,80);
            clbFilme.Name = "Filmes";
            clbFilme.Size = new Size(100, 120);
            clbFilme.ScrollAlwaysVisible = true;
            clbFilme.CheckOnClick = true;
            
            foreach (Filme filme in FilmeController.GetFilmes()){
                clbFilme.Items.Add($"Id: {filme.FilmeId} Nome: {filme.NomeFilme} R$: {filme.Valor}");
            }
            this.Controls.Add(clbFilme);
            
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
            DialogResult result = MessageBox.Show(
                $"Nome: {this.clienteLocal.Nome}\n" + 
                $"Filmes Locados: {LocacaoController.GetFilmesLocados(locacao)}\n"+
                $"Valor da Locação: {LocacaoController.GetValorTotal(locacao)}",
                "Confirma Locação?",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question   
           );
            if (result == DialogResult.Yes){
                foreach( Filme filme in clbFilme.CheckedItems)
                {
                    LocacaoController.InserirFilme(locacao, filme);
                }
           }
            this.Close();
            SelecionaFilme selecionaFilme = new SelecionaFilme(this);
            selecionaFilme.Show();
        }
        private void btnCancelaClick(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }
    }
}