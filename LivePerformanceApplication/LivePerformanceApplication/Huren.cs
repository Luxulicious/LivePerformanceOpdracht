using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LivePerformanceApplication.Classes;
using LivePerformanceApplication.Classes.Controllers;
using LivePerformanceApplication.Classes.SharedModels;

namespace LivePerformanceApplication
{
    public partial class Huren : Form
    {
        HurenController hurenController = new HurenController();
        public Huren()
        {
            InitializeComponent();

        }

        private void btnBevestigen_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxNaam.Text) &&
                 !string.IsNullOrEmpty(tbxEmail.Text) /*&& dtpTot.Value < DateTime.Today && dtpVan.Value < DateTime.Today*/)
            {
                var boten = new List<IBoot>();
                foreach (var boot in clbxBoten.CheckedItems)
                {
                    boten.Add(boot as IBoot);
                }
                var meren = new List<Meer>();
                foreach (var meer in clbxMeren.CheckedItems)
                {
                    meren.Add(meer as Meer);
                }
                var artikelen = new List<Artikel>();
                foreach (var artikel in clbxArtikelen.CheckedItems)
                {
                    artikelen.Add(artikel as Artikel);
                }
                if (hurenController.AddHuurcontract(tbxEmail.Text, tbxNaam.Text,
                    new Huurcontract(0, dtpVan.Value, dtpTot.Value, boten, meren, artikelen)))
                {
                    MessageBox.Show("Huurcontract toegevoegd.");
                }
                else
                {
                    MessageBox.Show("Huurcontract geweigerd controleer of u alle nodige velden heeft ingevuld");
                }
            }


        }
    }
}
