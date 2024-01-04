namespace UI.AdminFolder
{
    partial class AdminForm
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
            lblData = new Label();
            lblInfo = new Label();
            btnAddTechLeader = new Button();
            SuspendLayout();
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(23, 27);
            lblData.Name = "lblData";
            lblData.Size = new Size(38, 15);
            lblData.TabIndex = 0;
            lblData.Text = "label1";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(23, 73);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(83, 15);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Administrador";
            // 
            // btnAddTechLeader
            // 
            btnAddTechLeader.Location = new Point(273, 208);
            btnAddTechLeader.Name = "btnAddTechLeader";
            btnAddTechLeader.Size = new Size(209, 61);
            btnAddTechLeader.TabIndex = 2;
            btnAddTechLeader.Text = "Adicionar Tech Leader";
            btnAddTechLeader.UseVisualStyleBackColor = true;
            btnAddTechLeader.Click += btnAddTechLeader_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddTechLeader);
            Controls.Add(lblInfo);
            Controls.Add(lblData);
            Name = "AdminForm";
            Text = "AdminForm";
            FormClosed += AdminForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblData;
        private Label lblInfo;
        private Button btnAddTechLeader;
    }
}