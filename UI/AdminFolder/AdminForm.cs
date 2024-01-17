using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.TechLeader;

namespace UI.AdminFolder
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            lblData.Text = DateTime.Now.ToString("D", CultureInfo.GetCultureInfo("pt-br"));
            string primeiraLetraMaiuscula = char.ToUpper(lblData.Text[0]) + lblData.Text.Substring(1);
            lblData.Text = primeiraLetraMaiuscula;
        }

        private void btnAddTechLeader_Click(object sender, EventArgs e)
        {
            var techLeaderAdditionForm = new TechLeaderAdditionForm();
            techLeaderAdditionForm.ShowDialog();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
