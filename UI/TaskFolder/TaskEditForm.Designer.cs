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
            btnCancelar.AutoSize = true;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(1047, 642);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(123, 46);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSize = true;
            btnSalvar.Font = new Font("Segoe UI", 12F);
            btnSalvar.Location = new Point(886, 642);
            btnSalvar.Margin = new Padding(4, 5, 4, 5);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(115, 46);
            btnSalvar.TabIndex = 26;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.Font = new Font("Segoe UI", 12F);
            lblTempo.Location = new Point(54, 459);
            lblTempo.Margin = new Padding(4, 0, 4, 0);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(155, 32);
            lblTempo.TabIndex = 25;
            lblTempo.Text = "Tempo (dias):";
            // 
            // numericTempo
            // 
            numericTempo.Font = new Font("Segoe UI", 12F);
            numericTempo.Location = new Point(264, 459);
            numericTempo.Margin = new Padding(4, 5, 4, 5);
            numericTempo.Name = "numericTempo";
            numericTempo.Size = new Size(171, 39);
            numericTempo.TabIndex = 24;
            // 
            // cbboxResponsavel
            // 
            cbboxResponsavel.Font = new Font("Segoe UI", 12F);
            cbboxResponsavel.FormattingEnabled = true;
            cbboxResponsavel.Location = new Point(264, 358);
            cbboxResponsavel.Margin = new Padding(4, 5, 4, 5);
            cbboxResponsavel.Name = "cbboxResponsavel";
            cbboxResponsavel.Size = new Size(423, 40);
            cbboxResponsavel.TabIndex = 23;
            // 
            // lblResponsavel
            // 
            lblResponsavel.AutoSize = true;
            lblResponsavel.Font = new Font("Segoe UI", 12F);
            lblResponsavel.Location = new Point(54, 358);
            lblResponsavel.Margin = new Padding(4, 0, 4, 0);
            lblResponsavel.Name = "lblResponsavel";
            lblResponsavel.Size = new Size(157, 32);
            lblResponsavel.TabIndex = 21;
            lblResponsavel.Text = "Responsável: ";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 12F);
            lblDescricao.Location = new Point(54, 209);
            lblDescricao.Margin = new Padding(4, 0, 4, 0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(121, 32);
            lblDescricao.TabIndex = 20;
            lblDescricao.Text = "Descrição:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F);
            lblNome.Location = new Point(54, 144);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(92, 32);
            lblNome.TabIndex = 18;
            lblNome.Text = "Nome: ";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(13, 9);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(234, 36);
            lblTitle.TabIndex = 17;
            lblTitle.Text = "Editar Tarefa";
            // 
            // txtboxDescricao
            // 
            txtboxDescricao.Font = new Font("Segoe UI", 12F);
            txtboxDescricao.Location = new Point(264, 209);
            txtboxDescricao.Margin = new Padding(4, 5, 4, 5);
            txtboxDescricao.Multiline = true;
            txtboxDescricao.Name = "txtboxDescricao";
            txtboxDescricao.Size = new Size(497, 111);
            txtboxDescricao.TabIndex = 16;
            // 
            // txtboxNome
            // 
            txtboxNome.Font = new Font("Segoe UI", 12F);
            txtboxNome.Location = new Point(264, 139);
            txtboxNome.Margin = new Padding(4, 5, 4, 5);
            txtboxNome.Name = "txtboxNome";
            txtboxNome.Size = new Size(497, 39);
            txtboxNome.TabIndex = 15;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 12F);
            lblStatus.Location = new Point(54, 541);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(83, 32);
            lblStatus.TabIndex = 28;
            lblStatus.Text = "Status:";
            lblStatus.TextAlign = ContentAlignment.TopCenter;
            // 
            // cbboxStatus
            // 
            cbboxStatus.Font = new Font("Segoe UI", 12F);
            cbboxStatus.FormattingEnabled = true;
            cbboxStatus.Location = new Point(257, 538);
            cbboxStatus.Name = "cbboxStatus";
            cbboxStatus.Size = new Size(305, 40);
            cbboxStatus.TabIndex = 29;
            // 
            // TaskEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 702);
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
    }
}