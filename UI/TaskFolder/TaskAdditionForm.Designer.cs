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
            lblRelacao = new Label();
            txtboxRelacao = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericTempo).BeginInit();
            SuspendLayout();
            // 
            // radiobtnSim
            // 
            radiobtnSim.AutoSize = true;
            radiobtnSim.Font = new Font("Segoe UI", 12F);
            radiobtnSim.Location = new Point(172, 342);
            radiobtnSim.Name = "radiobtnSim";
            radiobtnSim.Size = new Size(55, 25);
            radiobtnSim.TabIndex = 0;
            radiobtnSim.TabStop = true;
            radiobtnSim.Text = "Sim";
            radiobtnSim.UseVisualStyleBackColor = true;
            // 
            // txtboxNome
            // 
            txtboxNome.Font = new Font("Segoe UI", 12F);
            txtboxNome.Location = new Point(172, 85);
            txtboxNome.Name = "txtboxNome";
            txtboxNome.Size = new Size(349, 29);
            txtboxNome.TabIndex = 1;
            // 
            // txtboxDescricao
            // 
            txtboxDescricao.Font = new Font("Segoe UI", 12F);
            txtboxDescricao.Location = new Point(172, 127);
            txtboxDescricao.Multiline = true;
            txtboxDescricao.Name = "txtboxDescricao";
            txtboxDescricao.Size = new Size(349, 68);
            txtboxDescricao.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(9, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(197, 25);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Adicionar Tarefa";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblNome.Location = new Point(24, 88);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(63, 21);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome: ";
            // 
            // lblAprovada
            // 
            lblAprovada.AutoSize = true;
            lblAprovada.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAprovada.Location = new Point(24, 342);
            lblAprovada.Name = "lblAprovada";
            lblAprovada.Size = new Size(88, 21);
            lblAprovada.TabIndex = 5;
            lblAprovada.Text = "Aprovada?";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDescricao.Location = new Point(24, 127);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(85, 21);
            lblDescricao.TabIndex = 6;
            lblDescricao.Text = "Descrição:";
            // 
            // lblResponsavel
            // 
            lblResponsavel.AutoSize = true;
            lblResponsavel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblResponsavel.Location = new Point(24, 216);
            lblResponsavel.Name = "lblResponsavel";
            lblResponsavel.Size = new Size(109, 21);
            lblResponsavel.TabIndex = 7;
            lblResponsavel.Text = "Responsável: ";
            // 
            // radiobtnNao
            // 
            radiobtnNao.AutoSize = true;
            radiobtnNao.Font = new Font("Segoe UI", 12F);
            radiobtnNao.Location = new Point(293, 342);
            radiobtnNao.Name = "radiobtnNao";
            radiobtnNao.Size = new Size(57, 25);
            radiobtnNao.TabIndex = 8;
            radiobtnNao.TabStop = true;
            radiobtnNao.Text = "Não";
            radiobtnNao.UseVisualStyleBackColor = true;
            // 
            // cbboxResponsavel
            // 
            cbboxResponsavel.Font = new Font("Segoe UI", 12F);
            cbboxResponsavel.FormattingEnabled = true;
            cbboxResponsavel.Location = new Point(172, 216);
            cbboxResponsavel.Name = "cbboxResponsavel";
            cbboxResponsavel.Size = new Size(297, 29);
            cbboxResponsavel.TabIndex = 9;
            // 
            // numericTempo
            // 
            numericTempo.Font = new Font("Segoe UI", 12F);
            numericTempo.Location = new Point(171, 275);
            numericTempo.Margin = new Padding(4, 5, 4, 5);
            numericTempo.Name = "numericTempo";
            numericTempo.Size = new Size(171, 29);
            numericTempo.TabIndex = 10;
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTempo.Location = new Point(24, 277);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(107, 21);
            lblTempo.TabIndex = 11;
            lblTempo.Text = "Tempo (dias):";
            // 
            // btnAdicionar
            // 
            btnAdicionar.AutoSize = true;
            btnAdicionar.Font = new Font("Segoe UI", 12F);
            btnAdicionar.Location = new Point(638, 450);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(96, 31);
            btnAdicionar.TabIndex = 12;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(756, 450);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 31);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblRelacao
            // 
            lblRelacao.AutoSize = true;
            lblRelacao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblRelacao.Location = new Point(24, 395);
            lblRelacao.Name = "lblRelacao";
            lblRelacao.Size = new Size(71, 21);
            lblRelacao.TabIndex = 14;
            lblRelacao.Text = "Relação:";
            // 
            // txtboxRelacao
            // 
            txtboxRelacao.Font = new Font("Segoe UI", 12F);
            txtboxRelacao.Location = new Point(172, 395);
            txtboxRelacao.Name = "txtboxRelacao";
            txtboxRelacao.Size = new Size(297, 29);
            txtboxRelacao.TabIndex = 15;
            // 
            // TaskAdditionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 493);
            Controls.Add(txtboxRelacao);
            Controls.Add(lblRelacao);
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
        private Label lblRelacao;
        private TextBox txtboxRelacao;
    }
}