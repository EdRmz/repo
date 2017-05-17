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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox58.Enabled = true;
               
            }
            if (checkBox1.Checked == false)
            {
                textBox58.Enabled = false;
                textBox58.Clear();
            }
        }

        private void textBox58_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if(char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if(char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        int a;
        decimal b;
        decimal c;

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox25.Clear();
            textBox26.Clear();
            textBox27.Clear();
            textBox28.Clear();
            textBox29.Clear();
            textBox30.Clear();
            textBox31.Clear();
            textBox31.Clear();
            textBox32.Clear();
            textBox33.Clear();
            textBox34.Clear();
            textBox35.Clear();
            textBox36.Clear();
            textBox37.Clear();
            textBox38.Clear();
            textBox39.Clear();
            textBox40.Clear();
            textBox41.Clear();
            textBox42.Clear();
            textBox43.Clear();
            textBox44.Clear();
            textBox45.Clear();
            textBox46.Clear();
            textBox47.Clear();
            textBox48.Clear();
            textBox49.Clear();
            textBox50.Clear();
            textBox51.Clear();
            textBox52.Clear();
            textBox53.Clear();
            textBox54.Clear();
            textBox55.Clear();
            textBox56.Clear();
            textBox57.Clear();
            textBox58.Clear();
            textBox59.Clear();
            textBox60.Clear();
            textBox61.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;

             textBox40.Text = "350";
            textBox39.Text = "300";
            textBox37.Text = "800";
            textBox38.Text = "230";
            textBox34.Text = "460";
            textBox31.Text = "180";
            textBox32.Text = "700";
            textBox33.Text = "580";
            textBox35.Text = "490";
            textBox36.Text = "650";
            textBox28.Text = "710";
            textBox29.Text = "530";
            textBox30.Text = "780";
            textBox27.Text = "620";
            textBox25.Text = "330";
            textBox26.Text = "440";
            textBox24.Text = "710";
            textBox23.Text="120";
            


            if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled) 
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
               textBox61.Text = Convert.ToString(a);
               decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
               textBox60.Text = Convert.ToString(b);
               decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
               textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }
            
             else if (checkBox1.Enabled && checkBox2.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled) 
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
               textBox61.Text = Convert.ToString(a);
               decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
               textBox60.Text = Convert.ToString(b);
               decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
               textBox59.Text = Convert.ToString(c);
            }

             else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled) 
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
               textBox61.Text = Convert.ToString(a);
               decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
               textBox60.Text = Convert.ToString(b);
               decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
               textBox59.Text = Convert.ToString(c);
            }

             else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled) 
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) +Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
               textBox61.Text = Convert.ToString(a);
               decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
               textBox60.Text = Convert.ToString(b);
               decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
               textBox59.Text = Convert.ToString(c);
            }
         
             else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled) 
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox32.Text) +Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
               textBox61.Text = Convert.ToString(a);
               decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
               textBox60.Text = Convert.ToString(b);
               decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
               textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled) 
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text)  + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
               textBox61.Text = Convert.ToString(a);
               decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
               textBox60.Text = Convert.ToString(b);
               decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
               textBox59.Text = Convert.ToString(c);
            }
         
            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled) 
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
               textBox61.Text = Convert.ToString(a);
               decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
               textBox60.Text = Convert.ToString(b);
               decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
               textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled) 
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
               textBox61.Text = Convert.ToString(a);
               decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
               textBox60.Text = Convert.ToString(b);
               decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
               textBox59.Text = Convert.ToString(c);
            }

           else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled) 
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
               textBox61.Text = Convert.ToString(a);
               decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
               textBox60.Text = Convert.ToString(b);
               decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
               textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled) 
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
               textBox61.Text = Convert.ToString(a);
               decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
               textBox60.Text = Convert.ToString(b);
               decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
               textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled) 
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
               textBox61.Text = Convert.ToString(a);
               decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
               textBox60.Text = Convert.ToString(b);
               decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
               textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled) 
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
               textBox61.Text = Convert.ToString(a);
               decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
               textBox60.Text = Convert.ToString(b);
               decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
               textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled) 
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
               textBox61.Text = Convert.ToString(a);
               decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
               textBox60.Text = Convert.ToString(b);
               decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
               textBox59.Text = Convert.ToString(c);
            }

           else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled) 
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
               textBox61.Text = Convert.ToString(a);
               decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
               textBox60.Text = Convert.ToString(b);
               decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
               textBox59.Text = Convert.ToString(c);
            }

           else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox17.Enabled && checkBox18.Enabled) 
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
               textBox61.Text = Convert.ToString(a);
               decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
               textBox60.Text = Convert.ToString(b);
               decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
               textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox18.Enabled) 
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox23.Text);
               textBox61.Text = Convert.ToString(a);
               decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
               textBox60.Text = Convert.ToString(b);
               decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
               textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled) 
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text);
               textBox61.Text = Convert.ToString(a);
               decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
               textBox60.Text = Convert.ToString(b);
               decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
               textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled) 
            {
                int a = Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
               textBox61.Text = Convert.ToString(a);
               decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
               textBox60.Text = Convert.ToString(b);
               decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
               textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox2.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled) 
            {
                int a = Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
               textBox61.Text = Convert.ToString(a);
               decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
               textBox60.Text = Convert.ToString(b);
               decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
               textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox2.Enabled && checkBox3.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled) 
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
               textBox61.Text = Convert.ToString(a);
               decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
               textBox60.Text = Convert.ToString(b);
               decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
               textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled) 
            {
                int a = Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
               textBox61.Text = Convert.ToString(a);
               decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
               textBox60.Text = Convert.ToString(b);
               decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
               textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled) 
            {
                int a = Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
               textBox61.Text = Convert.ToString(a);
               decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
               textBox60.Text = Convert.ToString(b);
               decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
               textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled)
            {
                int a = Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox3.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }
            else if (checkBox1.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled  && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }


            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox4.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }


            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }


            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox5.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled  && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox6.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox6.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox7.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled  && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled  && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }


            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox7.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox32.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }
            
            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox8.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Checked && checkBox2.Enabled && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }

            else if (checkBox1.Enabled && checkBox2.Enabled  && checkBox3.Enabled && checkBox4.Enabled && checkBox5.Enabled && checkBox6.Enabled && checkBox8.Enabled && checkBox9.Enabled && checkBox10.Enabled && checkBox11.Enabled && checkBox12.Enabled && checkBox13.Enabled && checkBox14.Enabled && checkBox15.Enabled && checkBox16.Enabled && checkBox17.Enabled && checkBox18.Enabled)
            {
                int a = Convert.ToInt16(textBox40.Text) + Convert.ToInt16(textBox39.Text) + Convert.ToInt16(textBox37.Text) + Convert.ToInt16(textBox38.Text) + Convert.ToInt16(textBox34.Text) + Convert.ToInt16(textBox31.Text) + Convert.ToInt16(textBox33.Text) + Convert.ToInt16(textBox35.Text) + Convert.ToInt16(textBox36.Text) + Convert.ToInt16(textBox28.Text) + Convert.ToInt16(textBox29.Text) + Convert.ToInt16(textBox30.Text) + Convert.ToInt16(textBox27.Text) + Convert.ToInt16(textBox25.Text) + Convert.ToInt16(textBox26.Text) + Convert.ToInt16(textBox24.Text) + Convert.ToInt16(textBox23.Text);
                textBox61.Text = Convert.ToString(a);
                decimal b = Convert.ToDecimal(textBox61.Text) * Convert.ToDecimal(.16) / Convert.ToDecimal(100);
                textBox60.Text = Convert.ToString(b);
                decimal c = Convert.ToDecimal(textBox61.Text) + Convert.ToDecimal(textBox60.Text);
                textBox59.Text = Convert.ToString(c);
            }
        }
         
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBox58_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox57.Enabled = true;

            }
            if (checkBox2.Checked == false)
            {
                textBox57.Enabled = false;
                textBox57.Clear();
            }
        }

        private void textBox57_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox55.Enabled = true;

            }
            if (checkBox3.Checked == false)
            {
                textBox55.Enabled = false;
                textBox55.Clear();
            }
        }

        private void textBox55_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox56.Enabled = true;

            }
            if (checkBox4.Checked == false)
            {
                textBox56.Enabled = false;
                textBox56.Clear();
            }

        }

        private void textBox56_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox52.Enabled = true;

            }
            if (checkBox5.Checked == false)
            {
                textBox52.Enabled = false;
                textBox52.Clear();
            }

        }

        private void textBox52_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                textBox49.Enabled = true;

            }
            if (checkBox6.Checked == false)
            {
                textBox49.Enabled = false;
                textBox49.Clear();
            }
        }

        private void textBox49_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                textBox50.Enabled = true;

            }
            if (checkBox7.Checked == false)
            {
                textBox50.Enabled = false;
                textBox50.Clear();
            }
        }

        private void textBox50_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                textBox51.Enabled = true;

            }
            if (checkBox8.Checked == false)
            {
                textBox51.Enabled = false;
                textBox51.Clear();
            }
        }

        private void textBox51_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                textBox53.Enabled = true;

            }
            if (checkBox9.Checked == false)
            {
                textBox53.Enabled = false;
                textBox53.Clear();
            }
        }

        private void textBox53_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                textBox54.Enabled = true;

            }
            if (checkBox10.Checked == false)
            {
                textBox54.Enabled = false;
                textBox54.Clear();
            }

        }

        private void textBox54_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                textBox46.Enabled = true;

            }
            if (checkBox11.Checked == false)
            {
                textBox46.Enabled = false;
                textBox46.Clear();
            }
        }

        private void textBox46_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                textBox47.Enabled = true;

            }
            if (checkBox12.Checked == false)
            {
                textBox47.Enabled = false;
                textBox47.Clear();
            }
        }

        private void textBox47_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                textBox48.Enabled = true;

            }
            if (checkBox13.Checked == false)
            {
                textBox48.Enabled = false;
                textBox48.Clear();
            }
        }

        private void textBox48_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                textBox45.Enabled = true;

            }
            if (checkBox14.Checked == false)
            {
                textBox45.Enabled = false;
                textBox45.Clear();
            }
        }

        private void textBox45_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                textBox43.Enabled = true;

            }
            if (checkBox15.Checked == false)
            {
                textBox43.Enabled = false;
                textBox43.Clear();
            }
        }

        private void textBox43_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                textBox44.Enabled = true;

            }
            if (checkBox16.Checked == false)
            {
                textBox44.Enabled = false;
                textBox44.Clear();
            }
        }

        private void textBox44_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true)
            {
                textBox42.Enabled = true;

            }
            if (checkBox17.Checked == false)
            {
                textBox42.Enabled = false;
                textBox42.Clear();
            }
        }

        private void textBox42_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true)
            {
                textBox41.Enabled = true;

            }
            if (checkBox18.Checked == false)
            {
                textBox41.Enabled = false;
                textBox41.Clear();
            }

        }

        private void textBox41_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
