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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechLeaderAdditionForm));
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
            cbboxArea.Location = new Point(443, 388);
            cbboxArea.Margin = new Padding(5, 6, 5, 6);
            cbboxArea.Name = "cbboxArea";
            cbboxArea.Size = new Size(328, 29);
            cbboxArea.TabIndex = 17;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(851, 501);
            btnCancelar.Margin = new Padding(5, 6, 5, 6);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(157, 46);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(663, 501);
            btnAdicionar.Margin = new Padding(5, 6, 5, 6);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(157, 46);
            btnAdicionar.TabIndex = 15;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtboxEmail
            // 
            txtboxEmail.Location = new Point(443, 294);
            txtboxEmail.Margin = new Padding(5, 6, 5, 6);
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.Size = new Size(441, 29);
            txtboxEmail.TabIndex = 14;
            // 
            // txtboxNome
            // 
            txtboxNome.Location = new Point(443, 211);
            txtboxNome.Margin = new Padding(5, 6, 5, 6);
            txtboxNome.Name = "txtboxNome";
            txtboxNome.Size = new Size(441, 29);
            txtboxNome.TabIndex = 13;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Segoe UI", 12F);
            lblArea.Location = new Point(114, 391);
            lblArea.Margin = new Padding(5, 0, 5, 0);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(49, 21);
            lblArea.TabIndex = 12;
            lblArea.Text = "Área: ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(114, 291);
            lblEmail.Margin = new Padding(5, 0, 5, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 21);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email: ";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F);
            lblNome.Location = new Point(114, 214);
            lblNome.Margin = new Padding(5, 0, 5, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(157, 21);
            lblNome.TabIndex = 10;
            lblNome.Text = "Nome e Sobrenome: ";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(47, 54);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(262, 25);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Adicionar Tech Leader";
            // 
            // TechLeaderAdditionForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
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
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "TechLeaderAdditionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar TechLeader";
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