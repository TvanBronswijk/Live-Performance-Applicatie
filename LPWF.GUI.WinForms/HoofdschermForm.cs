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
    public partial class HoofdschermForm : Form
    {
        BijkomendProductController BproductControl = new BijkomendProductController();
        BootController BootControl = new BootController();
        VerhuurController HuurControl = new VerhuurController();

        Huurcontract NieuwHuur;

        public HoofdschermForm()
        {
            InitializeComponent();
        }

        private void HoofdschermForm_Load(object sender, EventArgs e)
        {
            CbProducten.DataSource = BproductControl.GetAll();
            CbBoten.DataSource = BootControl.GetAll();
        }

        private void HuurRefresh()
        {
            LbBestelling.Items.Clear();

            LbBestelling.Items.Add("Door: " + NieuwHuur.Persoon[0]);
            LbBestelling.Items.Add("van: " + NieuwHuur.Van.ToShortDateString());
            LbBestelling.Items.Add("tot: " + NieuwHuur.Tot.ToShortDateString());

            foreach (Boot b in NieuwHuur.Boten)
            {
                LbBestelling.Items.Add(b);
            }
            foreach (BijkomendProduct p in NieuwHuur.Producten)
            {
                LbBestelling.Items.Add(p.Aantal.ToString() + "x " + p.Naam);
            }
            foreach (string s in NieuwHuur.Zee)
            {
                LbBestelling.Items.Add(s);
            }
            LbBestelling.Items.Add("Meren: " + NieuwHuur.Meer);
        }

        private void BtnPeriode_Click(object sender, EventArgs e)
        {

            if (TbEmail.Text == "" || TbNaam.Text == "")
            {
                MessageBox.Show("Naam of Email veld is leeg.");
            }else
            {
                NieuwHuur = new Huurcontract();
                NieuwHuur.Van = DtpVan.Value;
                NieuwHuur.Tot = DtpTot.Value;
                NieuwHuur.Persoon[0] = TbNaam.Text;
                NieuwHuur.Persoon[1] = TbEmail.Text;
                GbHuidigeBestelling.Enabled = true;
                BtnBootToevoegen.Enabled = true;
                BtnProductToevoegen.Enabled = true;
                BtnPeriode.Enabled = false;
                BtnMeren.Enabled = true;

                HuurRefresh();
            }
        }

        private void BtnBootToevoegen_Click(object sender, EventArgs e)
        {
            if (!NieuwHuur.Boten.Contains((Boot)CbBoten.SelectedItem))
            {
                if(CbBoten.SelectedItem is MotorBoot)
                {
                    NieuwHuur.Boten.Add((MotorBoot)CbBoten.SelectedItem);
                    BtnZeeToevoegen.Enabled = true;
                }
                else
                {
                    NieuwHuur.Boten.Add((Boot)CbBoten.SelectedItem);
                }        
            }
            HuurRefresh();
        }

        private void BtnListContract_Click(object sender, EventArgs e)
        {
            ListForm form = new ListForm();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!NieuwHuur.Zee.Contains(CbZee.Text))
            {
                NieuwHuur.Zee.Add(CbZee.Text);
            }
            HuurRefresh();
        }

        private void BtnProductToevoegen_Click(object sender, EventArgs e)
        {
            if (!NieuwHuur.Producten.Contains((BijkomendProduct)CbProducten.SelectedItem))
            {
                BijkomendProduct BProduct = (BijkomendProduct)CbProducten.SelectedItem;
                BProduct.Aantal = (int)NudProducten.Value;
                NieuwHuur.Producten.Add(BProduct);
            }
            HuurRefresh();
        }

        private void BtnLegen_Click(object sender, EventArgs e)
        {
            EmptyNew();
        }

        private void EmptyNew()
        {
            NieuwHuur = new Huurcontract();

            GbHuidigeBestelling.Enabled = false;
            BtnBootToevoegen.Enabled = false;
            BtnProductToevoegen.Enabled = false;
            BtnZeeToevoegen.Enabled = false;
            BtnMeren.Enabled = false;
            BtnPeriode.Enabled = true;

            HuurRefresh();
        }

        private void BtnMeren_Click(object sender, EventArgs e)
        {
            NieuwHuur.Meer = (int)NudMeren.Value;

            HuurRefresh();
        }

        private void BtnVerhuren_Click(object sender, EventArgs e)
        {
            if(NieuwHuur.Boten.Count < 1 || NieuwHuur.Meer < 1)
            {
                MessageBox.Show("Bepaalde onderdelen missen nog.");
            }
            else
            {
                HuurControl.Verhuren(NieuwHuur);

                EmptyNew();
            }

        }

        private void BtnBerekenen_Click(object sender, EventArgs e)
        {
            BerekenForm Ber = new BerekenForm();
            Ber.Show();
        }

        private void BtnWeer_Click(object sender, EventArgs e)
        {
            WeerForm Weer = new WeerForm();
            Weer.Show();
        }
    }
}
