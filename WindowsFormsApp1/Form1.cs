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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dir = textBox1.Text;
            Directory.CreateDirectory("data\\" + dir);

            var sw = new StreamWriter("data\\" + dir + "data.ls");

            string enctxt = Encryptor.Encrypt(textBox1.Text);

            sw.WriteLine(enctxt);

            sw.Close();
        }
    }
}
