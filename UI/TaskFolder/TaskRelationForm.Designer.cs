namespace UI.TaskFolder
{
    partial class TaskRelationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskRelationForm));
            lblRelacao = new Label();
            lblStatusBox = new Label();
            cbboxStatus = new ComboBox();
            lblStatus = new Label();
            lblAprovada = new Label();
            lblDuracao = new Label();
            lblResponsavel = new Label();
            lblDescricao = new Label();
            lblNome = new Label();
            lboxTasks = new ListBox();
            SuspendLayout();
            // 
            // lblRelacao
            // 
            lblRelacao.AutoSize = true;
            lblRelacao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblRelacao.Location = new Point(355, 28);
            lblRelacao.Name = "lblRelacao";
            lblRelacao.Size = new Size(71, 21);
            lblRelacao.TabIndex = 35;
            lblRelacao.Text = "Relação:";
            lblRelacao.Visible = false;
            // 
            // lblStatusBox
            // 
            lblStatusBox.AutoSize = true;
            lblStatusBox.Font = new Font("Segoe UI", 10F);
            lblStatusBox.Location = new Point(9, 31);
            lblStatusBox.Margin = new Padding(2, 0, 2, 0);
            lblStatusBox.Name = "lblStatusBox";
            lblStatusBox.Size = new Size(50, 19);
            lblStatusBox.TabIndex = 34;
            lblStatusBox.Text = "Status:";
            // 
            // cbboxStatus
            // 
            cbboxStatus.Font = new Font("Segoe UI", 10F);
            cbboxStatus.FormattingEnabled = true;
            cbboxStatus.Location = new Point(169, 29);
            cbboxStatus.Margin = new Padding(2);
            cbboxStatus.Name = "cbboxStatus";
            cbboxStatus.Size = new Size(162, 25);
            cbboxStatus.TabIndex = 33;
            cbboxStatus.SelectedIndexChanged += cbboxStatus_SelectedIndexChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblStatus.Location = new Point(355, 399);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(63, 21);
            lblStatus.TabIndex = 32;
            lblStatus.Text = "Status: ";
            lblStatus.Visible = false;
            // 
            // lblAprovada
            // 
            lblAprovada.AutoSize = true;
            lblAprovada.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAprovada.Location = new Point(355, 346);
            lblAprovada.Name = "lblAprovada";
            lblAprovada.Size = new Size(92, 21);
            lblAprovada.TabIndex = 31;
            lblAprovada.Text = "Aprovada? ";
            lblAprovada.Visible = false;
            // 
            // lblDuracao
            // 
            lblDuracao.AutoSize = true;
            lblDuracao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDuracao.Location = new Point(355, 292);
            lblDuracao.Name = "lblDuracao";
            lblDuracao.Size = new Size(125, 21);
            lblDuracao.TabIndex = 30;
            lblDuracao.Text = "Duração (dias) : ";
            lblDuracao.Visible = false;
            // 
            // lblResponsavel
            // 
            lblResponsavel.AutoSize = true;
            lblResponsavel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblResponsavel.Location = new Point(355, 247);
            lblResponsavel.Name = "lblResponsavel";
            lblResponsavel.Size = new Size(109, 21);
            lblResponsavel.TabIndex = 29;
            lblResponsavel.Text = "Responsável: ";
            lblResponsavel.Visible = false;
            // 
            // lblDescricao
            // 
            lblDescricao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDescricao.Location = new Point(355, 172);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(425, 63);
            lblDescricao.TabIndex = 28;
            lblDescricao.Text = "Descrição: ";
            lblDescricao.Visible = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblNome.Location = new Point(355, 119);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(63, 21);
            lblNome.TabIndex = 27;
            lblNome.Text = "Nome: ";
            lblNome.Visible = false;
            // 
            // lboxTasks
            // 
            lboxTasks.Font = new Font("Segoe UI", 11F);
            lboxTasks.FormattingEnabled = true;
            lboxTasks.ItemHeight = 20;
            lboxTasks.Location = new Point(9, 66);
            lboxTasks.Name = "lboxTasks";
            lboxTasks.Size = new Size(322, 404);
            lboxTasks.TabIndex = 26;
            lboxTasks.SelectedIndexChanged += lboxTasks_SelectedIndexChanged;
            // 
            // TaskRelationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 492);
            Controls.Add(lblRelacao);
            Controls.Add(lblStatusBox);
            Controls.Add(cbboxStatus);
            Controls.Add(lblStatus);
            Controls.Add(lblAprovada);
            Controls.Add(lblDuracao);
            Controls.Add(lblResponsavel);
            Controls.Add(lblDescricao);
            Controls.Add(lblNome);
            Controls.Add(lboxTasks);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TaskRelationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ver Relacionadas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblRelacao;
        private Label lblStatusBox;
        private ComboBox cbboxStatus;
        private Label lblStatus;
        private Label lblAprovada;
        private Label lblDuracao;
        private Label lblResponsavel;
        private Label lblDescricao;
        private Label lblNome;
        private ListBox lboxTasks;
    }
}