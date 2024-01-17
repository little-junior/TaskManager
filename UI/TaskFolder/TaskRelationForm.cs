using DataLayer.DataAccess;
using DataLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelLayer.Enums;
using RealTask = ModelLayer.Task;

namespace UI.TaskFolder
{
    public partial class TaskRelationForm : Form
    {
        public TaskRelationForm(string relation)
        {
            InitializeComponent();

            _relation = relation;
            _taskService = new TaskService(new TaskDataManagement());

            PopulateComboBox();
            PopulateListBox();
        }

        private readonly TaskService _taskService;
        private string _statusSelecionado;
        private string _relation;


        private void PopulateComboBox()
        {
            cbboxStatus.Items.Add("Todas");
            foreach (Status status in Enum.GetValues(typeof(Status)))
            {
                cbboxStatus.Items.Add(status.ToString());
            }

            cbboxStatus.SelectedItem = "Todas";

        }

        private void PopulateListBox()
        {
            var tasksList = _taskService.GetTasksByRelation(_relation);

            lboxTasks.DataSource = tasksList;
            lboxTasks.DisplayMember = "Name";
        }

        private void PopulateListBox(string option)
        {
            var tasksList = _taskService.GetTasksByRelation(_relation).FindAll(t => t.Status.ToString() == option);

            lboxTasks.DataSource = tasksList;
            lboxTasks.DisplayMember = "Name";
        }

        private void ExibirDetalhesTarefa(RealTask.Task tarefa)
        {
            var tasksCount = lboxTasks.Items.Count;

            if (tarefa != null && tasksCount != 0)
            {
                lblNome.Text = $"Nome: {tarefa.Name}";
                lblDescricao.Text = $"Descrição: {tarefa.Description}";
                lblResponsavel.Text = $"Responsável: {tarefa.Responsible.NameSpecializationPosition}";
                lblDuracao.Text = $"Duração (dias): {tarefa.TaskDaySpan}";
                lblAprovada.Text = $"Aprovada? -> {tarefa.Approved}";
                lblStatus.Text = $"Status: {tarefa.Status}";
                lblRelacao.Text = $"Relação: {tarefa.Relation}";

                ExibirControles();
            }
            else
            {
                EsconderControles();

            }
        }

        private void ExibirControles()
        {
            lblNome.Visible = true;
            lblDescricao.Visible = true;
            lblResponsavel.Visible = true;
            lblDuracao.Visible = true;
            lblAprovada.Visible = true;
            lblStatus.Visible = true;
            lblRelacao.Visible = true;
        }

        private void EsconderControles()
        {
            lblNome.Visible = false;
            lblDescricao.Visible = false;
            lblResponsavel.Visible = false;
            lblDuracao.Visible = false;
            lblAprovada.Visible = false;
            lblStatus.Visible = false;
            lblRelacao.Visible = false;
        }

        

        private void cbboxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _statusSelecionado = cbboxStatus.SelectedItem.ToString();

            AtualizarListBox();
        }

        private void AtualizarListBox()
        {
            if (_statusSelecionado == "Todas")
                PopulateListBox();
            else
                PopulateListBox(_statusSelecionado);

            AtualizarExibicao();
        }

        private void AtualizarExibicao()
        {
            if (lboxTasks != null)
            {
                RealTask.Task tarefaSelecionada = (RealTask.Task)lboxTasks.SelectedItem;
                ExibirDetalhesTarefa(tarefaSelecionada);
            }
        }

        private void lboxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarExibicao();
        }
    }
}
