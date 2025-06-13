using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpmodul3_2311104078
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string nama = textBoxInput.Text;

            if (!string.IsNullOrWhiteSpace(nama))
            {
                labelOutput.Text = "Halo " + nama;
            }
            else
            {
                labelOutput.Text = "Nama tidak boleh kosong.";
            }
        }
    }
}
