using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller_Rectificaciones
{
    public partial class Form2 : Form
    {
        Form1 forma = new Form1();
        ADMIN ADM = new ADMIN();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "ADMIN" && textBox2.Text == "MARIO")
            {
                this.Hide();
                ADM.ShowDialog();
                this.Show();
                textBox2.Clear();
                textBox1.Clear();
            }
           else if (textBox1.Text == "JOSE" && textBox2.Text == "CONTRASEÑA")
            {
                this.Hide();
                forma.ShowDialog();
                this.Show();
                textBox2.Clear();
                textBox1.Clear();
            }
            else MessageBox.Show("ups algo salio mal vuelve a intentarlo"); textBox1.Clear();textBox2.Clear();

            textBox1.Focus();   
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
