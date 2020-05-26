using System;
using System.Drawing;
using System.Windows.Forms;
using Controllers;

namespace Views
{
    public class CadastraCliente : Form
    {
        Form parent;
        Label lblNome;
        RichTextBox rtxtNome;
        Label lblDtNasc;
        MaskedTextBox txtDtNasc;
        Label lblCpf;
        MaskedTextBox txtCpf;
        Label lblDiasDev;
        NumericUpDown numDiasDev;
        Button btnConfirma;
        Button btnCancela;
        public CadastraCliente(Form parent)
        {
            this.parent = parent;

            int x = 20;
            this.Text = "Cadastra Cliente";
            this.BackColor = Color.Beige;
            this.Size = new Size(300, 400);

            lblNome = new Label();
            lblNome.Text = "Nome: ";
            lblNome.Location = new Point(x, 20);
            this.Controls.Add(lblNome);

            rtxtNome = new RichTextBox();
            rtxtNome.Location = new Point(130, 20);
            rtxtNome.Size = new Size(110, 20);
            this.Controls.Add(rtxtNome);

            lblDtNasc = new Label();
            lblDtNasc.Text = "Dt. Nasc:";
            lblDtNasc.Location = new Point(x, 50);
            this.Controls.Add(lblDtNasc);

            txtDtNasc = new MaskedTextBox();
            txtDtNasc.Location = new Point(130, 50);
            txtDtNasc.Size = new Size(110, 20);
            txtDtNasc.Mask = "00/00/0000";
            this.Controls.Add(txtDtNasc);

            lblCpf = new Label();
            lblCpf.Text = "CPF: ";
            lblCpf.Location = new Point(x, 80);
            this.Controls.Add(lblCpf);

            txtCpf = new MaskedTextBox();
            txtCpf.Location = new Point(130, 80);
            txtCpf.Size = new Size(110, 20);
            txtCpf.Mask = "000.000.000-00";
            this.Controls.Add(txtCpf);

            lblDiasDev = new Label();
            lblDiasDev.Text = "Dias Dev.: ";
            lblDiasDev.Location = new Point(x, 110);
            this.Controls.Add(lblDiasDev);

            numDiasDev = new NumericUpDown();
            numDiasDev.Location = new Point(130, 110);
            numDiasDev.Size = new Size(110, 20);
            numDiasDev.Maximum = 20;
            numDiasDev.Minimum = 5;
            numDiasDev.Increment = 5;
            numDiasDev.ReadOnly = true;
            this.Controls.Add(numDiasDev);

            btnConfirma = new Button();
            btnConfirma.Size = new Size(80, 20);
            btnConfirma.Location = new Point(x, 300);
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
            try{
                ClienteController.InserirCliente(this.rtxtNome.Text,this.txtDtNasc.Text, this.txtCpf.Text, (int)this.numDiasDev.Value);
                MessageBox.Show(
                    $"Nome: {this.rtxtNome.Text}\n" +
                    $"Data Nasc: {this.txtDtNasc.Text}\n" +
                    $"CPF: {this.txtCpf.Text}\n" +
                    $"DiasDev: {this.numDiasDev.Value}",
                    "Cliente",
                    MessageBoxButtons.OK
                );
                this.Close();
                this.parent.Show();  
            }catch (Exception err){
                MessageBox.Show(err.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelaClick(object sender, EventArgs e)
        {
            this.Close();
            this.parent.Show();
        }
    }
}