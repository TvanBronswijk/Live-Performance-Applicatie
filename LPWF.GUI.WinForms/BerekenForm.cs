using LPWF.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPWF.GUI.WinForms
{
    public partial class BerekenForm : Form
    {
        VerhuurController huurcontrol = new VerhuurController();

        public BerekenForm()
        {
            InitializeComponent();
        }

        private void BtnBerekenen_Click(object sender, EventArgs e)
        {
            if(NudBoten.Value + NudMotor.Value < 1 || NudBedrag.Value < (decimal).01)
            {
                MessageBox.Show("Er missen bepaalde onderdelen.");
            }
            else
            {
                MessageBox.Show("Het aantal meren zijn: " + Math.Floor(huurcontrol.Berekenen((int)NudBoten.Value, (int)NudMotor.Value, (int)NudProducten.Value, (int)NudZeeen.Value, (double)NudBedrag.Value)).ToString());
            }
        }
    }
}
