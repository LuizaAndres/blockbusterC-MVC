using System;
using System.Drawing;
using System.Windows.Forms;

namespace Views
{
    public class DetalhaCliente : Form {
        Form parent;
        Button btnConfirma;
        Button btnCancela;
        public DetalhaCliente(Form parent){
            this.Text = "Cliente";
            this.BackColor = Color.Beige;
            this.Size = new Size(300,400);

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
            MessageBox.Show("Cancelado!!");
            parent.Show();
            this.Close();
        }
    }
}