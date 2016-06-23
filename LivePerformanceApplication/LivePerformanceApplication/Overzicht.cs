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
    public partial class Overzicht : Form
    {
        OverzichtController overzichtController = new OverzichtController();
        public Overzicht()
        {
            InitializeComponent();
        }

        private void Overzicht_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Refresh()
        {
            //GetBoten
            foreach (var boot in DatabaseManager.GetBoten())
            {
                clbxBoten.Items.Add(boot);
            }
        }

        private void btnAddMeer_Click(object sender, EventArgs e)
        {
            var boten = new List<IBoot>();
            foreach (var boot in clbxBoten.CheckedItems)
            {
                boten.Add(boot as IBoot);
            }
            if (overzichtController.AddMeer(tbxNaam.Text, Convert.ToDouble(nudPrijs.Value), boten))
            {
                MessageBox.Show("Vaargebied toegevoegd.");
            }
            else
            {
                MessageBox.Show("Vaargebied kon niet worden toegevoegd");
            }
        }

        private void btnAddHuurcontract_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.Huren.Show();
        }

        private void clbxBoten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbxBoten.SelectedItem != null)
            {
                lblActieRadius.Show();
                nudTankInhoud.Show();
                if (clbxBoten.SelectedItem is Motorboot)
                    tbxNaam.Text = ((Motorboot)clbxBoten.SelectedItem).Naam;
                nudPrijs.Value = Convert.ToDecimal(((Motorboot)clbxBoten.SelectedItem).Prijs);
                nudTankInhoud.Value = Convert.ToDecimal(((Motorboot)clbxBoten.SelectedItem).Tankinhoud);
                lblActieRadius.Text = "Actieradius: " +
                                      ((Motorboot)clbxBoten.SelectedItem).BerekenActieRadius(
                                          ((Motorboot)clbxBoten.SelectedItem).Tankinhoud);
            }
            else if (clbxBoten.SelectedItem is Spierboot)
            {
                tbxNaam.Text = ((Motorboot)clbxBoten.SelectedItem).Naam;
                nudPrijs.Value = Convert.ToDecimal(((Motorboot)clbxBoten.SelectedItem).Prijs);
                lblActieRadius.Hide();
                nudTankInhoud.Hide();
            }
            else
            {
                lblActieRadius.Hide();
                nudTankInhoud.Hide();
            }
        }
    }
}
