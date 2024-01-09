namespace UI.Task
{
    partial class TaskAdditionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskAdditionForm));
            radiobtnSim = new RadioButton();
            txtboxNome = new TextBox();
            txtboxDescricao = new TextBox();
            lblTitle = new Label();
            lblNome = new Label();
            lblAprovada = new Label();
            lblDescricao = new Label();
            lblResponsavel = new Label();
            radiobtnNao = new RadioButton();
            cbboxResponsavel = new ComboBox();
            numericTempo = new NumericUpDown();
            lblTempo = new Label();
            btnAdicionar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericTempo).BeginInit();
            SuspendLayout();
            // 
            // radiobtnSim
            // 
            radiobtnSim.AutoSize = true;
            radiobtnSim.Font = new Font("Segoe UI", 12F);
            radiobtnSim.Location = new Point(245, 570);
            radiobtnSim.Margin = new Padding(4, 5, 4, 5);
            radiobtnSim.Name = "radiobtnSim";
            radiobtnSim.Size = new Size(79, 36);
            radiobtnSim.TabIndex = 0;
            radiobtnSim.TabStop = true;
            radiobtnSim.Text = "Sim";
            radiobtnSim.UseVisualStyleBackColor = true;
            // 
            // txtboxNome
            // 
            txtboxNome.Font = new Font("Segoe UI", 12F);
            txtboxNome.Location = new Point(245, 141);
            txtboxNome.Margin = new Padding(4, 5, 4, 5);
            txtboxNome.Name = "txtboxNome";
            txtboxNome.Size = new Size(497, 39);
            txtboxNome.TabIndex = 1;
            // 
            // txtboxDescricao
            // 
            txtboxDescricao.Font = new Font("Segoe UI", 12F);
            txtboxDescricao.Location = new Point(245, 211);
            txtboxDescricao.Margin = new Padding(4, 5, 4, 5);
            txtboxDescricao.Multiline = true;
            txtboxDescricao.Name = "txtboxDescricao";
            txtboxDescricao.Size = new Size(497, 111);
            txtboxDescricao.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(13, 9);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(292, 36);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Adicionar Tarefa";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F);
            lblNome.Location = new Point(35, 146);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(92, 32);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome: ";
            // 
            // lblAprovada
            // 
            lblAprovada.AutoSize = true;
            lblAprovada.Font = new Font("Segoe UI", 12F);
            lblAprovada.Location = new Point(35, 570);
            lblAprovada.Margin = new Padding(4, 0, 4, 0);
            lblAprovada.Name = "lblAprovada";
            lblAprovada.Size = new Size(126, 32);
            lblAprovada.TabIndex = 5;
            lblAprovada.Text = "Aprovada?";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 12F);
            lblDescricao.Location = new Point(35, 211);
            lblDescricao.Margin = new Padding(4, 0, 4, 0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(121, 32);
            lblDescricao.TabIndex = 6;
            lblDescricao.Text = "Descrição:";
            // 
            // lblResponsavel
            // 
            lblResponsavel.AutoSize = true;
            lblResponsavel.Font = new Font("Segoe UI", 12F);
            lblResponsavel.Location = new Point(35, 360);
            lblResponsavel.Margin = new Padding(4, 0, 4, 0);
            lblResponsavel.Name = "lblResponsavel";
            lblResponsavel.Size = new Size(157, 32);
            lblResponsavel.TabIndex = 7;
            lblResponsavel.Text = "Responsável: ";
            // 
            // radiobtnNao
            // 
            radiobtnNao.AutoSize = true;
            radiobtnNao.Font = new Font("Segoe UI", 12F);
            radiobtnNao.Location = new Point(418, 570);
            radiobtnNao.Margin = new Padding(4, 5, 4, 5);
            radiobtnNao.Name = "radiobtnNao";
            radiobtnNao.Size = new Size(83, 36);
            radiobtnNao.TabIndex = 8;
            radiobtnNao.TabStop = true;
            radiobtnNao.Text = "Não";
            radiobtnNao.UseVisualStyleBackColor = true;
            // 
            // cbboxResponsavel
            // 
            cbboxResponsavel.Font = new Font("Segoe UI", 12F);
            cbboxResponsavel.FormattingEnabled = true;
            cbboxResponsavel.Location = new Point(245, 360);
            cbboxResponsavel.Margin = new Padding(4, 5, 4, 5);
            cbboxResponsavel.Name = "cbboxResponsavel";
            cbboxResponsavel.Size = new Size(423, 40);
            cbboxResponsavel.TabIndex = 9;
            // 
            // numericTempo
            // 
            numericTempo.Font = new Font("Segoe UI", 12F);
            numericTempo.Location = new Point(244, 459);
            numericTempo.Margin = new Padding(6, 8, 6, 8);
            numericTempo.Name = "numericTempo";
            numericTempo.Size = new Size(244, 39);
            numericTempo.TabIndex = 10;
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.Font = new Font("Segoe UI", 12F);
            lblTempo.Location = new Point(35, 461);
            lblTempo.Margin = new Padding(4, 0, 4, 0);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(155, 32);
            lblTempo.TabIndex = 11;
            lblTempo.Text = "Tempo (dias):";
            // 
            // btnAdicionar
            // 
            btnAdicionar.AutoSize = true;
            btnAdicionar.Font = new Font("Segoe UI", 12F);
            btnAdicionar.Location = new Point(786, 667);
            btnAdicionar.Margin = new Padding(4, 5, 4, 5);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(137, 47);
            btnAdicionar.TabIndex = 12;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(984, 667);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 47);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // TaskAdditionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdicionar);
            Controls.Add(lblTempo);
            Controls.Add(numericTempo);
            Controls.Add(cbboxResponsavel);
            Controls.Add(radiobtnNao);
            Controls.Add(lblResponsavel);
            Controls.Add(lblDescricao);
            Controls.Add(lblAprovada);
            Controls.Add(lblNome);
            Controls.Add(lblTitle);
            Controls.Add(txtboxDescricao);
            Controls.Add(txtboxNome);
            Controls.Add(radiobtnSim);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "TaskAdditionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Tarefa";
            ((System.ComponentModel.ISupportInitialize)numericTempo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radiobtnSim;
        private TextBox txtboxNome;
        private TextBox txtboxDescricao;
        private Label lblTitle;
        private Label lblNome;
        private Label lblAprovada;
        private Label lblDescricao;
        private Label lblResponsavel;
        private RadioButton radiobtnNao;
        private ComboBox cbboxResponsavel;
        private NumericUpDown numericTempo;
        private Label lblTempo;
        private Button btnAdicionar;
        private Button btnCancelar;
    }
}