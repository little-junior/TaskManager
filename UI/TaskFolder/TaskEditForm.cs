using DataLayer.DataAccess;
using DataLayer.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealTask = ModelLayer.Task;
using ModelLayer.Enums;
using ModelLayer.Users;
namespace UI.TaskFolder
{
    public partial class TaskEditForm : Form
    {
        public TaskEditForm(RealTask.Task task)
        {
            InitializeComponent();
            _taskService = new TaskService(new TaskDataManagement());
            _taskAtual = task;

            _developerService = new DeveloperService(new DeveloperDataManagement());
            _techLeaderService = new TechLeaderService(new TechLeaderDataManagement());

            ArrayList users = new ArrayList(_developerService.GetDevelopers());
            users.AddRange(_techLeaderService.GetTechLeaders());
            PreencherComboBoxResponsaveis(users);
            PreencherComboBoxStatus();

            txtboxNome.Text = task.Name;
            txtboxDescricao.Text = task.Description;
            numericTempo.Value = task.TaskDaySpan;
            cbboxStatus.SelectedItem = task.Status.ToString();
            txtboxRelacao.Text = task.Relation;
        }

        private void PreencherComboBoxResponsaveis(ArrayList users)
        {
            cbboxResponsavel.DisplayMember = "NameSpecializationPosition";
            cbboxResponsavel.ValueMember = "Id";

            User responsavel = users.Cast<User>().FirstOrDefault(user => user.Id == _taskAtual.Responsible.Id);

            cbboxResponsavel.DataSource = users;
            cbboxResponsavel.SelectedItem = responsavel;
        }

        private void PreencherComboBoxStatus()
        {

            foreach (Status status in Enum.GetValues(typeof(Status)))
            {
                if (status == Status.ASerAprovada || status == Status.EmAnalise)
                    continue;
                cbboxStatus.Items.Add(status.ToString());
            }



        }

        private RealTask.Task _taskAtual;
        private readonly TaskService _taskService;
        private readonly DeveloperService _developerService;
        private readonly TechLeaderService _techLeaderService;

        internal void DesativarControles()
        {
            lblResponsavel.Enabled = false;
            cbboxResponsavel.Enabled = false;
            lblTempo.Enabled = false;
            numericTempo.Enabled = false;
            lblStatus.Enabled = false;
            cbboxStatus.Enabled = false;
            lblRelacao.Enabled = false;
            txtboxRelacao.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var tarefasLista = _taskService.GetTasks();
            string nomeAtualizado = txtboxNome.Text;
            string descricaoAtualizada = txtboxDescricao.Text;
            var responsavelAtualizado = (User)cbboxResponsavel.SelectedItem;
            var duracaoAtualizada = (int)numericTempo.Value;
            var statusAtualizado = Enum.Parse<Status>(cbboxStatus.SelectedItem.ToString());
            var relacaoAtualizada = string.IsNullOrWhiteSpace(txtboxRelacao.Text) ? null : txtboxRelacao.Text;

            if (TextBoxesIsNullOrWhiteSpace(nomeAtualizado, descricaoAtualizada))
            {
                MessageBox.Show("Os campos Nome e Descrição não podem ser vazios. Tente novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tarefasLista.First(t => t.Id == _taskAtual.Id).UpdateName(nomeAtualizado);
            tarefasLista.First(t => t.Id == _taskAtual.Id).UpdateDescription(descricaoAtualizada);
            tarefasLista.First(t => t.Id == _taskAtual.Id).UpdateStatus(statusAtualizado);
            tarefasLista.First(t => t.Id == _taskAtual.Id).UpdateResponsible(responsavelAtualizado);
            tarefasLista.First(t => t.Id == _taskAtual.Id).UpdateDaySpan(duracaoAtualizada);
            tarefasLista.First(t => t.Id == _taskAtual.Id).UpdateRelation(relacaoAtualizada);

            try
            {
                _taskService.UpdateTask(tarefasLista);
                MessageBox.Show("Tarefa editada com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool TextBoxesIsNullOrWhiteSpace(string name, string description)
        {
            return string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
