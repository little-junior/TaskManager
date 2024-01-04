namespace UI.TechLeader
{
    partial class DeveloperAdditionForm
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
            lblTitle = new Label();
            lblNome = new Label();
            lblEmail = new Label();
            lblArea = new Label();
            txtboxNome = new TextBox();
            txtboxEmail = new TextBox();
            btnAdicionar = new Button();
            btnCancelar = new Button();
            cbboxArea = new ComboBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(139, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Adicionar Desenvolvedor";
            
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(177, 151);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(46, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome: ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(177, 187);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email: ";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(177, 234);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(37, 15);
            lblArea.TabIndex = 3;
            lblArea.Text = "Área: ";
            
            // 
            // txtboxNome
            // 
            txtboxNome.Location = new Point(263, 148);
            txtboxNome.Name = "txtboxNome";
            txtboxNome.Size = new Size(199, 23);
            txtboxNome.TabIndex = 4;
            // 
            // txtboxEmail
            // 
            txtboxEmail.Location = new Point(263, 187);
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.Size = new Size(199, 23);
            txtboxEmail.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(568, 396);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(687, 396);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cbboxArea
            // 
            cbboxArea.FormattingEnabled = true;
            cbboxArea.Location = new Point(263, 231);
            cbboxArea.Name = "cbboxArea";
            cbboxArea.Size = new Size(199, 23);
            cbboxArea.TabIndex = 8;
            // 
            // DeveloperAdditionForm
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
            Name = "DeveloperAdditionForm";
            Text = "DeveloperAdditionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblNome;
        private Label lblEmail;
        private Label lblArea;
        private TextBox txtboxNome;
        private TextBox txtboxEmail;
        private Button btnAdicionar;
        private Button btnCancelar;
        private ComboBox cbboxArea;
    }
}