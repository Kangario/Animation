using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrushkovPractica
{
    public partial class Отладка : Form
    {
        public string ri;
            



        public string Ri
        {
            get
            {
                return Ri;
            }
            set
            {
                richTextBox1.Text += value;
            }
        }
        public Отладка()
        {
          
            InitializeComponent();
            richTextBox1.Text = ri;
        }

        private void Отладка_Load(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
