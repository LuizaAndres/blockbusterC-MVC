using System;
using System.Drawing;
using System.Windows.Forms;
using Models;
namespace Views
{
    public class DetalhaCliente : Form {
        Form parent;
        Label lblDetalhaCliente;
        Button btnLocacao;
        Button btnVoltar;
        Label lblNome;
        Label lblCpf;
        Label lblDiasDev;
        Label lblDtNasc;
        int idCliente;
        Cliente clienteLocal;

        public DetalhaCliente(Form parent, Cliente cliente){
            this.parent = parent;
            this.idCliente=cliente.ClienteId;
            this.clienteLocal = cliente;
            this.Text = "Detalha Cliente";
            this.BackColor = Color.Beige;
            this.Size = new Size(300,400);

            lblDetalhaCliente = new Label();
            lblDetalhaCliente.Location = new Point(90,30);
            lblDetalhaCliente.AutoSize = true;
            lblDetalhaCliente.Text = "Detalhes do Cliente";
            this.Controls.Add(lblDetalhaCliente);

            lblNome = new Label();
            lblNome.AutoSize = true;
            lblNome.Location = new Point(20, 60);
            lblNome.Text = $"Nome: {cliente.Nome}";
            this.Controls.Add(lblNome);

            lblCpf = new Label();
            lblCpf.Location = new Point(20, 90);
            lblCpf.AutoSize = true;
            lblCpf.Text = $"CPF: {cliente.Cpf}";
            this.Controls.Add(lblCpf);

            lblDiasDev = new Label();
            lblDiasDev.Location = new Point(20, 120);
            lblDiasDev.AutoSize = true;
            lblDiasDev.Text = $"Dias Devolução: {cliente.Dias.ToString()}";
            this.Controls.Add(lblDiasDev);

            lblDtNasc = new Label();
            lblDtNasc.Location = new Point(20, 150);
            lblDtNasc.AutoSize = true;
            lblDtNasc.Text = $"Data de Nascimento: {cliente.DtNasc.ToShortDateString()}";
            this.Controls.Add(lblDtNasc);

            btnLocacao = new Button();
            btnLocacao.Size = new Size(130, 20);
            btnLocacao.Location = new Point(20, 300);
            btnLocacao.Text = "Nova Locação";
            this.Controls.Add(btnLocacao);
            btnLocacao.Click += new EventHandler(btnLocacaoClick);

            btnVoltar = new Button();
            btnVoltar.Size = new Size(80, 20);
            btnVoltar.Location = new Point(170, 300);
            btnVoltar.Text = "Voltar";
            this.Controls.Add(btnVoltar);
            btnVoltar.Click += new EventHandler(btnVoltarClick);  
        }
       private void btnLocacaoClick(object sender, EventArgs e)
        {
            CadastraLocacao CadastraLocacaoClick = new CadastraLocacao(this,this.clienteLocal);
            CadastraLocacaoClick.Show();
            this.Hide();
        }
        private void btnVoltarClick(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }
    }
}