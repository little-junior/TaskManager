namespace UI
{
    partial class TechLeaderForm
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
            btnAddDev = new Button();
            btnGerTasks = new Button();
            btnAddTask = new Button();
            lblData = new Label();
            lblInfos = new Label();
            SuspendLayout();
            // 
            // btnAddDev
            // 
            btnAddDev.Cursor = Cursors.Hand;
            btnAddDev.Font = new Font("Microsoft Sans Serif", 13F);
            btnAddDev.ForeColor = Color.Blue;
            btnAddDev.Location = new Point(444, 585);
            btnAddDev.Margin = new Padding(4, 5, 4, 5);
            btnAddDev.Name = "btnAddDev";
            btnAddDev.Size = new Size(301, 108);
            btnAddDev.TabIndex = 0;
            btnAddDev.Text = "Adicionar Desenvolvedor";
            btnAddDev.UseVisualStyleBackColor = true;
            btnAddDev.Click += btnAddDev_Click;
            // 
            // btnGerTasks
            // 
            btnGerTasks.Cursor = Cursors.Hand;
            btnGerTasks.Font = new Font("Microsoft Sans Serif", 13F);
            btnGerTasks.ForeColor = Color.Blue;
            btnGerTasks.Location = new Point(444, 398);
            btnGerTasks.Margin = new Padding(4, 5, 4, 5);
            btnGerTasks.Name = "btnGerTasks";
            btnGerTasks.Size = new Size(301, 108);
            btnGerTasks.TabIndex = 1;
            btnGerTasks.Text = "Gerenciar Tarefas";
            btnGerTasks.UseVisualStyleBackColor = true;
            btnGerTasks.Click += btnGerTasks_Click;
            // 
            // btnAddTask
            // 
            btnAddTask.Cursor = Cursors.Hand;
            btnAddTask.Font = new Font("Microsoft Sans Serif", 13F);
            btnAddTask.ForeColor = Color.Blue;
            btnAddTask.Location = new Point(444, 212);
            btnAddTask.Margin = new Padding(4, 5, 4, 5);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(301, 108);
            btnAddTask.TabIndex = 4;
            btnAddTask.Text = "Adicionar Tarefa";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
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
            lblData.TabIndex = 5;
            lblData.Text = "Data";
            lblData.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblInfos
            // 
            lblInfos.AutoSize = true;
            lblInfos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfos.Location = new Point(13, 118);
            lblInfos.Margin = new Padding(4, 0, 4, 0);
            lblInfos.Name = "lblInfos";
            lblInfos.Size = new Size(69, 29);
            lblInfos.TabIndex = 6;
            lblInfos.Text = "Infos";
            // 
            // TechLeaderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(lblInfos);
            Controls.Add(lblData);
            Controls.Add(btnAddTask);
            Controls.Add(btnGerTasks);
            Controls.Add(btnAddDev);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "TechLeaderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Início";
            FormClosed += TechLeaderForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddDev;
        private Button btnGerTasks;
        private Button btnAddTask;
        private Label lblData;
        private Label lblInfos;
    }
}