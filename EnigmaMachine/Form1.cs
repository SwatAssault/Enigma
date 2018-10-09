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
        char[] rotor1 = new char[n];
        char[] rotor2 = new char[n];
        char[] rotor3 = new char[n];
        char[] plugboard1 = new char[n];
        char[] plugboard2 = new char[n];
        char[] reflector = new char[n];
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

        public Form1()
        {
            InitializeComponent();

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

            for (int i = 0; i < n; i++)
            {
                plugboard1[i] = Convert.ToChar(i + 65);
                plugboard2[i] = Convert.ToChar(i + 65);
                mass[i] = Convert.ToChar(i + 65);
            }

            rotor1[0] = 'E';
            rotor1[1] = 'K';
            rotor1[2] = 'M';
            rotor1[3] = 'F';
            rotor1[4] = 'L';
            rotor1[5] = 'G';
            rotor1[6] = 'D';
            rotor1[7] = 'Q';
            rotor1[8] = 'V';
            rotor1[9] = 'Z';
            rotor1[10] = 'N';
            rotor1[11] = 'T';
            rotor1[12] = 'O';
            rotor1[13] = 'W';
            rotor1[14] = 'Y';
            rotor1[15] = 'H';
            rotor1[16] = 'X';
            rotor1[17] = 'U';
            rotor1[18] = 'S';
            rotor1[19] = 'P';
            rotor1[20] = 'A';
            rotor1[21] = 'I';
            rotor1[22] = 'B';
            rotor1[23] = 'R';
            rotor1[24] = 'C';
            rotor1[25] = 'J';

            rotor2[0] = 'A';
            rotor2[1] = 'J';
            rotor2[2] = 'D';
            rotor2[3] = 'K';
            rotor2[4] = 'S';
            rotor2[5] = 'I';
            rotor2[6] = 'R';
            rotor2[7] = 'U';
            rotor2[8] = 'X';
            rotor2[9] = 'B';
            rotor2[10] = 'L';
            rotor2[11] = 'H';
            rotor2[12] = 'W';
            rotor2[13] = 'T';
            rotor2[14] = 'M';
            rotor2[15] = 'C';
            rotor2[16] = 'Q';
            rotor2[17] = 'G';
            rotor2[18] = 'Z';
            rotor2[19] = 'N';
            rotor2[20] = 'P';
            rotor2[21] = 'Y';
            rotor2[22] = 'F';
            rotor2[23] = 'V';
            rotor2[24] = 'O';
            rotor2[25] = 'E';

            rotor3[0] = 'B';
            rotor3[1] = 'D';
            rotor3[2] = 'F';
            rotor3[3] = 'H';
            rotor3[4] = 'J';
            rotor3[5] = 'L';
            rotor3[6] = 'C';
            rotor3[7] = 'P';
            rotor3[8] = 'R';
            rotor3[9] = 'T';
            rotor3[10] = 'X';
            rotor3[11] = 'V';
            rotor3[12] = 'Z';
            rotor3[13] = 'N';
            rotor3[14] = 'Y';
            rotor3[15] = 'E';
            rotor3[16] = 'I';
            rotor3[17] = 'W';
            rotor3[18] = 'G';
            rotor3[19] = 'A';
            rotor3[20] = 'K';
            rotor3[21] = 'M';
            rotor3[22] = 'U';
            rotor3[23] = 'S';
            rotor3[24] = 'Q';
            rotor3[25] = 'O';

            reflector[0] = 'Y';
            reflector[1] = 'R';
            reflector[2] = 'U';
            reflector[3] = 'H';
            reflector[4] = 'Q';
            reflector[5] = 'S';
            reflector[6] = 'L';
            reflector[7] = 'D';
            reflector[8] = 'P';
            reflector[9] = 'X';
            reflector[10] = 'N';
            reflector[11] = 'G';
            reflector[12] = 'O';
            reflector[13] = 'K';
            reflector[14] = 'M';
            reflector[15] = 'I';
            reflector[16] = 'E';
            reflector[17] = 'B';
            reflector[18] = 'F';
            reflector[19] = 'Z';
            reflector[20] = 'C';
            reflector[21] = 'W';
            reflector[22] = 'V';
            reflector[23] = 'J';
            reflector[24] = 'A';
            reflector[25] = 'T';

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
            lbInsert.Text += x.ToString();

            for(int i = 0; i < n; i++)
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
                    x = rotor1[(i + Convert.ToInt16(position1)) % 26];
                    break;
                }
            //////////////////ROTOR 1///////////////////

            //////////////////ROTOR 2///////////////////
            for (int i = 0; i < n; i++)
                if (x == Convert.ToChar(i + 65))
                {
                    x = Convert.ToChar((i + Convert.ToInt16(count_2_1)) % 26 + 65);
                    x = rotor2[(i + Convert.ToInt16(count_2_1)) % 26];
                    break;
                }
            //////////////////ROTOR 2///////////////////

            //////////////////ROTOR 3///////////////////
            for (int i = 0; i < n; i++)
                if (x == Convert.ToChar(i + 65))
                {
                    x = Convert.ToChar((i + Convert.ToInt16(count_3_2)) % 26 + 65);
                    x = rotor3[(i + Convert.ToInt16(count_3_2)) % 26];
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
                if (rotor3[i] == x)
                {
                    x = Convert.ToChar(i + 65);

                    x = Convert.ToChar((i + n - Convert.ToInt16(count_3_2)) % 26 + 65);
                    break;
                }


            /////////////////////ROTOR 3 BACK////////////////////

            /////////////////////ROTOR 2 BACK////////////////////
            for (int i = 0; i < n; i++)
                if (rotor2[i] == x)
                {
                    x = Convert.ToChar(i + 65);

                    x = Convert.ToChar((i + n - Convert.ToInt16(count_2_1)) % 26 + 65);
                    break;
                }

            /////////////////////ROTOR 2 BACK////////////////////
            for (int i = 0; i < n; i++)
                if (rotor1[i] == x)
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

            lbOutput.Text = code;

            //////////Balb lights up//////////////
            for(int i = 0; i < n; i++)
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
            lbInsert.Text = "";
            lbOutput.Text = "";
            code = "";
        }

        decimal x1 = 1, x2 = 1, x3 = 1;
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
