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

                cbMass[i].Location = new Point(20, 45 + (i * (cbMass[i].Height + 10)));
                gbDefaultRotors.Controls.Add(cbMass[i]);
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
