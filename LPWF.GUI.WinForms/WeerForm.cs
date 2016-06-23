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
    public partial class WeerForm : Form
    {
        WeerController Weer = new WeerController();
        public WeerForm()
        {
            InitializeComponent();
        }

        private void WeerForm_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = Weer.ReturnVerwachting().ToList();
        }
    }
}
