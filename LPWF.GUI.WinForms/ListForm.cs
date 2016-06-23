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
    public partial class ListForm : Form
    {
        HuurcontractController HuurControl = new HuurcontractController();

        public ListForm()
        {
            InitializeComponent();
        }

        private void List_Load(object sender, EventArgs e)
        {
            LbHuur.DataSource = HuurControl.GetAll();
        }
    }
}
