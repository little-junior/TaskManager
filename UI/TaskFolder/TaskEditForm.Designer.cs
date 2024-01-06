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
            ((System.ComponentModel.ISupportInitialize)numericTempo).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1024, 649);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 38);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(867, 649);
            btnSalvar.Margin = new Padding(4, 5, 4, 5);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(107, 38);
            btnSalvar.TabIndex = 26;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.Location = new Point(85, 420);
            lblTempo.Margin = new Padding(4, 0, 4, 0);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(117, 25);
            lblTempo.TabIndex = 25;
            lblTempo.Text = "Tempo (dias):";
            // 
            // numericTempo
            // 
            numericTempo.Location = new Point(295, 420);
            numericTempo.Margin = new Padding(4, 5, 4, 5);
            numericTempo.Name = "numericTempo";
            numericTempo.Size = new Size(171, 31);
            numericTempo.TabIndex = 24;
            // 
            // cbboxResponsavel
            // 
            cbboxResponsavel.FormattingEnabled = true;
            cbboxResponsavel.Location = new Point(295, 319);
            cbboxResponsavel.Margin = new Padding(4, 5, 4, 5);
            cbboxResponsavel.Name = "cbboxResponsavel";
            cbboxResponsavel.Size = new Size(423, 33);
            cbboxResponsavel.TabIndex = 23;
            // 
            // lblResponsavel
            // 
            lblResponsavel.AutoSize = true;
            lblResponsavel.Location = new Point(85, 319);
            lblResponsavel.Margin = new Padding(4, 0, 4, 0);
            lblResponsavel.Name = "lblResponsavel";
            lblResponsavel.Size = new Size(119, 25);
            lblResponsavel.TabIndex = 21;
            lblResponsavel.Text = "Responsável: ";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(85, 170);
            lblDescricao.Margin = new Padding(4, 0, 4, 0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(92, 25);
            lblDescricao.TabIndex = 20;
            lblDescricao.Text = "Descrição:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(85, 105);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(70, 25);
            lblNome.TabIndex = 18;
            lblNome.Text = "Nome: ";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(13, 19);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(108, 25);
            lblTitle.TabIndex = 17;
            lblTitle.Text = "Editar Tarefa";
            // 
            // txtboxDescricao
            // 
            txtboxDescricao.Location = new Point(295, 170);
            txtboxDescricao.Margin = new Padding(4, 5, 4, 5);
            txtboxDescricao.Multiline = true;
            txtboxDescricao.Name = "txtboxDescricao";
            txtboxDescricao.Size = new Size(497, 111);
            txtboxDescricao.TabIndex = 16;
            // 
            // txtboxNome
            // 
            txtboxNome.Location = new Point(295, 100);
            txtboxNome.Margin = new Padding(4, 5, 4, 5);
            txtboxNome.Name = "txtboxNome";
            txtboxNome.Size = new Size(497, 31);
            txtboxNome.TabIndex = 15;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(92, 503);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(64, 25);
            lblStatus.TabIndex = 28;
            lblStatus.Text = "Status:";
            lblStatus.TextAlign = ContentAlignment.TopCenter;
            // 
            // cbboxStatus
            // 
            cbboxStatus.FormattingEnabled = true;
            cbboxStatus.Location = new Point(295, 500);
            cbboxStatus.Name = "cbboxStatus";
            cbboxStatus.Size = new Size(305, 33);
            cbboxStatus.TabIndex = 29;
            // 
            // TaskEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 702);
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
            Name = "TaskEditForm";
            Text = "TaskEditForm";
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
    }
}