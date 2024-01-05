using DataLayer.Services;
using DataLayer.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using ModelLayer.Enums;
using RealUsers = ModelLayer.Users;
using ModelLayer.Task;

namespace UI.TechLeader
{
    public partial class DeveloperAdditionForm : Form
    {
        public DeveloperAdditionForm()
        {
            InitializeComponent();

            _techLeaderService = new TechLeaderService(new DeveloperDataManagement());
            PreencherComboBoxAreas();
        }

        private readonly TechLeaderService _techLeaderService;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var nomeDev = txtboxNome.Text;
            var emailDev = txtboxEmail.Text;
            var areaDev = (Specializations)cbboxArea.SelectedItem;

            var dev = new RealUsers.Developer(name: nomeDev, email: emailDev, specialization: areaDev);

            try
            {
                _techLeaderService.AddDeveloper(dev);
                MessageBox.Show($"Desenvolvedor adicionado com sucesso!\nChave de acesso: {dev.KeyAccess}", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparDados()
        {
            txtboxEmail.Text = string.Empty;
            txtboxNome.Text = string.Empty;
            cbboxArea.SelectedIndex = 0;
        }

        private void PreencherComboBoxAreas()
        {
            Specializations[] specializationsArray = (Specializations[])Enum.GetValues(typeof(Specializations));

            
            cbboxArea.DataSource = specializationsArray;

        }
    }
}
