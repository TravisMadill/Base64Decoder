using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base64Decoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Preparing...";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream s;
                if ((s = saveFileDialog1.OpenFile()) != null)
                {
                    byte[] data = Convert.FromBase64String(richTextBox1.Text);
                    s.Write(data, 0, data.Length);
                    s.Close();
                    label1.Text = "Done!";
                }
                else
                {
                    label1.Text = "Something went wrong...";
                }
            }
            else
            {
                label1.Text = "Cancelled saving.";
            }
            

        }
    }
}
