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
using RealTask = ModelLayer.Task;

namespace UI.TaskFolder
{
    public partial class TaskEditForm : Form
    {
        public TaskEditForm(RealTask.Task task)
        {
            InitializeComponent();
            _taskService = new TaskService(new TaskDataManagement());
            _taskAtual = task;

            txtboxNome.Text = task.Name;
            txtboxDescricao.Text = task.Description;

        }

        private RealTask.Task _taskAtual;
        private readonly TaskService _taskService;

        internal void DesativarControles()
        {
            lblResponsavel.Enabled = false;
            cbboxResponsavel.Enabled = false;
            lblTempo.Enabled = false;
            numericTempo.Enabled = false;
            lblStatus.Enabled = false;
            cbboxStatus.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var tarefasLista = _taskService.GetTasks();
            string nomeAtualizado = txtboxNome.Text;
            string descricaoAtualizada = txtboxDescricao.Text;
            tarefasLista.First(t => t.Id ==  _taskAtual.Id).UpdateName(nomeAtualizado);
            tarefasLista.First(t => t.Id ==  _taskAtual.Id).UpdateDescription(descricaoAtualizada);

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
    }
}
