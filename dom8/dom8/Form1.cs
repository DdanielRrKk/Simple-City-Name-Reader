using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dom8
{
    public partial class Form1 : Form
    {
        Label lbl = new Label()
        {
            Text = "Тук ще бъдат имената на градовете",
            Location = new Point(20, 20)
        };

        TextBox tb = new TextBox()
        {
            Location = new Point(20, 60)
        };

        Button btn=new Button()
        {
            Text="Прати Град",
            Location = new Point(40, 100)
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Controls.Add(lbl);
            this.Controls.Add(tb);
            this.Controls.Add(btn);
        }

        public void btn_Click(Object sender, EventHandler e)
        {

        }

    }
}
