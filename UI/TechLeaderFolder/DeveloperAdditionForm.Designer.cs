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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeveloperAdditionForm));
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
            lblTitle.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(24, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(293, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Adicionar Desenvolvedor";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblNome.Location = new Point(114, 214);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(166, 21);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome e Sobrenome: ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblEmail.Location = new Point(114, 291);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(56, 21);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email: ";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblArea.Location = new Point(114, 391);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(52, 21);
            lblArea.TabIndex = 3;
            lblArea.Text = "Área: ";
            // 
            // txtboxNome
            // 
            txtboxNome.Font = new Font("Segoe UI", 12F);
            txtboxNome.Location = new Point(368, 211);
            txtboxNome.Name = "txtboxNome";
            txtboxNome.Size = new Size(441, 29);
            txtboxNome.TabIndex = 4;
            // 
            // txtboxEmail
            // 
            txtboxEmail.Font = new Font("Segoe UI", 12F);
            txtboxEmail.Location = new Point(368, 288);
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.Size = new Size(441, 29);
            txtboxEmail.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Segoe UI", 12F);
            btnAdicionar.Location = new Point(663, 513);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(146, 34);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(851, 513);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(146, 34);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cbboxArea
            // 
            cbboxArea.Font = new Font("Segoe UI", 12F);
            cbboxArea.FormattingEnabled = true;
            cbboxArea.Location = new Point(368, 388);
            cbboxArea.Name = "cbboxArea";
            cbboxArea.Size = new Size(328, 29);
            cbboxArea.TabIndex = 8;
            // 
            // DeveloperAdditionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 562);
            Controls.Add(cbboxArea);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtboxEmail);
            Controls.Add(txtboxNome);
            Controls.Add(lblArea);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DeveloperAdditionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Desenvolvedor";
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