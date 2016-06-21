using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using LivePerformanceApplication.Classes;
using LivePerformanceApplication.Exceptions;


namespace LivePerformanceApplication
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager.TestConnection();
                MessageBox.Show("Succesfully connected to the database!");
            }
            catch (DatabaseNotConnectedException exc)
            {
                MessageBox.Show("Database failed to connect: \n" + exc.Message);
            }
        }
    }
}
