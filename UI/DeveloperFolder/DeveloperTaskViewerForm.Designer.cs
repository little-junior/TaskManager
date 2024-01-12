namespace UI.DeveloperFolder
{
    partial class DeveloperTaskViewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeveloperTaskViewerForm));
            lboxTasks = new ListBox();
            lblNome = new Label();
            lblDescricao = new Label();
            lblResponsavel = new Label();
            lblDuracao = new Label();
            lblAprovada = new Label();
            lblStatus = new Label();
            cbboxStatus = new ComboBox();
            lblStatusBox = new Label();
            btnEditar = new Button();
            btnMarcarImpedimento = new Button();
            lblMarcarComo = new Label();
            btnMarcarAbandonada = new Button();
            btnMarcarConcluida = new Button();
            btnMarcarAtrasada = new Button();
            SuspendLayout();
            // 
            // lboxTasks
            // 
            lboxTasks.Font = new Font("Segoe UI", 11F);
            lboxTasks.FormattingEnabled = true;
            lboxTasks.ItemHeight = 20;
            lboxTasks.Location = new Point(9, 58);
            lboxTasks.Name = "lboxTasks";
            lboxTasks.Size = new Size(322, 364);
            lboxTasks.TabIndex = 0;
            lboxTasks.SelectedIndexChanged += lboxTasks_SelectedIndexChanged;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F);
            lblNome.Location = new Point(354, 58);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(60, 21);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome: ";
            lblNome.Visible = false;
            // 
            // lblDescricao
            // 
            lblDescricao.Font = new Font("Segoe UI", 12F);
            lblDescricao.Location = new Point(354, 94);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(425, 63);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição: ";
            lblDescricao.Visible = false;
            // 
            // lblResponsavel
            // 
            lblResponsavel.AutoSize = true;
            lblResponsavel.Font = new Font("Segoe UI", 12F);
            lblResponsavel.Location = new Point(354, 166);
            lblResponsavel.Name = "lblResponsavel";
            lblResponsavel.Size = new Size(104, 21);
            lblResponsavel.TabIndex = 3;
            lblResponsavel.Text = "Responsável: ";
            lblResponsavel.Visible = false;
            // 
            // lblDuracao
            // 
            lblDuracao.AutoSize = true;
            lblDuracao.Font = new Font("Segoe UI", 12F);
            lblDuracao.Location = new Point(354, 204);
            lblDuracao.Name = "lblDuracao";
            lblDuracao.Size = new Size(121, 21);
            lblDuracao.TabIndex = 4;
            lblDuracao.Text = "Duração (dias) : ";
            lblDuracao.Visible = false;
            // 
            // lblAprovada
            // 
            lblAprovada.AutoSize = true;
            lblAprovada.Font = new Font("Segoe UI", 12F);
            lblAprovada.Location = new Point(354, 244);
            lblAprovada.Name = "lblAprovada";
            lblAprovada.Size = new Size(88, 21);
            lblAprovada.TabIndex = 5;
            lblAprovada.Text = "Aprovada? ";
            lblAprovada.Visible = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F);
            lblStatus.Location = new Point(355, 295);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(59, 21);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status: ";
            lblStatus.Visible = false;
            // 
            // cbboxStatus
            // 
            cbboxStatus.Font = new Font("Segoe UI", 10F);
            cbboxStatus.FormattingEnabled = true;
            cbboxStatus.Location = new Point(169, 20);
            cbboxStatus.Margin = new Padding(2, 2, 2, 2);
            cbboxStatus.Name = "cbboxStatus";
            cbboxStatus.Size = new Size(162, 25);
            cbboxStatus.TabIndex = 7;
            cbboxStatus.SelectedIndexChanged += cbboxStatus_SelectedIndexChanged;
            // 
            // lblStatusBox
            // 
            lblStatusBox.AutoSize = true;
            lblStatusBox.Font = new Font("Segoe UI", 10F);
            lblStatusBox.Location = new Point(9, 22);
            lblStatusBox.Margin = new Padding(2, 0, 2, 0);
            lblStatusBox.Name = "lblStatusBox";
            lblStatusBox.Size = new Size(50, 19);
            lblStatusBox.TabIndex = 8;
            lblStatusBox.Text = "Status:";
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 11F);
            btnEditar.Location = new Point(709, 320);
            btnEditar.Margin = new Padding(2, 2, 2, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(83, 24);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Visible = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnMarcarImpedimento
            // 
            btnMarcarImpedimento.AutoSize = true;
            btnMarcarImpedimento.Font = new Font("Segoe UI", 11F);
            btnMarcarImpedimento.Location = new Point(466, 378);
            btnMarcarImpedimento.Margin = new Padding(2, 2, 2, 2);
            btnMarcarImpedimento.Name = "btnMarcarImpedimento";
            btnMarcarImpedimento.Size = new Size(144, 30);
            btnMarcarImpedimento.TabIndex = 10;
            btnMarcarImpedimento.Text = "Com impedimento";
            btnMarcarImpedimento.UseVisualStyleBackColor = true;
            btnMarcarImpedimento.Visible = false;
            btnMarcarImpedimento.Click += btnMarcarImpedimento_Click;
            // 
            // lblMarcarComo
            // 
            lblMarcarComo.AutoSize = true;
            lblMarcarComo.Font = new Font("Segoe UI", 11F);
            lblMarcarComo.Location = new Point(354, 378);
            lblMarcarComo.Margin = new Padding(2, 0, 2, 0);
            lblMarcarComo.Name = "lblMarcarComo";
            lblMarcarComo.Size = new Size(104, 20);
            lblMarcarComo.TabIndex = 11;
            lblMarcarComo.Text = "Marcar como: ";
            lblMarcarComo.Visible = false;
            // 
            // btnMarcarAbandonada
            // 
            btnMarcarAbandonada.AutoSize = true;
            btnMarcarAbandonada.Font = new Font("Segoe UI", 11F);
            btnMarcarAbandonada.Location = new Point(631, 378);
            btnMarcarAbandonada.Margin = new Padding(2, 2, 2, 2);
            btnMarcarAbandonada.Name = "btnMarcarAbandonada";
            btnMarcarAbandonada.Size = new Size(120, 30);
            btnMarcarAbandonada.TabIndex = 12;
            btnMarcarAbandonada.Text = "Abandonada";
            btnMarcarAbandonada.UseVisualStyleBackColor = true;
            btnMarcarAbandonada.Visible = false;
            btnMarcarAbandonada.Click += btnMarcarAbandonada_Click;
            // 
            // btnMarcarConcluida
            // 
            btnMarcarConcluida.AutoSize = true;
            btnMarcarConcluida.Font = new Font("Segoe UI", 11F);
            btnMarcarConcluida.Location = new Point(466, 410);
            btnMarcarConcluida.Margin = new Padding(2, 2, 2, 2);
            btnMarcarConcluida.Name = "btnMarcarConcluida";
            btnMarcarConcluida.Size = new Size(145, 30);
            btnMarcarConcluida.TabIndex = 13;
            btnMarcarConcluida.Text = "Concluída (análise)";
            btnMarcarConcluida.UseVisualStyleBackColor = true;
            btnMarcarConcluida.Visible = false;
            btnMarcarConcluida.Click += btnMarcarConcluida_Click;
            // 
            // btnMarcarAtrasada
            // 
            btnMarcarAtrasada.AutoSize = true;
            btnMarcarAtrasada.Font = new Font("Segoe UI", 11F);
            btnMarcarAtrasada.Location = new Point(631, 410);
            btnMarcarAtrasada.Margin = new Padding(2, 2, 2, 2);
            btnMarcarAtrasada.Name = "btnMarcarAtrasada";
            btnMarcarAtrasada.Size = new Size(120, 30);
            btnMarcarAtrasada.TabIndex = 14;
            btnMarcarAtrasada.Text = "Atrasada";
            btnMarcarAtrasada.UseVisualStyleBackColor = true;
            btnMarcarAtrasada.Visible = false;
            btnMarcarAtrasada.Click += btnMarcarAtrasada_Click;
            // 
            // DeveloperTaskViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 449);
            Controls.Add(btnMarcarAtrasada);
            Controls.Add(btnMarcarConcluida);
            Controls.Add(btnMarcarAbandonada);
            Controls.Add(lblMarcarComo);
            Controls.Add(btnMarcarImpedimento);
            Controls.Add(btnEditar);
            Controls.Add(lblStatusBox);
            Controls.Add(cbboxStatus);
            Controls.Add(lblStatus);
            Controls.Add(lblAprovada);
            Controls.Add(lblDuracao);
            Controls.Add(lblResponsavel);
            Controls.Add(lblDescricao);
            Controls.Add(lblNome);
            Controls.Add(lboxTasks);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DeveloperTaskViewerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualizar Tarefas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lboxTasks;
        private Label lblNome;
        private Label lblDescricao;
        private Label lblResponsavel;
        private Label lblDuracao;
        private Label lblAprovada;
        private Label lblStatus;
        private ComboBox cbboxStatus;
        private Label lblStatusBox;
        private Button btnEditar;
        private Button btnMarcarImpedimento;
        private Label lblMarcarComo;
        private Button btnMarcarAbandonada;
        private Button btnMarcarConcluida;
        private Button btnMarcarAtrasada;
    }
}