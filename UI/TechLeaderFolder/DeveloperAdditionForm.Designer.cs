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
            lblTitle.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(47, 54);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(436, 36);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Adicionar Desenvolvedor";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F);
            lblNome.Location = new Point(288, 345);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(243, 32);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome e Sobrenome: ";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(288, 422);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(83, 32);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email: ";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Segoe UI", 12F);
            lblArea.Location = new Point(288, 522);
            lblArea.Margin = new Padding(4, 0, 4, 0);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(74, 32);
            lblArea.TabIndex = 3;
            lblArea.Text = "Área: ";
            // 
            // txtboxNome
            // 
            txtboxNome.Font = new Font("Segoe UI", 12F);
            txtboxNome.Location = new Point(617, 342);
            txtboxNome.Margin = new Padding(4, 5, 4, 5);
            txtboxNome.Name = "txtboxNome";
            txtboxNome.Size = new Size(386, 39);
            txtboxNome.TabIndex = 4;
            // 
            // txtboxEmail
            // 
            txtboxEmail.Font = new Font("Segoe UI", 12F);
            txtboxEmail.Location = new Point(617, 425);
            txtboxEmail.Margin = new Padding(4, 5, 4, 5);
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.Size = new Size(386, 39);
            txtboxEmail.TabIndex = 5;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Segoe UI", 12F);
            btnAdicionar.Location = new Point(1079, 861);
            btnAdicionar.Margin = new Padding(4, 5, 4, 5);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(157, 46);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(1300, 861);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(157, 46);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cbboxArea
            // 
            cbboxArea.Font = new Font("Segoe UI", 12F);
            cbboxArea.FormattingEnabled = true;
            cbboxArea.Location = new Point(617, 519);
            cbboxArea.Margin = new Padding(4, 5, 4, 5);
            cbboxArea.Name = "cbboxArea";
            cbboxArea.Size = new Size(328, 40);
            cbboxArea.TabIndex = 8;
            // 
            // DeveloperAdditionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1532, 960);
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
            Margin = new Padding(4, 5, 4, 5);
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