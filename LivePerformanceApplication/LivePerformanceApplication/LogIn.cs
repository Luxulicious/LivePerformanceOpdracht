using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using LivePerformanceApplication.Classes;
using LivePerformanceApplication.Classes.Controllers;
using LivePerformanceApplication.Classes.SharedModels;
using LivePerformanceApplication.Exceptions;


namespace LivePerformanceApplication
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager.TestConnection();
                MessageBox.Show("Succesfully connected to the database!");
                FormProvider.winkel = new Winkel();
            }
            catch (DatabaseNotConnectedException exc)
            {
                MessageBox.Show("Database failed to connect: \n" + exc.Message);
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxEmail.Text) && !string.IsNullOrEmpty(tbxWachtwoord.Text))
                if (FormProvider.winkel.LogIn(tbxEmail.Text, tbxWachtwoord.Text))
                {

                    this.Hide();
                    FormProvider.Overzicht.Show();
                }
                else
                {
                    MessageBox.Show("Ongeldig e-mail adres en/of wachtwoord.");
                }
        }

        private void btnRegularLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.Overzicht.Show();
        }
    }
}
