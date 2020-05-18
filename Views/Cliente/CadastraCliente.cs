using System;
using System.Drawing;
using System.Windows.Forms;
using Controllers;

namespace View
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
        CheckBox chbAtivo;
        GroupBox gbGenero;
        RadioButton rbSexoMasc;
        RadioButton rbSexoFem;
        Button btnConfirma;
        Button btnCancela;
        LinkLabel linkHelp;
        public CadastraCliente(Form parent)
        {
            this.parent = parent;

            int x = 20;
            this.Text = "Cadastra Cliente";
            this.BackColor = Color.Beige;

            lblNome = new Label();
            lblNome.Text = "Nome: ";
            lblNome.Location = new Point(x, 20);

            rtxtNome = new RichTextBox();
            rtxtNome.Location = new Point(130, 20);
            rtxtNome.Size = new Size(110, 20);

            lblDtNasc = new Label();
            lblDtNasc.Text = "Dt. Nasc:";
            lblDtNasc.Location = new Point(x, 50);

            txtDtNasc = new MaskedTextBox();
            txtDtNasc.Location = new Point(130, 50);
            txtDtNasc.Size = new Size(110, 20);
            txtDtNasc.Mask = "00/00/0000";

            lblCpf = new Label();
            lblCpf.Text = "CPF: ";
            lblCpf.Location = new Point(x, 80);

            txtCpf = new MaskedTextBox();
            txtCpf.Location = new Point(130, 80);
            txtCpf.Size = new Size(110, 20);
            txtCpf.Mask = "000.000.000-00";

            lblDiasDev = new Label();
            lblDiasDev.Text = "Dias Dev.: ";
            lblDiasDev.Location = new Point(x, 110);

            numDiasDev = new NumericUpDown();
            numDiasDev.Location = new Point(130, 110);
            numDiasDev.Size = new Size(110, 20);
            numDiasDev.Maximum = 20;
            numDiasDev.Minimum = 5;
            numDiasDev.Increment = 5;
            numDiasDev.ReadOnly = true;

            chbAtivo = new CheckBox();
            chbAtivo.Location = new Point (130,140);
            chbAtivo.Size = new Size (110,20);
            chbAtivo.Text = "Ativo?";

            gbGenero = new GroupBox();
            gbGenero.Location = new Point (130,170);
            gbGenero.Size = new Size (110,80);
            gbGenero.Text = "Genero";

            rbSexoMasc = new RadioButton();
            rbSexoMasc.Location = new Point(5,20);
            rbSexoMasc.Size = new Size (110,20);
            rbSexoMasc.Text = "Masculino";

            rbSexoFem = new RadioButton();
            rbSexoFem.Location = new Point(5,50);
            rbSexoFem.Size = new Size (110,20);
            rbSexoFem.Text = "Feminino";

            gbGenero.Controls.Add(rbSexoMasc);
            gbGenero.Controls.Add(rbSexoFem);

            linkHelp = new LinkLabel();
            linkHelp.Location = new Point (x, 300);
            linkHelp.Size = new Size(100,30);
            linkHelp.Text = "Ajuda";
            linkHelp.LinkClicked += new LinkLabelLinkClickedEventHandler(helpLink);
 
            this.Controls.Add(lblNome);
            this.Controls.Add(rtxtNome);
            this.Controls.Add(lblDtNasc);
            this.Controls.Add(txtDtNasc);
            this.Controls.Add(lblCpf);
            this.Controls.Add(txtCpf);
            this.Controls.Add(lblDiasDev);
            this.Controls.Add(numDiasDev);
            this.Controls.Add(chbAtivo);
            this.Controls.Add(gbGenero);
            this.Controls.Add(linkHelp);
            this.Size = new Size(300, 400);

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
        private void helpLink(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try{
                VisitLink();
            }
            catch (Exception err){
                MessageBox.Show(err.Message);
            }
        }
        private void VisitLink()
        {
            this.linkHelp.LinkVisited = true;
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\Chrome.exe","http://google.com");
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
            MessageBox.Show("Cancelado!!");
            this.Close();
            this.parent.Show();
        }
    }
}