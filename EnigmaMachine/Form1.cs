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
    public partial class Form1 : Form
    {

        const int n = 26;

        public char[][] Mass_of_Rotors = new char[][]
        {
            new char[n],
            new char[n],
            new char[n],
        };


        public char[][] Mass_of_default_rotors = new char[][]
        {
            new char[n] { 'P','E','Z','U','O','H','X','S','C','V','F','M','T','B','G','L','R','I','N','Q','J','W','A','Y','D','K' },
            new char[n] { 'Z','O','U','E','S','Y','D','K','F','W','P','C','I','Q','X','H','M','V','B','L','G','N','J','R','A','T' },
            new char[n] { 'E','H','R','V','X','G','A','O','B','Q','U','S','I','M','Z','F','L','Y','N','W','K','T','P','D','J','C' },
            new char[n] { 'E','S','O','V','P','Z','J','A','Y','Q','U','I','R','H','X','L','N','F','T','G','K','D','C','M','W','B' },
            new char[n] { 'V','Z','B','R','G','I','T','Y','U','P','S','D','N','H','L','X','A','W','M','J','Q','O','F','E','C','K' },
        };

       static  char[] plugboard1 = new char[n];
       static  char[] plugboard2 = new char[n];
       static char[] reflector = new char[n] { 'Q','Y','H','O','G','N','E','C','V','P','U','Z','T','F','D','J','A','X','W','M','K','I','S','R','B','L' };
        char[] mass = new char[n];

        decimal count_2_1;
        decimal count_3_2;
        decimal position1;
        decimal position2;
        decimal position3;
        char x;
        string code;

        Label[] lbMass = new Label[n];
        Label[] BalbMass = new Label[n];
        Button[] KeyMass = new Button[n];

        public int[] chosen_rotorsForm1 = new int[3];

        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(136, 83, 0);
            KeyBoardPanel.BackColor = Color.FromArgb(207, 207, 207); 
            PlugboardPanel.BackColor = Color.FromArgb(31, 100, 88); 


            /////////////////KeyMass//////////////////
            for (int i = 0; i < n; i++)
            {
                KeyMass[i] = new Button()
                {
                    Name = "btnKeyboard" + i.ToString(),
                    Text = Convert.ToChar(i + 65).ToString(),
                    BackColor = Color.White,
                    FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                    Font = new Font("Microsoft Sans Serif", 16, System.Drawing.FontStyle.Bold),
                    FlatAppearance = { BorderSize = 1, MouseOverBackColor = Color.DarkKhaki },
                    Width = 50,
                    Height = 50,
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                KeyMass[i].Location = new Point(60 + (i * (KeyMass[i].Width + 40)), 55);
                KeyMass[i].MouseDown += new MouseEventHandler(Keyboard_MouseDown);
                KeyMass[i].MouseUp += new MouseEventHandler(Keyboard_MouseUp);
                if (i >= 9 && i <= 16)
                {
                    KeyMass[i].Location = new Point(73 + ((i - 9) * (KeyMass[i].Width + 50)), 135);
                }
                if (i >= 17 && i <= 25)
                {
                    KeyMass[i].Location = new Point(60 + ((i - 17) * (KeyMass[i].Width + 40)), 215);
                }
                KeyBoardPanel.Controls.Add(KeyMass[i]);
            }

            /////////////////KeyMass//////////////////

            ///////////////lbMass//////////////////
            for(int i = 0; i < n; i++)
            {
                lbMass[i] = new Label()
                {
                    Name = "lbPlugboard" + i.ToString(),
                    Text = Convert.ToChar(i + 65).ToString(),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Font = new Font("Microsoft Sans Serif", 16, System.Drawing.FontStyle.Bold),
                    Width = 50,
                    Height = 50,
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                lbMass[i].Location = new Point(60 + (i * (lbMass[i].Width + 40)), 90);
                lbMass[i].MouseClick += new MouseEventHandler(Plugboard_MouseClick);
                lbMass[i].MouseEnter += new System.EventHandler(Plugboard_MouseEnter);
                lbMass[i].MouseLeave += new System.EventHandler(Plugboard_MouseLeave);
                if (i >= 9 && i <= 16)
                {
                    lbMass[i].Location = new Point(73 + ((i - 9) * (lbMass[i].Width + 50)), 170);
                }
                if (i >= 17 && i <= 25)
                {
                    lbMass[i].Location = new Point(60 + ((i - 17) * (lbMass[i].Width + 40)), 250);
                }
                PlugboardPanel.Controls.Add(lbMass[i]);
            }
            ///////////////lbMass//////////////////

            //////////////BalbsMass////////////////

            for (int i = 0; i < n; i++)
            {
                BalbMass[i] = new Label()
                {
                    Name = "lbBalb" + i.ToString(),
                    Text = Convert.ToChar(i + 65).ToString(),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Font = new Font("Microsoft Sans Serif", 16, System.Drawing.FontStyle.Bold),
                    Width = 50,
                    Height = 50,
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                BalbMass[i].Location = new Point(60 + (i * (BalbMass[i].Width + 40)), 230);
                
                if (i >= 9 && i <= 16)
                {
                    BalbMass[i].Location = new Point(73 + ((i - 9) * (BalbMass[i].Width + 50)), 310);
                }
                if (i >= 17 && i <= 25)
                {
                    BalbMass[i].Location = new Point(60 + ((i - 17) * (BalbMass[i].Width + 40)), 390);
                }
                Controls.Add(BalbMass[i]);
            }
            //////////////BalbsMass////////////////

            UpDownR1.Value = 1;
            UpDownR2.Value = 1;
            UpDownR3.Value = 1;

            ///////////////Default rotors Settings//////////
            for(int i = 0; i < n; i++)
            {
                Mass_of_Rotors[0][i] = Mass_of_default_rotors[0][i];
                Mass_of_Rotors[1][i] = Mass_of_default_rotors[1][i];
                Mass_of_Rotors[2][i] = Mass_of_default_rotors[2][i];
            }
            ///////////////Default rotors Settings//////////

            for (int i = 0; i < n; i++)
            {
                plugboard1[i] = Convert.ToChar(i + 65);
                plugboard2[i] = Convert.ToChar(i + 65);
                mass[i] = Convert.ToChar(i + 65);
            }

            lbSave1.Text = 1.ToString();
            lbSave2.Text = 1.ToString();
            lbSave3.Text = 1.ToString();
        }

        void countmaker()
        {
            if (position2 - position1 >= 0) count_2_1 = position2 - position1;
            else
                count_2_1 = n - position1 + position2;

            if (position3 - position2 >= 0) count_3_2 = position3 - position2;
            else
                count_3_2 = n - position2 + position3;
        }

        private void UpDownR1_ValueChanged(object sender, EventArgs e)
        {
            if (UpDownR1.Value == 27)
            {
                UpDownR1.Value = 1;
                UpDownR2.Value++;
            }
            if (UpDownR1.Value == 0) UpDownR1.Value = 26;
            position1 = UpDownR1.Value - 1;
            countmaker();
        }

        private void UpDownR2_ValueChanged(object sender, EventArgs e)
        {
            if (UpDownR2.Value == 27)
            {
                UpDownR2.Value = 1;
                UpDownR3.Value++;
            }
            if (UpDownR2.Value == 0) UpDownR2.Value = 26;
            position2 = UpDownR2.Value - 1;

        }

        private void UpDownR3_ValueChanged(object sender, EventArgs e)
        {
            if (UpDownR3.Value == 27) UpDownR3.Value = 1;
            if (UpDownR3.Value == 0) UpDownR3.Value = 26;
            position3 = UpDownR3.Value - 1;

        }

        bool perm_to_connect = false;
        int pairs_counter = 10;

        char lb1Text;

        int colorchanger = 0;
        const int color_count = 10;

        int[] r = new int[color_count] {0,   0,   255, 0,   0,   128,  0,   255, 153, 255};
        int[] g = new int[color_count] {255, 153, 0,   0,   255, 128,  153, 0,  77,  204};
        int[] b = new int[color_count] {255, 204, 255, 255, 153, 128,  77,  0,  0,   0};

        void Plugboard_MouseClick(Object sender, EventArgs e)
        {
            if(!perm_to_connect && (sender as Label).BackColor == Color.White && pairs_counter != 0)
            {
                Label lb1 = (Label)sender;
                lb1.BackColor = Color.FromArgb(r[colorchanger], g[colorchanger], b[colorchanger]);
                perm_to_connect = true;
                lb1Text = Convert.ToChar(lb1.Text);

            } else if((sender as Label).BackColor == Color.White && pairs_counter != 0)
            {
                Label lb2 = (Label)sender;
                Label lb1 = (Label)sender;
                lb2.BackColor = Color.FromArgb(r[colorchanger], g[colorchanger], b[colorchanger]);
                perm_to_connect = false;
                pairs_counter--;
                lbNumericPairCounter.Text = pairs_counter.ToString();

                int index1 = (int)lb1Text - 65;
                int index2 = (int)(Convert.ToChar(lb2.Text)) - 65;

                char t = plugboard2[index2];
                plugboard2[index2] = plugboard1[index1];
                plugboard2[index1] = t;

                colorchanger++;
            }


        }

        int light_to_down;
        private void Keyboard_MouseDown(object sender, EventArgs e)
        {

            UpDownR1.Value++;

            Button btn = (Button)sender;
            x = Convert.ToChar(btn.Text);
            tbInsert.Text += x.ToString();
            tbInsert.SelectionStart = tbInsert.Text.Length;

            for (int i = 0; i < n; i++)
            {
                if(x == plugboard1[i])
                {
                    x = plugboard2[i];
                    break;
                }
            }

            //////////////////ROTOR 1///////////////////
            for (int i = 0; i < n; i++)
                if (x == mass[i])
                {
                    x = Convert.ToChar((i + Convert.ToInt16(position1)) % 26 + 65);
                    x = Mass_of_Rotors[0][(i + Convert.ToInt16(position1)) % 26];
                    break;
                }
            //////////////////ROTOR 1///////////////////

            //////////////////ROTOR 2///////////////////
            for (int i = 0; i < n; i++)
                if (x == Convert.ToChar(i + 65))
                {
                    x = Convert.ToChar((i + Convert.ToInt16(count_2_1)) % 26 + 65);
                    x = Mass_of_Rotors[1][(i + Convert.ToInt16(count_2_1)) % 26];
                    break;
                }
            //////////////////ROTOR 2///////////////////

            //////////////////ROTOR 3///////////////////
            for (int i = 0; i < n; i++)
                if (x == Convert.ToChar(i + 65))
                {
                    x = Convert.ToChar((i + Convert.ToInt16(count_3_2)) % 26 + 65);
                    x = Mass_of_Rotors[2][(i + Convert.ToInt16(count_3_2)) % 26];
                    break;
                }
            //////////////////ROTOR 3///////////////////

            /////////////////REFLECTOR ACTION///////////
            for (int i = 0; i < n; i++)
                if (Convert.ToChar(i + 65) == x)
                {

                    x = Convert.ToChar((i + n - Convert.ToInt16(position3)) % 26 + 65);
                    x = reflector[(i + n - Convert.ToInt16(position3)) % 26];
                    break;
                }


            for (int i = 0; i < n; i++)
                if (Convert.ToChar(i + 65) == x)
                {
                    x = Convert.ToChar((i + Convert.ToInt16(position3)) % 26 + 65);
                    break;
                }
            /////////////////REFLECTOR ACTION///////////

            /////////////////////ROTOR 3 BACK////////////////////
            for (int i = 0; i < n; i++)
                if (Mass_of_Rotors[2][i] == x)
                {
                    x = Convert.ToChar(i + 65);

                    x = Convert.ToChar((i + n - Convert.ToInt16(count_3_2)) % 26 + 65);
                    break;
                }


            /////////////////////ROTOR 3 BACK////////////////////

            /////////////////////ROTOR 2 BACK////////////////////
            for (int i = 0; i < n; i++)
                if (Mass_of_Rotors[1][i] == x)
                {
                    x = Convert.ToChar(i + 65);

                    x = Convert.ToChar((i + n - Convert.ToInt16(count_2_1)) % 26 + 65);
                    break;
                }

            /////////////////////ROTOR 2 BACK////////////////////
            for (int i = 0; i < n; i++)
                if (Mass_of_Rotors[0][i] == x)
                {
                    x = Convert.ToChar(i + 65);

                    x = Convert.ToChar((i + n - Convert.ToInt16(position1)) % 26 + 65);
                    break;
                }

            /////////////////////ROTOR 2 BACK////////////////////

            for (int i = 0; i < n; i++)
                if (x == plugboard2[i])
                {
                    x = plugboard1[i];
                    break;
                }

            code += x;

            tbOutput.Text = code;
            tbOutput.SelectionStart = tbOutput.Text.Length;

            //////////Balb lights up//////////////
            for (int i = 0; i < n; i++)
            {
                if(x.ToString() == BalbMass[i].Text)
                {
                    light_to_down = i;
                    BalbMass[i].BackColor = Color.Yellow;
                }
            }

        }
        ///////////balb goes down////////////
        private void Keyboard_MouseUp(object sender, EventArgs e)
        {
            BalbMass[light_to_down].BackColor = Color.White;
        }

        private void Plugboard_MouseEnter(object sender, EventArgs e)
        {
            Label balb = (Label)sender;
            balb.Size = new System.Drawing.Size(52, 52);
        }

        private void Plugboard_MouseLeave(object sender, EventArgs e)
        {
            Label balb = (Label)sender;
            balb.Size = new System.Drawing.Size(50, 50);
        }

        private void btnUnplug_Click(object sender, EventArgs e)
        {
            pairs_counter = 10;
            lbNumericPairCounter.Text = pairs_counter.ToString();
            for (int i = 0; i < n; i++)
            {
                plugboard2[i] = plugboard1[i];
                lbMass[i].BackColor = Color.White;
            }
            perm_to_connect = false;
            colorchanger = 0;

        }
    

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyBoardPanel.BringToFront();
            PlugboardPanel.Visible = false;
        }


        private void btnShowPlugboard_Click(object sender, EventArgs e)
        {
            PlugboardPanel.Visible = true;
            PlugboardPanel.BringToFront();
        }

        

        private void btnHide_Click(object sender, EventArgs e)
        {
            PlugboardPanel.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UpDownR1.Value = 1;
            UpDownR2.Value = 1;
            UpDownR3.Value = 1;
        }

        

        private void btnClean_Click(object sender, EventArgs e)
        {
            tbInsert.Text = "";
            tbOutput.Text = "";
            code = "";
        }


        private void btnRotorsSettings_Click(object sender, EventArgs e)
        {
            RotorsForm rf = new RotorsForm();
            rf.ShowDialog();
            for(int i = 0; i < 3; i++)
            {
                chosen_rotorsForm1[i] = Program.buffer[i];
            }         
            
            for(int i = 0; i < 3; i++)
            {
                for(int t = 0; t < n; t++)
                {
                    Mass_of_Rotors[i][t] = Mass_of_default_rotors[chosen_rotorsForm1[i]][t];
                    Program.Mass_of_buffers[i][t] = Mass_of_default_rotors[chosen_rotorsForm1[i]][t];
                }
            }

        }

        decimal x1 = 1, x2 = 1, x3 = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            MainFormHelp MfHelp = new MainFormHelp();
            MfHelp.ShowDialog();
        }

        private void btnSavePositions_Click(object sender, EventArgs e)
        {
            lbSave1.Text = UpDownR1.Value.ToString();
            lbSave2.Text = UpDownR2.Value.ToString();
            lbSave3.Text = UpDownR3.Value.ToString();
            x1 = UpDownR1.Value;
            x2 = UpDownR2.Value;
            x3 = UpDownR3.Value;
        }
        
        private void btnSetPositions_Click(object sender, EventArgs e)
        {
            UpDownR1.Value = x1;
            UpDownR2.Value = x2;
            UpDownR3.Value = x3;
        }
    }
}
