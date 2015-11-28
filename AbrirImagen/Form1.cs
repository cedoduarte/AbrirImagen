using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbrirImagen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var d = new OpenFileDialog();
            if (d.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            var filename = d.FileName;
            pictureBox1.Image = Image.FromFile(filename);
        }
    }
}
