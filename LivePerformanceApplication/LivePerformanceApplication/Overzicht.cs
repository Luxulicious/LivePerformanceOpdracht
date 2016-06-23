using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        /// <summary>
        /// Wordt refresh in aangeroepen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Overzicht_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        /// <summary>
        /// Ververst de pagina waardes, zoals de lijsten en de tekstvelden
        /// </summary>
        private void Refresh()
        {
            //GetBoten
            foreach (var boot in DatabaseManager.GetBoten())
            {
                clbxBoten.Items.Add(boot);
            }
        }

        /// <summary>
        /// Voegt een meer toe op aanklik
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddMeer_Click(object sender, EventArgs e)
        {
            Refresh();
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

        /// <summary>
        /// Voegt een huurcontract toe op aanklik
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddHuurcontract_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.Huren.Show();
        }

        /// <summary>
        /// Past de velden automatisch aan afhankelijk van wat er geselecteerd is.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void btnExporteer_Click(object sender, EventArgs e)
        {
            var filepath = Path.Combine(Directory.GetCurrentDirectory(), @"huurcontracten.txt");
            try
            {
                if (!File.Exists(filepath))
                {
                    using (StreamWriter sw = File.CreateText(filepath))
                    {
                        foreach (var huurcontract in overzichtController.GetHuurcontracten())
                        {
                            sw.WriteLine(huurcontract);
                        }

                    }
                }
                else
                {
                    File.WriteAllText(filepath, String.Empty);
                    using (StreamWriter sw = File.AppendText(filepath))
                    {
                        foreach (var huurcontract in overzichtController.GetHuurcontracten())
                        {
                            sw.WriteLine(huurcontract);
                        }
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Kon het bestand om huurcontracten naar te schrijven niet vinden");
            }
        }
    }
}
