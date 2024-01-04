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
            TechLeader = techLeader;
            lblInfos.Text = $"{TechLeader.Position} {TechLeader.Name} | {TechLeader.Specialization}";
        }


        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}
