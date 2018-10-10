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

        int[] chosen_rotors = new int[3] { 0,1,2 };

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

                cbMass[i].CheckStateChanged += new System.EventHandler(cb_CheckedChanged);
            }
            Form1 fm1 = new Form1();
            clear_lb();
            for (int i = 0; i < 26; i++)
            {
                lbTextRotor1.Text += (fm1.Mass_of_Rotors[0][i]).ToString();
            }

            for (int i = 0; i < 26; i++)
            {
                lbTextRotor2.Text += (fm1.Mass_of_Rotors[1][i]).ToString();
            }

            for (int i = 0; i < 26; i++)
            {
                lbTextRotor3.Text += (fm1.Mass_of_Rotors[2][i]).ToString();
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //////////////////////////////////////////////////////////////////////
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
        //////////////////////////////////////////////////////////////////////

        
        //////////////////Only 3 checkboxes/////////////////
        
        int available_rotors_counter = 3;

        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            available_rotors_counter--;

            if(available_rotors_counter == 0)
            {
                for(int i = 0; i < m; i++)
                {
                    cbMass[i].Enabled = false;
                }
            }
        }
        //////////////////Only 3 checkboxes/////////////////

        private void btnCancel_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < m; i++)
            {
                
                cbMass[i].Checked = false;
                cbMass[i].Enabled = true;
            }
            available_rotors_counter = 3;

            for(int i = 0; i < 3; i++)
            {
                chosen_rotors[i] = i;
            }
            Form1 fm1 = new Form1();

            for (int i = 0; i < 3; i++)
            {
                for (int t = 0; t < 26; t++)
                {
                    fm1.Mass_of_Rotors[i][t] = fm1.Mass_of_default_rotors[i][t];
                }
            }

            lbSelected1.Text = "Rotor 1";
            lbSelected2.Text = "Rotor 2";
            lbSelected3.Text = "Rotor 3";

            clear_lb();
            for (int i = 0; i < 26; i++)
            {
                lbTextRotor1.Text += (fm1.Mass_of_Rotors[0][i]).ToString();
            }

            for (int i = 0; i < 26; i++)
            {
                lbTextRotor2.Text += (fm1.Mass_of_Rotors[1][i]).ToString();
            }

            for (int i = 0; i < 26; i++)
            {
                lbTextRotor3.Text += (fm1.Mass_of_Rotors[2][i]).ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int j = 0;
            for(int i = 0; i < m; i++)
            {
                if(cbMass[i].Checked)
                {
                    chosen_rotors[j] = i;
                    j++;
                }

            }

            Form1 fm1 = new Form1();

            for(int i = 0; i < 3; i++)
            {
                for(int t = 0; t < 26; t++)
                {
                    fm1.Mass_of_Rotors[i][t] = fm1.Mass_of_default_rotors[chosen_rotors[i]][t]; 

                }
            }

            clear_lb();
            for (int i = 0; i < 26; i++)
            {
                lbTextRotor1.Text += (fm1.Mass_of_Rotors[0][i]).ToString();
            }

            for (int i = 0; i < 26; i++)
            {
                lbTextRotor2.Text += (fm1.Mass_of_Rotors[1][i]).ToString();
            }

            for (int i = 0; i < 26; i++)
            {
                lbTextRotor3.Text += (fm1.Mass_of_Rotors[2][i]).ToString();
            }

            lbSelected1.Text = "Rotor " + (chosen_rotors[0] + 1).ToString();
            lbSelected2.Text = "Rotor " + (chosen_rotors[1] + 1).ToString();
            lbSelected3.Text = "Rotor " + (chosen_rotors[2] + 1).ToString();
        }

        void clear_lb()
        {
            lbTextRotor1.Text = "";
            lbTextRotor2.Text = "";
            lbTextRotor3.Text = "";
        }

    }
}
