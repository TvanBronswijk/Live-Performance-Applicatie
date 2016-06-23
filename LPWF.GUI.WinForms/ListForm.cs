using LPWF.Controller;
using LPWF.Model;
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
    public partial class ListForm : Form
    {
        HuurcontractController HuurControl = new HuurcontractController();
        InputOutputController outputControl = new InputOutputController();

        public ListForm()
        {
            InitializeComponent();
        }

        private void List_Load(object sender, EventArgs e)
        {
            LbHuur.DataSource = HuurControl.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputControl.WriteToTXT((Huurcontract)LbHuur.SelectedItem);
            MessageBox.Show("Output.txt is naar de schijf geschreven.");
        }
    }
}
