using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaMachine
{
    public partial class KeyBoard : UserControl
    {
        static int n = MainScreen.n;

        char[] rotor1 = new char[n];
        char[] rotor2 = new char[n];
        char[] rotor3 = new char[n];
        char[] plugboard1 = new char[n];
        char[] plugboard2 = new char[n];
        char[] reflector = new char[n];
        char[] mass = new char[n];

        public static decimal count_2_1;
        public static decimal count_3_2;
        public static decimal position1;
        public static decimal position2;
        public static decimal position3;

        char x;
        string code;

        //static int UpDownR1Value = MainScreen.

        Button[] KeyMass = new Button[n];
        
        public KeyBoard()
        {
            InitializeComponent();

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

            for (int i = 0; i < n; i++)
            {
                KeyMass[i] = new Button()
                {
                    Name = "lbKeyboard" + i.ToString(),
                    Text = Convert.ToChar(i + 65).ToString(),
                    BackColor = Color.White,
                    Font = new Font("Century Gothic", 16, System.Drawing.FontStyle.Bold),
                    FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 1, MouseDownBackColor = Color.Gray, MouseOverBackColor = Color.Bisque, },
                    Width = 50,
                    Height = 50,
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                KeyMass[i].Location = new Point(60 + (i * (KeyMass[i].Width + 40)), 100);
                //KeyMass[i].MouseClick += new MouseEventHandler(Plugboard_MouseClick);
                KeyMass[i].MouseClick += new MouseEventHandler(Keyboard_MouseClick);
                if (i >= 9 && i <= 16)
                {
                    KeyMass[i].Location = new Point(73 + ((i - 9) * (KeyMass[i].Width + 50)), 180);
                }
                if (i >= 17 && i <= 25)
                {
                    KeyMass[i].Location = new Point(60 + ((i - 17) * (KeyMass[i].Width + 40)), 260);
                }
                Controls.Add(KeyMass[i]);
            }

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

        private void Keyboard_MouseClick(object sender, EventArgs e)
        {

            UpDownR1.Value++;

            if (tbInsert.Text.Length != 0)
                for (int i = 0; i < n; i++)
                     if(tbInsert.Text[tbInsert.Text.Length - 1] == plugboard1[i])
                     {
                        x = plugboard2[i];
                        break;
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

            for(int i = 0; i < n; i++)
                if (x == plugboard2[i])
                {
                    x = plugboard1[i];
                    break;
                }

            code += x;

            tbOutput.Text = code;
            }

    }
}
