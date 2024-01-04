namespace UI.AdminFolder
{
    partial class TechLeaderAdditionForm
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
            cbboxArea = new ComboBox();
            btnCancelar = new Button();
            btnAdicionar = new Button();
            txtboxEmail = new TextBox();
            txtboxNome = new TextBox();
            lblArea = new Label();
            lblEmail = new Label();
            lblNome = new Label();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // cbboxArea
            // 
            cbboxArea.FormattingEnabled = true;
            cbboxArea.Location = new Point(287, 237);
            cbboxArea.Name = "cbboxArea";
            cbboxArea.Size = new Size(178, 23);
            cbboxArea.TabIndex = 17;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(700, 402);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(581, 402);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 15;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtboxEmail
            // 
            txtboxEmail.Location = new Point(287, 193);
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.Size = new Size(239, 23);
            txtboxEmail.TabIndex = 14;
            // 
            // txtboxNome
            // 
            txtboxNome.Location = new Point(287, 154);
            txtboxNome.Name = "txtboxNome";
            txtboxNome.Size = new Size(239, 23);
            txtboxNome.TabIndex = 13;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(151, 240);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(37, 15);
            lblArea.TabIndex = 12;
            lblArea.Text = "Área: ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(151, 193);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 15);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email: ";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(151, 157);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(119, 15);
            lblNome.TabIndex = 10;
            lblNome.Text = "Nome e Sobrenome: ";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(25, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(123, 15);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Adicionar Tech Leader";
            // 
            // TechLeaderAdditionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbboxArea);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtboxEmail);
            Controls.Add(txtboxNome);
            Controls.Add(lblArea);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(lblTitle);
            Name = "TechLeaderAdditionForm";
            Text = "TechLeaderAdditionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbboxArea;
        private Button btnCancelar;
        private Button btnAdicionar;
        private TextBox txtboxEmail;
        private TextBox txtboxNome;
        private Label lblArea;
        private Label lblEmail;
        private Label lblNome;
        private Label lblTitle;
    }
}