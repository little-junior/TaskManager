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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            lblData = new Label();
            btnAddTechLeader = new Button();
            lblInfos = new Label();
            SuspendLayout();
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Verdana", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblData.ForeColor = Color.FromArgb(64, 64, 64);
            lblData.Location = new Point(403, 9);
            lblData.Margin = new Padding(4, 0, 4, 0);
            lblData.Name = "lblData";
            lblData.Size = new Size(70, 26);
            lblData.TabIndex = 0;
            lblData.Text = "Data";
            // 
            // btnAddTechLeader
            // 
            btnAddTechLeader.Cursor = Cursors.Hand;
            btnAddTechLeader.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddTechLeader.ForeColor = Color.Blue;
            btnAddTechLeader.Location = new Point(403, 344);
            btnAddTechLeader.Margin = new Padding(4, 5, 4, 5);
            btnAddTechLeader.Name = "btnAddTechLeader";
            btnAddTechLeader.Size = new Size(336, 118);
            btnAddTechLeader.TabIndex = 2;
            btnAddTechLeader.Text = "Adicionar Tech Leader";
            btnAddTechLeader.UseVisualStyleBackColor = true;
            btnAddTechLeader.Click += btnAddTechLeader_Click;
            // 
            // lblInfos
            // 
            lblInfos.AutoSize = true;
            lblInfos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfos.Location = new Point(13, 118);
            lblInfos.Margin = new Padding(4, 0, 4, 0);
            lblInfos.Name = "lblInfos";
            lblInfos.Size = new Size(175, 29);
            lblInfos.TabIndex = 7;
            lblInfos.Text = "Administrador";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(lblInfos);
            Controls.Add(btnAddTechLeader);
            Controls.Add(lblData);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Início";
            FormClosed += AdminForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblData;
        private Button btnAddTechLeader;
        private Label lblInfos;
    }
}