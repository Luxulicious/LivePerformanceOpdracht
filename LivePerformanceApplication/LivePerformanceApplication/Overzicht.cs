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
using LivePerformanceApplication.Classes.SharedModels;

namespace LivePerformanceApplication
{
    public partial class Overzicht : Form
    {
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
            if (DatabaseManager.AddMeer(tbxNaam.Text, Convert.ToDouble(nudPrijs.Value), boten))
            {
                MessageBox.Show("Vaargebied toegevoegd.");
            }
            else
            {
                MessageBox.Show("Vaargebied kon niet worden toegevoegd");
            }
        }


    }
}
