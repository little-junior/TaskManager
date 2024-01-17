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
using UI.Task;
using UI.TechLeader;
using UI.TechLeaderFolder;
using RealUsers = ModelLayer.Users;

namespace UI
{
    public partial class TechLeaderForm : Form
    {
        public RealUsers.TechLeader TechLeader { get; }

        public TechLeaderForm(RealUsers.TechLeader techLeader)
        {
            InitializeComponent();
            lblData.Text = DateTime.Now.ToString("D", CultureInfo.GetCultureInfo("pt-br"));
            string primeiraLetraMaiuscula = char.ToUpper(lblData.Text[0]) + lblData.Text.Substring(1);
            lblData.Text = primeiraLetraMaiuscula;
            TechLeader = techLeader;
            lblInfos.Text = techLeader.NameSpecializationPosition;
        }




        private void btnAddDev_Click(object sender, EventArgs e)
        {
            var developerAdditionForm = new DeveloperAdditionForm();
            developerAdditionForm.ShowDialog();
        }

        private void TechLeaderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void btnAddTask_Click(object sender, EventArgs e)
        {
            var taskAdditionForm = new TaskAdditionForm(TechLeader);
            taskAdditionForm.ShowDialog();
        }

        private void btnGerTasks_Click(object sender, EventArgs e)
        {
            var techLeaderTaskViewerForm = new TechLeaderTaskViewerForm();
            techLeaderTaskViewerForm.ShowDialog();
        }
    }
}
