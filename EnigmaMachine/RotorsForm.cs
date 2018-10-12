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

        Form1 fm1 = new Form1();

        int[] chosen_rotors = new int[3] { 0,1,2 };

        public RotorsForm()
        {
            InitializeComponent();

            int x = Screen.PrimaryScreen.WorkingArea.Width;
            int y = Screen.PrimaryScreen.WorkingArea.Height;
            ClientSize = new System.Drawing.Size(x, y);

            this.BackColor = Color.FromArgb(255, 94, 87);

            for (int i = 0; i < m; i++)
            {
                cbMass[i] = new CheckBox()
                {
                    Text = "Rotor " + (i + 1).ToString(),
                    Enabled = false,
                };

                cbMass[i].Location = new Point(20, 45 + (i * (cbMass[i].Height + 11)));
                gbDefaultRotors.Controls.Add(cbMass[i]);

                cbMass[i].CheckStateChanged += new System.EventHandler(cb_CheckedChanged);
            }

            clear_lb();
            for (int i = 0; i < 26; i++)
            {
                lbTextRotor1.Text += (Program.Mass_of_buffers[0][i]).ToString();
            }

            for (int i = 0; i < 26; i++)
            {
                lbTextRotor2.Text += (Program.Mass_of_buffers[1][i]).ToString();
            }

            for (int i = 0; i < 26; i++)
            {
                lbTextRotor3.Text += (Program.Mass_of_buffers[2][i]).ToString();
            }

            lbSelected1.Text = "Rotor " + (Program.buffer[0] + 1).ToString();
            lbSelected2.Text = "Rotor " + (Program.buffer[1] + 1).ToString();
            lbSelected3.Text = "Rotor " + (Program.buffer[2] + 1).ToString();

            for(int i = 0; i < 3; i++)
            {
                cbMass[Program.buffer[i]].Checked = true;
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
        bool perm = true;
        int available_rotors_counter = 0;

        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            if(perm)
            {
                CheckBox cb = (CheckBox)sender;

                available_rotors_counter--;

                if (available_rotors_counter == 0)
                {
                    for (int i = 0; i < m; i++)
                    {
                        cbMass[i].Enabled = false;
                    }
                }
            }
            
        }
        //////////////////Only 3 checkboxes/////////////////

        private void btnCancel_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < m; i++)
            {
                cbMass[i].Enabled = true;
                cbMass[i].Checked = false;

            }
            available_rotors_counter = 3;

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

            for(int i = 0; i < 3; i++)
            {
                Program.buffer[i] = chosen_rotors[i];
            }

            for (int i = 0; i < 3; i++)
            {
                Program.buffer[i] = chosen_rotors[i];
            }

            this.Close();

        }

        void clear_lb()
        {
            lbTextRotor1.Text = "";
            lbTextRotor2.Text = "";
            lbTextRotor3.Text = "";
        }

        private void btnCancel_MouseDown(object sender, MouseEventArgs e)
        {
            perm = false;
        }

        private void btnCancel_MouseUp(object sender, MouseEventArgs e)
        {
            perm = true;
        }
    }
}
