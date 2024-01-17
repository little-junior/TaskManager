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
using ModelLayer.Enums;
using UI.TaskFolder;
using RealTask = ModelLayer.Task;
namespace UI.TechLeaderFolder
{
    public partial class TechLeaderTaskViewerForm : Form
    {
        public TechLeaderTaskViewerForm()
        {
            InitializeComponent();

            _taskService = new TaskService(new TaskDataManagement());

            PopulateComboBox();
            PopulateListBox();
        }

        private readonly TaskService _taskService;
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

        private void PopulateListBox()
        {
            var tasksList = _taskService.GetTasks();

            lboxTasks.DataSource = tasksList;
            lboxTasks.DisplayMember = "Name";
        }

        private void PopulateListBox(string option)
        {
            var tasksList = _taskService.GetTasks().FindAll(t => t.Status.ToString() == option);


            lboxTasks.DataSource = tasksList;
            lboxTasks.DisplayMember = "Name";
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
                EsconderOpcoesASerAprovada();
                EsconderOpcoesEmAnalise();
                btnEditar.Visible = false;
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

        private void lboxTasks_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lboxTasks != null)
            {
                RealTask.Task tarefaSelecionada = (RealTask.Task)lboxTasks.SelectedItem;
                ExibirDetalhesTarefa(tarefaSelecionada);
                _taskAtual = tarefaSelecionada;

                VerificarStatus();
            }
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

            RealTask.Task tarefaSelecionada = (RealTask.Task)lboxTasks.SelectedItem;
            ExibirDetalhesTarefa(tarefaSelecionada);
            _taskAtual = tarefaSelecionada;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var taskEditForm = new TaskEditForm(_taskAtual);
            taskEditForm.ShowDialog();
            AtualizarListBox();
            AtualizarExibicao();
        }



        private void VerificarStatus()
        {
            switch (_taskAtual.Status)
            {
                case (Status.EmAnalise):
                    MostrarOpcoesEmAnalise();
                    EsconderOpcoesASerAprovada();
                    btnEditar.Visible = false;
                    break;
                case (Status.ASerAprovada):
                    MostrarOpcoesASerAprovada();
                    EsconderOpcoesEmAnalise();
                    btnEditar.Visible = false;
                    break;
                case (Status.Abandonada):
                case (Status.Concluida):
                    btnEditar.Visible = false;
                    EsconderOpcoesASerAprovada();
                    EsconderOpcoesEmAnalise();
                    break;
                default:
                    btnEditar.Visible = true;
                    EsconderOpcoesASerAprovada();
                    EsconderOpcoesEmAnalise();
                    break;

            }
        }

        private void MostrarOpcoesEmAnalise()
        {
            btnMarcarConcluida.Visible = true;
            btnDevolver.Visible = true;

        }

        private void EsconderOpcoesEmAnalise()
        {
            btnMarcarConcluida.Visible = false;
            btnDevolver.Visible = false;
        }

        private void MostrarOpcoesASerAprovada()
        {
            btnAprovar.Visible = true;
            btnNegar.Visible = true;
        }

        private void EsconderOpcoesASerAprovada()
        {
            btnAprovar.Visible = false;
            btnNegar.Visible = false;

        }

        private void btnMarcarConcluida_Click(object sender, EventArgs e)
        {
            var tarefasLista = _taskService.GetTasks();
            tarefasLista.First(t => t.Id == _taskAtual.Id).UpdateStatus(Status.Concluida);

            try
            {
                _taskService.UpdateTask(tarefasLista);
                MessageBox.Show("Tarefa marcada como Concluída", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarListBox();
                AtualizarExibicao();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            var tarefasLista = _taskService.GetTasks();
            tarefasLista.First(t => t.Id == _taskAtual.Id).UpdateStatus(Status.EmAndamento);

            try
            {
                _taskService.UpdateTask(tarefasLista);
                MessageBox.Show("Tarefa devolvida para desenvolvimento", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarListBox();
                AtualizarExibicao();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAprovar_Click(object sender, EventArgs e)
        {
            var tarefasLista = _taskService.GetTasks();
            tarefasLista.First(t => t.Id == _taskAtual.Id).SetApproved();

            try
            {
                _taskService.UpdateTask(tarefasLista);
                MessageBox.Show("Tarefa aprovada e mandada para desenvolvimento", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarListBox();
                AtualizarExibicao();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNegar_Click(object sender, EventArgs e)
        {
            var tarefasLista = _taskService.GetTasks();
            tarefasLista.First(t => t.Id == _taskAtual.Id).UpdateStatus(Status.Abandonada);

            try
            {
                _taskService.UpdateTask(tarefasLista);
                MessageBox.Show("Tarefa negada e abandonada", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarListBox();
                AtualizarExibicao();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
