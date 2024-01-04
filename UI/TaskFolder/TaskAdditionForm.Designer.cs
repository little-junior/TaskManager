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
            radiobtnSim.Location = new Point(178, 322);
            radiobtnSim.Name = "radiobtnSim";
            radiobtnSim.Size = new Size(45, 19);
            radiobtnSim.TabIndex = 0;
            radiobtnSim.TabStop = true;
            radiobtnSim.Text = "Sim";
            radiobtnSim.UseVisualStyleBackColor = true;
            // 
            // txtboxNome
            // 
            txtboxNome.Location = new Point(178, 65);
            txtboxNome.Name = "txtboxNome";
            txtboxNome.Size = new Size(349, 23);
            txtboxNome.TabIndex = 1;
            // 
            // txtboxDescricao
            // 
            txtboxDescricao.Location = new Point(178, 107);
            txtboxDescricao.Multiline = true;
            txtboxDescricao.Name = "txtboxDescricao";
            txtboxDescricao.Size = new Size(349, 68);
            txtboxDescricao.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(20, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(92, 15);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Adicionar Tarefa";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(31, 68);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(46, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome: ";
            // 
            // lblAprovada
            // 
            lblAprovada.AutoSize = true;
            lblAprovada.Location = new Point(31, 322);
            lblAprovada.Name = "lblAprovada";
            lblAprovada.Size = new Size(63, 15);
            lblAprovada.TabIndex = 5;
            lblAprovada.Text = "Aprovada?";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(31, 107);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 6;
            lblDescricao.Text = "Descrição:";
            // 
            // lblResponsavel
            // 
            lblResponsavel.AutoSize = true;
            lblResponsavel.Location = new Point(31, 196);
            lblResponsavel.Name = "lblResponsavel";
            lblResponsavel.Size = new Size(78, 15);
            lblResponsavel.TabIndex = 7;
            lblResponsavel.Text = "Responsável: ";
            // 
            // radiobtnNao
            // 
            radiobtnNao.AutoSize = true;
            radiobtnNao.Location = new Point(299, 322);
            radiobtnNao.Name = "radiobtnNao";
            radiobtnNao.Size = new Size(47, 19);
            radiobtnNao.TabIndex = 8;
            radiobtnNao.TabStop = true;
            radiobtnNao.Text = "Não";
            radiobtnNao.UseVisualStyleBackColor = true;
            // 
            // cbboxResponsavel
            // 
            cbboxResponsavel.FormattingEnabled = true;
            cbboxResponsavel.Location = new Point(178, 196);
            cbboxResponsavel.Name = "cbboxResponsavel";
            cbboxResponsavel.Size = new Size(297, 23);
            cbboxResponsavel.TabIndex = 9;
            // 
            // numericTempo
            // 
            numericTempo.Location = new Point(178, 257);
            numericTempo.Name = "numericTempo";
            numericTempo.Size = new Size(120, 23);
            numericTempo.TabIndex = 10;
            // 
            // lblTempo
            // 
            lblTempo.AutoSize = true;
            lblTempo.Location = new Point(31, 257);
            lblTempo.Name = "lblTempo";
            lblTempo.Size = new Size(78, 15);
            lblTempo.TabIndex = 11;
            lblTempo.Text = "Tempo (dias):";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(578, 394);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 12;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(688, 394);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TaskAdditionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "TaskAdditionForm";
            Text = "TaskAdditionForm";
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