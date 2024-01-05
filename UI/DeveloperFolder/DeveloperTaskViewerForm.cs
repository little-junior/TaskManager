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
using ModelLayer.Enums;

namespace UI.DeveloperFolder
{
    public partial class DeveloperTaskViewerForm : Form
    {
        public DeveloperTaskViewerForm(string devId)
        {
            InitializeComponent();

            _developerService = new DeveloperService(new TaskDataManagement());
            _devId = devId;

            PopulateComboBox();
            PopulateListBox(_devId);

            cbboxStatus.SelectedItem = "Todas";
        }

        private readonly DeveloperService _developerService;
        private readonly string _devId;

        private void PopulateComboBox()
        {
            cbboxStatus.Items.Add("Todas");
            foreach (Status status in Enum.GetValues(typeof(Status)))
            {
                cbboxStatus.Items.Add(status.ToString());
            }
        }
        private void PopulateListBox(string id)
        {
            var tasksList = _developerService.GetTasksByDeveloper(id);

            lboxTasks.DataSource = tasksList;
            lboxTasks.DisplayMember = "Name";
        }

        private void PopulateListBox(string id, string option)
        {
            var tasksList = _developerService.GetTasksByDeveloper(id).FindAll(t => t.Status.ToString() == option);

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

        private void cbboxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

            string statusSelecionado = cbboxStatus.SelectedItem.ToString();

            if (statusSelecionado == "Todas")
                PopulateListBox(_devId);
            else
                PopulateListBox(_devId, statusSelecionado);
        }
    }
}
