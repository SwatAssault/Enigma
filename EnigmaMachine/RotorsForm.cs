using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaMachine
{
    public partial class RotorsForm : Form
    {
        const int m = 5;
        CheckBox[] cbMass = new CheckBox[m];

        

        public RotorsForm()
        {
            InitializeComponent();


            for(int i = 0; i < m; i++)
            {
                cbMass[i] = new CheckBox()
                {
                    Text = "Rotor " + (i + 1).ToString(),
                };

                cbMass[i].Location = new Point(20, 45 + (i * (cbMass[i].Height + 11)));
                gbDefaultRotors.Controls.Add(cbMass[i]);
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rotorPanel1.Visible = true;
            rotorPanel1.BringToFront();
        }

        private void btnX1_Click(object sender, EventArgs e)
        {
            rotorPanel1.Visible = false;
        }

        private void RotorsForm_Load(object sender, EventArgs e)
        {
            rotorPanel1.Visible = false;
            rotorPanel2.Visible = false;
            rotorPanel3.Visible = false;
            rotorPanel4.Visible = false;
            rotorPanel5.Visible = false;
        }

        private void btnX2_Click(object sender, EventArgs e)
        {
            rotorPanel2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rotorPanel2.Visible = true;
            rotorPanel2.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rotorPanel3.Visible = true;
            rotorPanel3.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rotorPanel4.Visible = true;
            rotorPanel4.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rotorPanel5.Visible = true;
            rotorPanel5.BringToFront();
        }

        private void btnX3_Click(object sender, EventArgs e)
        {
            rotorPanel3.Visible = false;
        }

        private void btnX4_Click(object sender, EventArgs e)
        {
            rotorPanel4.Visible = false;
        }

        private void btnX5_Click(object sender, EventArgs e)
        {
            rotorPanel5.Visible = false;
        }
    }
}
