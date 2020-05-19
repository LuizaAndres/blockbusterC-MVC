using System;
using System.Drawing;
using System.Windows.Forms;
using Controllers;
using Models;

namespace Views
{
    public class DetalhaCliente : Form {
        Form parent;
        Button btnLocacao;
        Button btnCancela;
        Label lblNome;
        Label lblCpf;
        Label lblDiasDev;
        Label lblDtNasc;

        int idCliente;
        Cliente clientaao;
        
        public DetalhaCliente(Form parent, Cliente cliente){
            this.idCliente=cliente.ClienteId;
            this.clientaao = cliente;
            this.Text = "Cliente";
            this.BackColor = Color.Beige;
            this.Size = new Size(300,400);

            lblNome = new Label();
            lblNome.Text = cliente.Nome;
            lblNome.BackColor = Color.White;
            lblNome.Location = new Point(20, 20);
            this.Controls.Add(lblNome);

            lblCpf = new Label();
            lblCpf.Text = cliente.Cpf;
            lblCpf.BackColor = Color.White;
            lblCpf.Location = new Point(20, 50);
            this.Controls.Add(lblCpf);

            lblDiasDev = new Label();
            lblDiasDev.Text = cliente.Dias.ToString();
            lblDiasDev.BackColor = Color.White;
            lblDiasDev.Location = new Point(20, 80);
            this.Controls.Add(lblDiasDev);

            lblDtNasc = new Label();
            lblDtNasc.Text = cliente.DtNasc.ToString();
            lblDtNasc.BackColor = Color.White;
            lblDtNasc.Location = new Point(20, 110);
            this.Controls.Add(lblDtNasc);

            btnLocacao = new Button();
            btnLocacao.Size = new Size(80, 20);
            btnLocacao.Location = new Point(20, 270);
            btnLocacao.Text = "Cadastar Locação";
            this.Controls.Add(btnLocacao);
            btnLocacao.Click += new EventHandler(btnLocacaoClick);

            btnCancela = new Button();
            btnCancela.Size = new Size(80, 20);
            btnCancela.Location = new Point(120, 270);
            btnCancela.Text = "Cancela";
            this.Controls.Add(btnCancela);
            btnCancela.Click += new EventHandler(btnCancelaClick);  
        }
       private void btnLocacaoClick(object sender, EventArgs e)
        {
            CadastraLocacao CadastraLocacaoClick = new CadastraLocacao(this,this.clientaao);
            CadastraLocacaoClick.Show();
            this.Hide();
        }
        private void btnCancelaClick(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelado!!");
            parent.Show();
            this.Close();
        }
    }
}