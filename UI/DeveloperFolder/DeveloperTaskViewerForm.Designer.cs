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
            lboxTasks.ItemHeight = 30;
            lboxTasks.Location = new Point(13, 96);
            lboxTasks.Margin = new Padding(4, 5, 4, 5);
            lboxTasks.Name = "lboxTasks";
            lboxTasks.Size = new Size(458, 604);
            lboxTasks.TabIndex = 0;
            lboxTasks.SelectedIndexChanged += lboxTasks_SelectedIndexChanged;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F);
            lblNome.Location = new Point(506, 96);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(92, 32);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome: ";
            lblNome.Visible = false;
            // 
            // lblDescricao
            // 
            lblDescricao.Font = new Font("Segoe UI", 12F);
            lblDescricao.Location = new Point(506, 157);
            lblDescricao.Margin = new Padding(4, 0, 4, 0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(607, 105);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição: ";
            lblDescricao.Visible = false;
            // 
            // lblResponsavel
            // 
            lblResponsavel.AutoSize = true;
            lblResponsavel.Font = new Font("Segoe UI", 12F);
            lblResponsavel.Location = new Point(506, 276);
            lblResponsavel.Margin = new Padding(4, 0, 4, 0);
            lblResponsavel.Name = "lblResponsavel";
            lblResponsavel.Size = new Size(157, 32);
            lblResponsavel.TabIndex = 3;
            lblResponsavel.Text = "Responsável: ";
            lblResponsavel.Visible = false;
            // 
            // lblDuracao
            // 
            lblDuracao.AutoSize = true;
            lblDuracao.Font = new Font("Segoe UI", 12F);
            lblDuracao.Location = new Point(506, 340);
            lblDuracao.Margin = new Padding(4, 0, 4, 0);
            lblDuracao.Name = "lblDuracao";
            lblDuracao.Size = new Size(184, 32);
            lblDuracao.TabIndex = 4;
            lblDuracao.Text = "Duração (dias) : ";
            lblDuracao.Visible = false;
            // 
            // lblAprovada
            // 
            lblAprovada.AutoSize = true;
            lblAprovada.Font = new Font("Segoe UI", 12F);
            lblAprovada.Location = new Point(506, 407);
            lblAprovada.Margin = new Padding(4, 0, 4, 0);
            lblAprovada.Name = "lblAprovada";
            lblAprovada.Size = new Size(133, 32);
            lblAprovada.TabIndex = 5;
            lblAprovada.Text = "Aprovada? ";
            lblAprovada.Visible = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F);
            lblStatus.Location = new Point(507, 491);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(90, 32);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status: ";
            lblStatus.Visible = false;
            // 
            // cbboxStatus
            // 
            cbboxStatus.Font = new Font("Segoe UI", 10F);
            cbboxStatus.FormattingEnabled = true;
            cbboxStatus.Location = new Point(241, 34);
            cbboxStatus.Name = "cbboxStatus";
            cbboxStatus.Size = new Size(230, 36);
            cbboxStatus.TabIndex = 7;
            cbboxStatus.SelectedIndexChanged += cbboxStatus_SelectedIndexChanged;
            // 
            // lblStatusBox
            // 
            lblStatusBox.AutoSize = true;
            lblStatusBox.Font = new Font("Segoe UI", 10F);
            lblStatusBox.Location = new Point(13, 37);
            lblStatusBox.Name = "lblStatusBox";
            lblStatusBox.Size = new Size(69, 28);
            lblStatusBox.TabIndex = 8;
            lblStatusBox.Text = "Status:";
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Segoe UI", 11F);
            btnEditar.Location = new Point(1013, 533);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(118, 40);
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
            btnMarcarImpedimento.Location = new Point(665, 630);
            btnMarcarImpedimento.Name = "btnMarcarImpedimento";
            btnMarcarImpedimento.Size = new Size(205, 40);
            btnMarcarImpedimento.TabIndex = 10;
            btnMarcarImpedimento.Text = "Com impedimento";
            btnMarcarImpedimento.UseVisualStyleBackColor = true;
            btnMarcarImpedimento.Click += btnMarcarImpedimento_Click;
            // 
            // lblMarcarComo
            // 
            lblMarcarComo.AutoSize = true;
            lblMarcarComo.Font = new Font("Segoe UI", 11F);
            lblMarcarComo.Location = new Point(506, 630);
            lblMarcarComo.Name = "lblMarcarComo";
            lblMarcarComo.Size = new Size(153, 30);
            lblMarcarComo.TabIndex = 11;
            lblMarcarComo.Text = "Marcar como: ";
            // 
            // btnMarcarAbandonada
            // 
            btnMarcarAbandonada.AutoSize = true;
            btnMarcarAbandonada.Font = new Font("Segoe UI", 11F);
            btnMarcarAbandonada.Location = new Point(901, 630);
            btnMarcarAbandonada.Name = "btnMarcarAbandonada";
            btnMarcarAbandonada.Size = new Size(172, 40);
            btnMarcarAbandonada.TabIndex = 12;
            btnMarcarAbandonada.Text = "Abandonada";
            btnMarcarAbandonada.UseVisualStyleBackColor = true;
            btnMarcarAbandonada.Click += btnMarcarAbandonada_Click;
            // 
            // btnMarcarConcluida
            // 
            btnMarcarConcluida.AutoSize = true;
            btnMarcarConcluida.Font = new Font("Segoe UI", 11F);
            btnMarcarConcluida.Location = new Point(665, 684);
            btnMarcarConcluida.Name = "btnMarcarConcluida";
            btnMarcarConcluida.Size = new Size(203, 40);
            btnMarcarConcluida.TabIndex = 13;
            btnMarcarConcluida.Text = "Concluída (análise)";
            btnMarcarConcluida.UseVisualStyleBackColor = true;
            btnMarcarConcluida.Click += btnMarcarConcluida_Click;
            // 
            // btnMarcarAtrasada
            // 
            btnMarcarAtrasada.AutoSize = true;
            btnMarcarAtrasada.Font = new Font("Segoe UI", 11F);
            btnMarcarAtrasada.Location = new Point(901, 684);
            btnMarcarAtrasada.Name = "btnMarcarAtrasada";
            btnMarcarAtrasada.Size = new Size(172, 40);
            btnMarcarAtrasada.TabIndex = 14;
            btnMarcarAtrasada.Text = "Atrasada";
            btnMarcarAtrasada.UseVisualStyleBackColor = true;
            btnMarcarAtrasada.Click += btnMarcarAtrasada_Click;
            // 
            // DeveloperTaskViewerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
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
            Margin = new Padding(4, 5, 4, 5);
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