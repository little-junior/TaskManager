namespace UI.TaskFolder
{
    partial class TaskEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskEditForm));
            btnCancelar = new Button();
            btnSalvar = new Button();
            lblTempo = new Label();
            numericTempo = new NumericUpDown();
            cbboxResponsavel = new ComboBox();
            lblResponsavel = new Label();
            lblDescricao = new Label();
            lblNome = new Label();
            lblTitle = new Label();
            txtboxDescricao = new TextBox();
            txtboxNome = new TextBox();
            lblStatus = new Label();
            cbboxStatus = new ComboBox();
            lblRelacao = new Label();
            txtboxRelacao = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericTempo).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(755, 427);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 31);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSize = true;
            btnSalvar.Font = new Font("Segoe UI", 12F);
            btnSalvar.Location = new Point(627, 427);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(108, 31);
            btnSalvar.TabIndex = 26;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTempo.Location = new Point(38, 275);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(107, 21);
            lblTempo.TabIndex = 25;
            lblTempo.Text = "Tempo (dias):";
            // 
            // numericTempo
            // 
            numericTempo.Font = new Font("Segoe UI", 12F);
            numericTempo.Location = new Point(185, 275);
            numericTempo.Name = "numericTempo";
            numericTempo.Size = new Size(120, 29);
            numericTempo.TabIndex = 24;
            // 
            // cbboxResponsavel
            // 
            cbboxResponsavel.Font = new Font("Segoe UI", 12F);
            cbboxResponsavel.FormattingEnabled = true;
            cbboxResponsavel.Location = new Point(185, 215);
            cbboxResponsavel.Name = "cbboxResponsavel";
            cbboxResponsavel.Size = new Size(297, 29);
            cbboxResponsavel.TabIndex = 23;
            // 
            // lblResponsavel
            // 
            lblResponsavel.AutoSize = true;
            lblResponsavel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblResponsavel.Location = new Point(38, 215);
            lblResponsavel.Name = "lblResponsavel";
            lblResponsavel.Size = new Size(109, 21);
            lblResponsavel.TabIndex = 21;
            lblResponsavel.Text = "Responsável: ";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDescricao.Location = new Point(38, 125);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(85, 21);
            lblDescricao.TabIndex = 20;
            lblDescricao.Text = "Descrição:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblNome.Location = new Point(38, 86);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(63, 21);
            lblNome.TabIndex = 18;
            lblNome.Text = "Nome: ";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(9, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(157, 25);
            lblTitle.TabIndex = 17;
            lblTitle.Text = "Editar Tarefa";
            // 
            // txtboxDescricao
            // 
            txtboxDescricao.Font = new Font("Segoe UI", 12F);
            txtboxDescricao.Location = new Point(185, 125);
            txtboxDescricao.Multiline = true;
            txtboxDescricao.Name = "txtboxDescricao";
            txtboxDescricao.Size = new Size(349, 68);
            txtboxDescricao.TabIndex = 16;
            // 
            // txtboxNome
            // 
            txtboxNome.Font = new Font("Segoe UI", 12F);
            txtboxNome.Location = new Point(185, 83);
            txtboxNome.Name = "txtboxNome";
            txtboxNome.Size = new Size(349, 29);
            txtboxNome.TabIndex = 15;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblStatus.Location = new Point(38, 325);
            lblStatus.Margin = new Padding(2, 0, 2, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(59, 21);
            lblStatus.TabIndex = 28;
            lblStatus.Text = "Status:";
            lblStatus.TextAlign = ContentAlignment.TopCenter;
            // 
            // cbboxStatus
            // 
            cbboxStatus.Font = new Font("Segoe UI", 12F);
            cbboxStatus.FormattingEnabled = true;
            cbboxStatus.Location = new Point(185, 322);
            cbboxStatus.Margin = new Padding(2);
            cbboxStatus.Name = "cbboxStatus";
            cbboxStatus.Size = new Size(215, 29);
            cbboxStatus.TabIndex = 29;
            // 
            // lblRelacao
            // 
            lblRelacao.AutoSize = true;
            lblRelacao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblRelacao.Location = new Point(38, 379);
            lblRelacao.Margin = new Padding(2, 0, 2, 0);
            lblRelacao.Name = "lblRelacao";
            lblRelacao.Size = new Size(71, 21);
            lblRelacao.TabIndex = 30;
            lblRelacao.Text = "Relação:";
            lblRelacao.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtboxRelacao
            // 
            txtboxRelacao.Font = new Font("Segoe UI", 12F);
            txtboxRelacao.Location = new Point(185, 376);
            txtboxRelacao.Name = "txtboxRelacao";
            txtboxRelacao.Size = new Size(297, 29);
            txtboxRelacao.TabIndex = 31;
            // 
            // TaskEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 470);
            Controls.Add(txtboxRelacao);
            Controls.Add(lblRelacao);
            Controls.Add(cbboxStatus);
            Controls.Add(lblStatus);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(lblTempo);
            Controls.Add(numericTempo);
            Controls.Add(cbboxResponsavel);
            Controls.Add(lblResponsavel);
            Controls.Add(lblDescricao);
            Controls.Add(lblNome);
            Controls.Add(lblTitle);
            Controls.Add(txtboxDescricao);
            Controls.Add(txtboxNome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "TaskEditForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Tarefa";
            ((System.ComponentModel.ISupportInitialize)numericTempo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnSalvar;
        private Label lblTempo;
        private NumericUpDown numericTempo;
        private ComboBox cbboxResponsavel;
        private Label lblResponsavel;
        private Label lblDescricao;
        private Label lblNome;
        private Label lblTitle;
        private TextBox txtboxDescricao;
        private TextBox txtboxNome;
        private Label lblStatus;
        private ComboBox cbboxStatus;
        private Label lblRelacao;
        private TextBox txtboxRelacao;
    }
}