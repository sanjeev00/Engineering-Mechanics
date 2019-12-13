using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        
        

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {


            if (wizardPageContainer1.SelectedPage == wizardPage9)
                Application.Exit();
            else if (wizardPageContainer1.SelectedPage == wizardPage8)
            {
                if (alpha.Value != 0 || beta.Value != 0 || af.Value != 0)
                {
                    float al, be, ga, a, b, c;
                    a = (float)af.Value;
                    al = (float)alpha.Value * (float)3.14 / 180;
                    be = (float)beta.Value * (float)3.14 / 180;
                    ga = (360 - (float)alpha.Value - (float)beta.Value) * (float)3.14 / 180;
                    b = a / (float)Math.Sin(al) * (float)Math.Sin(be);
                    c = a / (float)Math.Sin(al) * (float)Math.Sin(ga);
                    label29.Text = $"A = {a} N \nB = {b} N \nC = {c} N";
                }
                else
                    label29.Text = "Please enter values for Angles and Forces";
                wizardPageContainer1.NextPage(wizardPage9);

            }
            else if (wizardPageContainer1.SelectedPage == wizardPage4)
                Application.Exit();

            else if (wizardPageContainer1.SelectedPage == wizardPage5)
            {
                float d, v, a, t1, t2, t3;
                if (checkBox1.Checked)
                {
                    t1 = (float)numericUpDown6.Value;
                    d = (float)ct3.Value * t1 * t1 * t1 + (float)ct2.Value * t1 * t1 + (float)ct1.Value * t1 + (float)cc.Value;
                    label17.Text = $"The displacement at {t1} seconds is {d}";
                }
                if (checkBox2.Checked)
                {
                    t2 = (float)numericUpDown7.Value;
                    v = 3 * (float)ct3.Value * t2 * t2 + (float)ct2.Value * t2 * 2 + (float)ct1.Value;
                    label18.Text = $"The velocity at {t2} seconds is {v}";
                }
                if (checkBox2.Checked)
                {
                    t3 = (float)numericUpDown8.Value;
                    a = 6 * (float)ct3.Value * t3 + (float)ct2.Value * 2;
                    label19.Text = $"The acceleration at {t3} seconds is {a}";
                }
                if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
                    wizardPageContainer1.NextPage(wizardPage6);


            }
            else if (wizardPageContainer1.SelectedPage == wizardPage3)
                wizardPageContainer1.NextPage(wizardPage7);
            else if (wizardPageContainer1.SelectedPage == wizardPage6)
                Application.Exit();

            else if (wizardPageContainer1.SelectedPage == wizardPage7)
            {

                float x = 0, y = 0, z = 0, x1, y1, z1, x2, y2, z2, x3, y3, z3, o1, o2, o3;
                o1 = (float)xo.Value;
                o2 = (float)yo.Value;
                o3 = (float)zo.Value;
                x1 = (float)fx1.Value - o1;
                x2 = (float)fx2.Value - o1;
                x3 = (float)fx3.Value - o1;
                y1 = (float)fy1.Value - o2;
                y2 = (float)fy2.Value - o2;
                y3 = (float)fy3.Value - o2;
                z1 = (float)fz1.Value - o3;
                z2 = (float)fz2.Value - o3;
                z3 = (float)fz3.Value - o3;
                char _1 = '+', _2 = '+';
                float m1, m2, m3, magnitude;
                m1 = (float)Math.Sqrt((x1) * (x1) + y1 * y1 + z1 * z1);
                m1 = 1 / m1;
                m2 = (float)Math.Sqrt((x2) * (x2) + y2 * y2 + z2 * z2);
                m2 = 1 / m2;
                m3 = (float)Math.Sqrt((x3) * (x3) + y3 * y3 + z3 * z3);
                m3 = 1 / m3;
                x = m1 * x1 * (float)fm1.Value + m2 * x2 * (float)fm2.Value + m3 * x3 * (float)fm3.Value;
                y = m1 * y1 * (float)fm1.Value + m2 * y2 * (float)fm2.Value + m3 * y3 * (float)fm3.Value;
                z = m1 * z1 * (float)fm1.Value + m2 * z2 * (float)fm2.Value + m3 * z3 * (float)fm3.Value;
                if (y < 0)
                    _1 = ' ';
                if (z < 0)
                    _2 = ' ';
                magnitude = (float)Math.Sqrt(x * x + y * y + z * z);

                if (fm1.Value != 0 || fm2.Value != 0 || fm3.Value != 0)
                    label9.Text = $"The resultant force is {x}i {_1}{y}j {_2}{z}k \nMagnitude is {magnitude}";
                else
                    label9.Text = "Please enter values to find out resultant";
                wizardPageContainer1.NextPage(wizardPage4);
            }

            else if (wizardPageContainer1.SelectedPage == wizardPage2)
            {
                if (radioButton1.Checked)
                    wizardPageContainer1.NextPage(wizardPage3);
                if (radioButton2.Checked)
                    wizardPageContainer1.NextPage(wizardPage5);
                if (radioButton5.Checked)
                    wizardPageContainer1.NextPage(wizardPage8);
            }

            else
                wizardPageContainer1.NextPage();
            
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(wizardPageContainer1.SelectedPage!=wizardPage1)
                wizardPageContainer1.PreviousPage();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void wizardPage1_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                numericUpDown6.Enabled = true;
            else
                numericUpDown6.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                numericUpDown7.Enabled = true;
            else
                numericUpDown7.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                numericUpDown8.Enabled = true;
            else
                numericUpDown8.Enabled = false;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void wizardPage7_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void xo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void alpha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void B_ValueChanged(object sender, EventArgs e)
        {

        }

        private void beta_ValueChanged(object sender, EventArgs e)
        {
            alpha.Maximum = 360 - beta.Value; 
        }

        private void alpha_ValueChanged_1(object sender, EventArgs e)
        {
            beta.Maximum = 360 - alpha.Value;
        }
    }
}
