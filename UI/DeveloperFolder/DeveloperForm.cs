using ModelLayer.Users;
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
using UI.Developer;
using RealUsers = ModelLayer.Users;
using UI.Task;

 namespace UI.Developer
{
    public partial class DeveloperForm : Form
    {
        public DeveloperForm(RealUsers.Developer developer)
        {
            InitializeComponent();
            lblData.Text = DateTime.Now.ToString("D", CultureInfo.GetCultureInfo("pt-br"));
            Developer = developer;
            lblInfos.Text = developer.NameSpecializationPosition;
        }

        public RealUsers.Developer Developer { get; }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            var taskAdditionForm = new TaskAdditionForm(Developer);
            taskAdditionForm.ShowDialog();
        }

        private void DeveloperForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
