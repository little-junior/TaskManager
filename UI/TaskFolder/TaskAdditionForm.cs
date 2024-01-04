using RealTask = ModelLayer.Task;
using RealUsers = ModelLayer.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.Services;
using DataLayer.DataAccess;
using DataLayer.Services.Interfaces;
using System.Collections;

namespace UI.Task
{
    public partial class TaskAdditionForm : Form
    {


        public TaskAdditionForm(RealUsers.User user)
        {
            InitializeComponent();

            taskService = new TaskService(new TaskDataManagement());
            developerService = new DeveloperService(new DeveloperDataManagement());
            techLeaderService = new TechLeaderService(new TechLeaderDataManagement());

            ArrayList developers= new ArrayList(developerService.GetDevelopers());
            developers.AddRange(techLeaderService.GetTechLeaders());
            var techLeaders = techLeaderService.GetTechLeaders();
            PreencherComboBoxResponsaveis(developers);


            if (user is RealUsers.Developer)
            {
                lblResponsavel.Enabled = false;
                lblAprovada.Enabled = false;
                lblTempo.Enabled = false;
                lblTempo.Enabled = false;
                cbboxResponsavel.Enabled = false;
                numericTempo.Enabled = false;
                radiobtnNao.Enabled = false;
                radiobtnSim.Enabled = false;
            }

            this.user = user;
        }

        private readonly TaskService taskService;
        private readonly DeveloperService developerService;
        private readonly TechLeaderService techLeaderService;

        private readonly RealUsers.User user;
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            RealTask.Task task;
            if (user is RealUsers.Developer)
            {
                task = new RealTask.Task(txtboxNome.Text, txtboxDescricao.Text, responsible: user);
            }
            else
            {
                
                task = new RealTask.Task(txtboxNome.Text, txtboxDescricao.Text);
            }
            try
            {
                taskService.CreateTask(task);
                MessageBox.Show("Tarefa adicionada com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparDados()
        {
            txtboxNome.Text = string.Empty;
            txtboxDescricao.Text = string.Empty;
        }

        private void PreencherComboBoxResponsaveis(ArrayList users)
        {
            cbboxResponsavel.DisplayMember = "Name";
            cbboxResponsavel.ValueMember = "Id"; // Ajuste conforme a propriedade que deseja usar como valor

            cbboxResponsavel.DataSource = users;
            
        }
    }
}
