using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {

        public Calculator()
        {
            InitializeComponent();
        }

        bool minus;
        float X, Y, d;
        float num1, num2, num3;
        int trackkeypoint = 0;



        private void Calculator_Load(object sender, EventArgs e)
        {
            richTextBox1.Hide();
        }



        //_______________________________________________________________

        private void Nnp_Click(object sender, EventArgs e)
        {
            if (!minus)
            {
                textBox1.Text = "-" + textBox1.Text;
                minus = true;
            }
            else
            {
                return;
            }
        }

        private void N0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            textBox1.Text = textBox1.Text + '0';
        }

        private void N00_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            textBox1.Text = textBox1.Text + '0' + '0';
        }

        private void N1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            { textBox1.Text = ""; }

            textBox1.Text = textBox1.Text + '1';
        }

        private void N2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            { textBox1.Text = ""; }

            textBox1.Text = textBox1.Text + '2';
        }

        private void N3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            { textBox1.Text = ""; }

            textBox1.Text = textBox1.Text + '3';
        }

        private void N4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            { textBox1.Text = ""; }

            textBox1.Text = textBox1.Text + '4';
        }

        private void N5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            { textBox1.Text = ""; }

            textBox1.Text = textBox1.Text + '5';
        }

        private void N6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            { textBox1.Text = ""; }

            textBox1.Text = textBox1.Text + '6';
        }

        private void N7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            { textBox1.Text = ""; }

            textBox1.Text = textBox1.Text + '7';
        }

        private void N8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            { textBox1.Text = ""; }

            textBox1.Text = textBox1.Text + '8';
        }

        private void N9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            { textBox1.Text = ""; }

            textBox1.Text = textBox1.Text + '9';
        }

        private void Ndat_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '.';
            Ndat.Enabled = false;
        }

        private void Nc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Nback_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            { textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1); }
        }

        private void lblTagsim_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            label1.Text = "/";
            num1 = float.Parse(textBox1.Text);
            textBox1.Text = "";
            Ndat.Enabled = true;
        }

        private void lblZarb_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            label1.Text = "x";
            num1 = float.Parse(textBox1.Text);
            textBox1.Text = "";
            Ndat.Enabled = true;
        }

        private void lblManfi_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            label1.Text = "__";
            num1 = float.Parse(textBox1.Text);
            textBox1.Text = "";
            Ndat.Enabled = true;
        }

        private void lblPlus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            label1.Text = "+";
            num1 = float.Parse(textBox1.Text);
            textBox1.Text = "";
            Ndat.Enabled = true;
        }

        private void lblDarsad_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            num1 = float.Parse(textBox1.Text);
            label1.Text = "%";
            textBox1.Text = Convert.ToString((double.Parse(textBox1.Text)) / 100 * (double.Parse(textBox1.Text)));
            Ndat.Enabled = true;

            richTextBox1.Text = richTextBox1.Text + "\n";
            richTextBox1.Text = richTextBox1.Text + "\n";
            richTextBox1.Text = richTextBox1.Text + num1.ToString();
            richTextBox1.Text = richTextBox1.Text + label1.Text.ToString();
            richTextBox1.Text = richTextBox1.Text + " = ";
            richTextBox1.Text = richTextBox1.Text + textBox1.Text.ToString();
        }

        private void lblRadikal_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            label1.Text = "✔";
            d = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            Ndat.Enabled = true;
            textBox1.Text = Math.Sqrt(d).ToString();

            richTextBox1.Text = richTextBox1.Text + "\n";
            richTextBox1.Text = richTextBox1.Text + "\n";
            richTextBox1.Text = richTextBox1.Text + d.ToString();
            richTextBox1.Text = richTextBox1.Text + label1.Text.ToString();
            richTextBox1.Text = richTextBox1.Text + " = ";
            richTextBox1.Text = richTextBox1.Text + Math.Sqrt(d).ToString();
        }

        private void lblX3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            num1 = float.Parse(textBox1.Text);
            label1.Text = "X³";
            textBox1.Text = Convert.ToString(Math.Pow(double.Parse(textBox1.Text), 3));
            Ndat.Enabled = true;

            richTextBox1.Text = richTextBox1.Text + "\n";
            richTextBox1.Text = richTextBox1.Text + "\n";
            richTextBox1.Text = richTextBox1.Text + num1.ToString();
            richTextBox1.Text = richTextBox1.Text + label1.Text.ToString();
            richTextBox1.Text = richTextBox1.Text + " = ";
            richTextBox1.Text = richTextBox1.Text + textBox1.Text.ToString();
        }

        private void lblX2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            num1 = float.Parse(textBox1.Text);
            label1.Text = "X²";
            textBox1.Text = Convert.ToString(Math.Pow(double.Parse(textBox1.Text), 2));
            Ndat.Enabled = true;

            richTextBox1.Text = richTextBox1.Text + "\n";
            richTextBox1.Text = richTextBox1.Text + "\n";
            richTextBox1.Text = richTextBox1.Text + num1.ToString();
            richTextBox1.Text = richTextBox1.Text + label1.Text.ToString();
            richTextBox1.Text = richTextBox1.Text + " = ";
            richTextBox1.Text = richTextBox1.Text + textBox1.Text.ToString();
        }

        private void lblTavan_Click(object sender, EventArgs e)
        {

        }



        private void lblMosavi_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            num2 = float.Parse(textBox1.Text);

            Ndat.Enabled = true;
            if (label1.Text == "+")
            {

                num3 = num1 + num2;

                textBox1.Text = Convert.ToString(num3);

                richTextBox1.Text = richTextBox1.Text + "\n";
                richTextBox1.Text = richTextBox1.Text + "\n";
                richTextBox1.Text = richTextBox1.Text + num1.ToString();
                richTextBox1.Text = richTextBox1.Text + label1.Text.ToString();
                richTextBox1.Text = richTextBox1.Text + num2.ToString();
                richTextBox1.Text = richTextBox1.Text + " = ";
                richTextBox1.Text = richTextBox1.Text + num3.ToString();
            }

            else if (label1.Text == "__")
            {
                num3 = num1 - num2;

                textBox1.Text = Convert.ToString(num3);


                richTextBox1.Text = richTextBox1.Text + "\n";
                richTextBox1.Text = richTextBox1.Text + "\n";
                richTextBox1.Text = richTextBox1.Text + num1.ToString();
                richTextBox1.Text = richTextBox1.Text + label1.Text.ToString();
                richTextBox1.Text = richTextBox1.Text + num2.ToString();
                richTextBox1.Text = richTextBox1.Text + " = ";
                richTextBox1.Text = richTextBox1.Text + num3.ToString();
            }

            else if (label1.Text == "x")
            {
                num3 = num1 * num2;

                textBox1.Text = Convert.ToString(num3);

                richTextBox1.Text = richTextBox1.Text + "\n";
                richTextBox1.Text = richTextBox1.Text + "\n";
                richTextBox1.Text = richTextBox1.Text + num1.ToString();
                richTextBox1.Text = richTextBox1.Text + label1.Text.ToString();
                richTextBox1.Text = richTextBox1.Text + num2.ToString();
                richTextBox1.Text = richTextBox1.Text + " = ";
                richTextBox1.Text = richTextBox1.Text + num3.ToString();
            }

            else if (label1.Text == "/")
            {
                num3 = num1 / num2;

                textBox1.Text = Convert.ToString(num3);

                richTextBox1.Text = richTextBox1.Text + "\n";
                richTextBox1.Text = richTextBox1.Text + "\n";
                richTextBox1.Text = richTextBox1.Text + num1.ToString();
                richTextBox1.Text = richTextBox1.Text + label1.Text.ToString();
                richTextBox1.Text = richTextBox1.Text + num2.ToString();
                richTextBox1.Text = richTextBox1.Text + " = ";
                richTextBox1.Text = richTextBox1.Text + num3.ToString();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(richTextBox1.Text, "History");
        }

        private void exitClacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(richTextBox1.Text, "History");
        }

        private void creatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("برنامه ساخته شده توسط " + "\n" + "#CoderAlone" + "\n" + "Pardazesh-KarAra.ir", "Creator");
        }

        private void cSTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("برنامه ساخته شده توسط " + "\n" + "#CoderAlone" + "\n" + "Pardazesh-KarAra.ir", "Creator");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.BringToFront();
            label7.Text = "Calculator" + "\n" + "Version 10.1575.1582.0" + "\n" + "Copyright 2017 Pardazesh-KarAra.ir" + "\n" + "Corporation. All rights reserved." + "\n" + "Terms of Use" + "\n" + "Pardazesh-KarAra™";
        }

        private void N1_MouseEnter(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.BackColor = Color.Black;
            lbl.ForeColor = Color.White;
        }

        private void N1_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.BackColor = Color.Silver;
            lbl.ForeColor = Color.Black;
        }

        private void lblTavan_MouseLeave(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.BackColor = Color.LightGray;
            lbl.ForeColor = Color.Black;
        }

        private void N1_MouseMove(object sender, MouseEventArgs e)
        {
            Label lbl = (Label)sender;
            lbl.BackColor = Color.Black;
            lbl.ForeColor = Color.White;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.BringToFront();
            label7.Text = "Calculator" + "\n" + "Version 10.1575.1582.0" + "\n" + "Copyright 2017 Pardazesh-KarAra.ir" + "\n" + "Corporation. All rights reserved." + "\n" + "Terms of Use" + "\n" + "Pardazesh-KarAra™";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.BringToFront();
            label7.Text = "Calculator" + "\n" + "Version 10.1575.1582.0" + "\n" + "Copyright 2017 Pardazesh-KarAra.ir" + "\n" + "Corporation. All rights reserved." + "\n" + "Terms of Use" + "\n" + "Pardazesh-KarAra™";
        }

        private void sDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("برنامه ساخته شده توسط " + "\n" + "#CoderAlone" + "\n" + "Pardazesh-KarAra.ir", "Creator");
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}