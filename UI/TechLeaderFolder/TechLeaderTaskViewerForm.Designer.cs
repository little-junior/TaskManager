namespace UI.TechLeaderFolder
{
    partial class TechLeaderTaskViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechLeaderTaskViewerForm));
            btnEditar = new Button();
            lblStatusBox = new Label();
            cbboxStatus = new ComboBox();
            lblStatus = new Label();
            lblAprovada = new Label();
            lblDuracao = new Label();
            lblResponsavel = new Label();
            lblDescricao = new Label();
            lblNome = new Label();
            lboxTasks = new ListBox();
            btnAprovar = new Button();
            btnNegar = new Button();
            btnMarcarConcluida = new Button();
            btnDevolver = new Button();
            lblRelacao = new Label();
            btnVerRelac = new Button();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.AutoSize = true;
            btnEditar.Font = new Font("Segoe UI", 11F);
            btnEditar.Location = new Point(756, 351);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(78, 30);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Visible = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // lblStatusBox
            // 
            lblStatusBox.AutoSize = true;
            lblStatusBox.Font = new Font("Segoe UI", 10F);
            lblStatusBox.Location = new Point(8, 20);
            lblStatusBox.Margin = new Padding(2, 0, 2, 0);
            lblStatusBox.Name = "lblStatusBox";
            lblStatusBox.Size = new Size(50, 19);
            lblStatusBox.TabIndex = 18;
            lblStatusBox.Text = "Status:";
            // 
            // cbboxStatus
            // 
            cbboxStatus.Font = new Font("Segoe UI", 10F);
            cbboxStatus.FormattingEnabled = true;
            cbboxStatus.Location = new Point(168, 18);
            cbboxStatus.Margin = new Padding(2);
            cbboxStatus.Name = "cbboxStatus";
            cbboxStatus.Size = new Size(162, 25);
            cbboxStatus.TabIndex = 17;
            cbboxStatus.SelectedIndexChanged += cbboxStatus_SelectedIndexChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblStatus.Location = new Point(354, 292);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(63, 21);
            lblStatus.TabIndex = 16;
            lblStatus.Text = "Status: ";
            lblStatus.Visible = false;
            // 
            // lblAprovada
            // 
            lblAprovada.AutoSize = true;
            lblAprovada.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAprovada.Location = new Point(354, 257);
            lblAprovada.Name = "lblAprovada";
            lblAprovada.Size = new Size(92, 21);
            lblAprovada.TabIndex = 15;
            lblAprovada.Text = "Aprovada? ";
            lblAprovada.Visible = false;
            // 
            // lblDuracao
            // 
            lblDuracao.AutoSize = true;
            lblDuracao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDuracao.Location = new Point(354, 214);
            lblDuracao.Name = "lblDuracao";
            lblDuracao.Size = new Size(125, 21);
            lblDuracao.TabIndex = 14;
            lblDuracao.Text = "Duração (dias) : ";
            lblDuracao.Visible = false;
            // 
            // lblResponsavel
            // 
            lblResponsavel.AutoSize = true;
            lblResponsavel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblResponsavel.Location = new Point(354, 170);
            lblResponsavel.Name = "lblResponsavel";
            lblResponsavel.Size = new Size(109, 21);
            lblResponsavel.TabIndex = 13;
            lblResponsavel.Text = "Responsável: ";
            lblResponsavel.Visible = false;
            // 
            // lblDescricao
            // 
            lblDescricao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDescricao.Location = new Point(354, 92);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(425, 63);
            lblDescricao.TabIndex = 12;
            lblDescricao.Text = "Descrição: ";
            lblDescricao.Visible = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblNome.Location = new Point(354, 55);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(63, 21);
            lblNome.TabIndex = 11;
            lblNome.Text = "Nome: ";
            lblNome.Visible = false;
            // 
            // lboxTasks
            // 
            lboxTasks.Font = new Font("Segoe UI", 11F);
            lboxTasks.FormattingEnabled = true;
            lboxTasks.ItemHeight = 20;
            lboxTasks.Location = new Point(8, 55);
            lboxTasks.Name = "lboxTasks";
            lboxTasks.Size = new Size(322, 404);
            lboxTasks.TabIndex = 10;
            lboxTasks.SelectedIndexChanged += lboxTasks_SelectedIndexChanged_1;
            // 
            // btnAprovar
            // 
            btnAprovar.AutoSize = true;
            btnAprovar.Font = new Font("Segoe UI", 11F);
            btnAprovar.Location = new Point(494, 406);
            btnAprovar.Margin = new Padding(2);
            btnAprovar.Name = "btnAprovar";
            btnAprovar.Size = new Size(190, 30);
            btnAprovar.TabIndex = 20;
            btnAprovar.Text = "Aprovar Tarefa";
            btnAprovar.UseVisualStyleBackColor = true;
            btnAprovar.Visible = false;
            btnAprovar.Click += btnAprovar_Click;
            // 
            // btnNegar
            // 
            btnNegar.AutoSize = true;
            btnNegar.Font = new Font("Segoe UI", 11F);
            btnNegar.Location = new Point(494, 445);
            btnNegar.Margin = new Padding(2);
            btnNegar.Name = "btnNegar";
            btnNegar.Size = new Size(190, 30);
            btnNegar.TabIndex = 21;
            btnNegar.Text = "Negar Tarefa (abandonar)";
            btnNegar.UseVisualStyleBackColor = true;
            btnNegar.Visible = false;
            btnNegar.Click += btnNegar_Click;
            // 
            // btnMarcarConcluida
            // 
            btnMarcarConcluida.AutoSize = true;
            btnMarcarConcluida.Font = new Font("Segoe UI", 11F);
            btnMarcarConcluida.Location = new Point(494, 406);
            btnMarcarConcluida.Margin = new Padding(2);
            btnMarcarConcluida.Name = "btnMarcarConcluida";
            btnMarcarConcluida.Size = new Size(190, 30);
            btnMarcarConcluida.TabIndex = 22;
            btnMarcarConcluida.Text = "Marcar como Concluída";
            btnMarcarConcluida.UseVisualStyleBackColor = true;
            btnMarcarConcluida.Visible = false;
            btnMarcarConcluida.Click += btnMarcarConcluida_Click;
            // 
            // btnDevolver
            // 
            btnDevolver.AutoSize = true;
            btnDevolver.Font = new Font("Segoe UI", 11F);
            btnDevolver.Location = new Point(494, 445);
            btnDevolver.Margin = new Padding(2);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(190, 30);
            btnDevolver.TabIndex = 23;
            btnDevolver.Text = "Devolver ao Responsável";
            btnDevolver.UseVisualStyleBackColor = true;
            btnDevolver.Visible = false;
            btnDevolver.Click += btnDevolver_Click;
            // 
            // lblRelacao
            // 
            lblRelacao.AutoSize = true;
            lblRelacao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblRelacao.Location = new Point(354, 329);
            lblRelacao.Name = "lblRelacao";
            lblRelacao.Size = new Size(71, 21);
            lblRelacao.TabIndex = 24;
            lblRelacao.Text = "Relação:";
            lblRelacao.Visible = false;
            // 
            // btnVerRelac
            // 
            btnVerRelac.Font = new Font("Segoe UI", 11F);
            btnVerRelac.Location = new Point(704, 12);
            btnVerRelac.Name = "btnVerRelac";
            btnVerRelac.Size = new Size(130, 32);
            btnVerRelac.TabIndex = 25;
            btnVerRelac.Text = "Ver Relacionadas";
            btnVerRelac.UseVisualStyleBackColor = true;
            btnVerRelac.Click += btnVerRelac_Click;
            // 
            // TechLeaderTaskViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 492);
            Controls.Add(btnVerRelac);
            Controls.Add(lblRelacao);
            Controls.Add(btnDevolver);
            Controls.Add(btnMarcarConcluida);
            Controls.Add(btnNegar);
            Controls.Add(btnAprovar);
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
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "TechLeaderTaskViewerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciar Tarefas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditar;
        private Label lblStatusBox;
        private ComboBox cbboxStatus;
        private Label lblStatus;
        private Label lblAprovada;
        private Label lblDuracao;
        private Label lblResponsavel;
        private Label lblDescricao;
        private Label lblNome;
        private ListBox lboxTasks;
        private Button btnAprovar;
        private Button btnNegar;
        private Button btnMarcarConcluida;
        private Button btnDevolver;
        private Label lblRelacao;
        private Button btnVerRelac;
    }
}