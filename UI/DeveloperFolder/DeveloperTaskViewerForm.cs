using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.DataAccess;
using DataLayer.Services;
using RealTask = ModelLayer.Task;

namespace UI.DeveloperFolder
{
    public partial class DeveloperTaskViewerForm : Form
    {
        public DeveloperTaskViewerForm(string devId)
        {
            InitializeComponent();

            _developerService = new DeveloperService(new TaskDataManagement());


            PopulateListBox(devId);

        }

        private readonly DeveloperService _developerService;

        private void PopulateListBox(string id)
        {
            var tasksList = _developerService.GetTasksByDeveloper(id);

            lboxTasks.DataSource = tasksList;
            lboxTasks.DisplayMember = "Name";
        }

        private void lboxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxTasks != null)
            {
                RealTask.Task tarefaSelecionada = (RealTask.Task)lboxTasks.SelectedItem;
                ExibirDetalhesTarefa(tarefaSelecionada);
            }
        }

        private void ExibirDetalhesTarefa(RealTask.Task tarefa)
        {
            lblNome.Text = $"Nome: {tarefa.Name}";
            lblDescricao.Text = $"Descrição: {tarefa.Description}";
            lblResponsavel.Text = $"Responsável: {tarefa.Responsible.NameSpecializationPosition}";
            lblDuracao.Text = $"Duração (dias): {tarefa.TaskDaySpan}";
            lblAprovada.Text = $"Aprovada? -> {tarefa.Approved}";
            lblStatus.Text = $"Status: {tarefa.Status}";

            ExibirControles();
        }

        private void ExibirControles()
        {
            lblNome.Visible = true;
            lblDescricao.Visible = true;
            lblResponsavel.Visible = true;
            lblDuracao.Visible = true;
            lblAprovada.Visible = true;
            lblStatus.Visible = true;
        }
    }
}
