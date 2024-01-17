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
using UI.TaskFolder;

namespace UI.DeveloperFolder
{
    public partial class DeveloperTaskViewerForm : Form
    {
        public DeveloperTaskViewerForm(string devId)
        {
            InitializeComponent();

            _developerService = new DeveloperService(new TaskDataManagement());
            _taskService = new TaskService(new TaskDataManagement());
            _devId = devId;

            PopulateComboBox();
            PopulateListBox(_devId);

        }

        private readonly DeveloperService _developerService;
        private readonly TaskService _taskService;
        private readonly string _devId;
        private RealTask.Task _taskAtual;
        private string _statusSelecionado;
        private TaskRelationForm _taskRelationForm;


        private void PopulateComboBox()
        {
            cbboxStatus.Items.Add("Todas");
            foreach (Status status in Enum.GetValues(typeof(Status)))
            {
                cbboxStatus.Items.Add(status.ToString());
            }
            cbboxStatus.SelectedItem = "Todas";
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
                _taskAtual = tarefaSelecionada;

                if (VerificarStatus())
                {
                    MostrarOpcoes();
                }
                else
                {
                    EsconderOpcoes();
                }
            }

        }

        private void ExibirDetalhesTarefa(RealTask.Task tarefa)
        {
            var teste = lboxTasks.Items.Count;

            if (tarefa != null && teste != 0)
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
                EsconderOpcoes();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var taskEditForm = new TaskEditForm(_taskAtual);
            taskEditForm.DesativarControles();
            taskEditForm.ShowDialog();
            AtualizarListBox();
            AtualizarExibicao();
        }



        private void MostrarOpcoes()
        {
            btnEditar.Visible = true;
            lblMarcarComo.Visible = true;
            btnMarcarAbandonada.Visible = true;
            btnMarcarAtrasada.Visible = true;
            btnMarcarConcluida.Visible = true;
            btnMarcarImpedimento.Visible = true;
        }

        private void EsconderOpcoes()
        {
            btnEditar.Visible = false;
            lblMarcarComo.Visible = false;
            btnMarcarAbandonada.Visible = false;
            btnMarcarAtrasada.Visible = false;
            btnMarcarConcluida.Visible = false;
            btnMarcarImpedimento.Visible = false;
        }

        private bool VerificarStatus()
        {
            if (_taskAtual.Status == Status.EmAnalise)
                return false;
            if (_taskAtual.Status == Status.ASerAprovada)
                return false;
            if (_taskAtual.Status == Status.Concluida)
                return false;
            if (_taskAtual.Status == Status.Abandonada)
                return false;
            return true;



        }
        private void btnMarcarImpedimento_Click(object sender, EventArgs e)
        {
            var tarefasLista = _taskService.GetTasks();
            tarefasLista.First(t => t.Id == _taskAtual.Id).UpdateStatus(Status.ComImpedimento);

            try
            {
                _taskService.UpdateTask(tarefasLista);
                MessageBox.Show("Tarefa marcada como Com Impedimento", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarListBox();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMarcarAbandonada_Click(object sender, EventArgs e)
        {
            var tarefasLista = _taskService.GetTasks();
            tarefasLista.First(t => t.Id == _taskAtual.Id).UpdateStatus(Status.Abandonada);

            try
            {
                _taskService.UpdateTask(tarefasLista);
                MessageBox.Show("Tarefa marcada como Abandonada", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarListBox();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMarcarConcluida_Click(object sender, EventArgs e)
        {
            var tarefasLista = _taskService.GetTasks();
            tarefasLista.First(t => t.Id == _taskAtual.Id).UpdateStatus(Status.EmAnalise);

            try
            {
                _taskService.UpdateTask(tarefasLista);
                MessageBox.Show("Tarefa mandada para análise", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarListBox();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMarcarAtrasada_Click(object sender, EventArgs e)
        {
            var tarefasLista = _taskService.GetTasks();
            tarefasLista.First(t => t.Id == _taskAtual.Id).UpdateStatus(Status.EmAtraso);

            try
            {
                _taskService.UpdateTask(tarefasLista);
                MessageBox.Show("Tarefa marcada como Atrasada", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarListBox();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarExibicao()
        {

            RealTask.Task tarefaSelecionada = (RealTask.Task)lboxTasks.SelectedItem;
            ExibirDetalhesTarefa(tarefaSelecionada);
            _taskAtual = tarefaSelecionada;
        }

        private void AtualizarListBox()
        {
            if (_statusSelecionado == "Todas")
                PopulateListBox(_devId);
            else
                PopulateListBox(_devId, _statusSelecionado);

            AtualizarExibicao();
        }

        private void btnVerRelac_Click(object sender, EventArgs e)
        {
            if (_taskAtual.Relation == null)
            {
                MessageBox.Show("A tarefa selecionada não possui relação.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _taskRelationForm = new TaskRelationForm(_taskAtual.Relation);
            this.Hide();
            _taskRelationForm.FormClosed += TaskRelationForm_FormClosed;
            _taskRelationForm.ShowDialog();
        }

        private void TaskRelationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Thread.Sleep(500);
            this.Show();
        }

        
    }
}
