﻿using DataLayer.DataAccess;
using DataLayer.Services;
using ModelLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RealUsers = ModelLayer.Users;

namespace UI.AdminFolder
{
    public partial class TechLeaderAdditionForm : Form
    {
        public TechLeaderAdditionForm()
        {
            InitializeComponent();

            _adminService = new AdminService(new TechLeaderDataManagement());
            PreencherComboBoxAreas();
        }

        private readonly AdminService _adminService;

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var techLeaderNome = txtboxNome.Text;
            var techLeaderEmail = txtboxEmail.Text;
            var areaTechLeader = (Specializations)cbboxArea.SelectedItem;

            if (TextBoxesIsNullOrWhiteSpace(techLeaderNome, techLeaderEmail))
            {
                MessageBox.Show("Os campos Nome e Email não podem ser vazios. Tente novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var techLeader = new RealUsers.TechLeader(name: techLeaderNome, email: techLeaderEmail, specialization: areaTechLeader);

            try
            {
                _adminService.AddTechLeader(techLeader);
                MessageBox.Show($"Tech Leader adicionado com sucesso!\nChave de acesso: {techLeader.KeyAccess}", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencherComboBoxAreas()
        {
            Specializations[] specializationsArray = (Specializations[])Enum.GetValues(typeof(Specializations));


            cbboxArea.DataSource = specializationsArray;

        }

        private void LimparDados()
        {
            txtboxEmail.Text = string.Empty;
            txtboxNome.Text = string.Empty;
            cbboxArea.SelectedIndex = 0;
        }

        private bool TextBoxesIsNullOrWhiteSpace(string name, string email)
        {
            return string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
