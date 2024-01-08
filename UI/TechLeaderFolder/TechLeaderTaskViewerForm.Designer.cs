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
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.AutoSize = true;
            btnEditar.Font = new Font("Segoe UI", 11F);
            btnEditar.Location = new Point(1019, 521);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 40);
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
            lblStatusBox.Location = new Point(12, 33);
            lblStatusBox.Name = "lblStatusBox";
            lblStatusBox.Size = new Size(69, 28);
            lblStatusBox.TabIndex = 18;
            lblStatusBox.Text = "Status:";
            // 
            // cbboxStatus
            // 
            cbboxStatus.Font = new Font("Segoe UI", 10F);
            cbboxStatus.FormattingEnabled = true;
            cbboxStatus.Location = new Point(240, 30);
            cbboxStatus.Name = "cbboxStatus";
            cbboxStatus.Size = new Size(230, 36);
            cbboxStatus.TabIndex = 17;
            cbboxStatus.SelectedIndexChanged += cbboxStatus_SelectedIndexChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F);
            lblStatus.Location = new Point(506, 487);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(90, 32);
            lblStatus.TabIndex = 16;
            lblStatus.Text = "Status: ";
            lblStatus.Visible = false;
            // 
            // lblAprovada
            // 
            lblAprovada.AutoSize = true;
            lblAprovada.Font = new Font("Segoe UI", 12F);
            lblAprovada.Location = new Point(506, 428);
            lblAprovada.Margin = new Padding(4, 0, 4, 0);
            lblAprovada.Name = "lblAprovada";
            lblAprovada.Size = new Size(133, 32);
            lblAprovada.TabIndex = 15;
            lblAprovada.Text = "Aprovada? ";
            lblAprovada.Visible = false;
            // 
            // lblDuracao
            // 
            lblDuracao.AutoSize = true;
            lblDuracao.Font = new Font("Segoe UI", 12F);
            lblDuracao.Location = new Point(505, 357);
            lblDuracao.Margin = new Padding(4, 0, 4, 0);
            lblDuracao.Name = "lblDuracao";
            lblDuracao.Size = new Size(184, 32);
            lblDuracao.TabIndex = 14;
            lblDuracao.Text = "Duração (dias) : ";
            lblDuracao.Visible = false;
            // 
            // lblResponsavel
            // 
            lblResponsavel.AutoSize = true;
            lblResponsavel.Font = new Font("Segoe UI", 12F);
            lblResponsavel.Location = new Point(505, 283);
            lblResponsavel.Margin = new Padding(4, 0, 4, 0);
            lblResponsavel.Name = "lblResponsavel";
            lblResponsavel.Size = new Size(157, 32);
            lblResponsavel.TabIndex = 13;
            lblResponsavel.Text = "Responsável: ";
            lblResponsavel.Visible = false;
            // 
            // lblDescricao
            // 
            lblDescricao.Font = new Font("Segoe UI", 12F);
            lblDescricao.Location = new Point(505, 153);
            lblDescricao.Margin = new Padding(4, 0, 4, 0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(607, 105);
            lblDescricao.TabIndex = 12;
            lblDescricao.Text = "Descrição: ";
            lblDescricao.Visible = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F);
            lblNome.Location = new Point(505, 92);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(92, 32);
            lblNome.TabIndex = 11;
            lblNome.Text = "Nome: ";
            lblNome.Visible = false;
            // 
            // lboxTasks
            // 
            lboxTasks.Font = new Font("Segoe UI", 11F);
            lboxTasks.FormattingEnabled = true;
            lboxTasks.ItemHeight = 30;
            lboxTasks.Location = new Point(12, 92);
            lboxTasks.Margin = new Padding(4, 5, 4, 5);
            lboxTasks.Name = "lboxTasks";
            lboxTasks.Size = new Size(458, 604);
            lboxTasks.TabIndex = 10;
            lboxTasks.SelectedIndexChanged += lboxTasks_SelectedIndexChanged_1;
            // 
            // btnAprovar
            // 
            btnAprovar.AutoSize = true;
            btnAprovar.Font = new Font("Segoe UI", 11F);
            btnAprovar.Location = new Point(679, 599);
            btnAprovar.Name = "btnAprovar";
            btnAprovar.Size = new Size(272, 40);
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
            btnNegar.Location = new Point(679, 663);
            btnNegar.Name = "btnNegar";
            btnNegar.Size = new Size(272, 40);
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
            btnMarcarConcluida.Location = new Point(679, 599);
            btnMarcarConcluida.Name = "btnMarcarConcluida";
            btnMarcarConcluida.Size = new Size(272, 40);
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
            btnDevolver.Location = new Point(679, 663);
            btnDevolver.Name = "btnDevolver";
            btnDevolver.Size = new Size(272, 40);
            btnDevolver.TabIndex = 23;
            btnDevolver.Text = "Devolver ao Responsável";
            btnDevolver.UseVisualStyleBackColor = true;
            btnDevolver.Visible = false;
            btnDevolver.Click += btnDevolver_Click;
            // 
            // TechLeaderTaskViewerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
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
    }
}