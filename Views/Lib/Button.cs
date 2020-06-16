
using System.Drawing;
using System.Windows.Forms;

namespace Library
{
    public class Button : System.Windows.Forms.Button
    {

        public Button()
        {            
            this.Size = new Size(80, 20);
            this.BackColor = Color.Gray;
            this.ForeColor = Color.Black;
        }
    }
}