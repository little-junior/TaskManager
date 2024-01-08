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
            lblData = new Label();
            lblInfos = new Label();
            btnAddTask = new Button();
            SuspendLayout();
            // 
            // btnAddDev
            // 
            btnAddDev.Cursor = Cursors.Hand;
            btnAddDev.Font = new Font("Segoe UI", 11F);
            btnAddDev.Location = new Point(403, 585);
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
            btnGerTasks.Location = new Point(403, 398);
            btnGerTasks.Margin = new Padding(4, 5, 4, 5);
            btnGerTasks.Name = "btnGerTasks";
            btnGerTasks.Size = new Size(301, 108);
            btnGerTasks.TabIndex = 1;
            btnGerTasks.Text = "Gerenciar Tarefas";
            btnGerTasks.UseVisualStyleBackColor = true;
            btnGerTasks.Click += btnGerTasks_Click;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(517, 15);
            lblData.Margin = new Padding(4, 0, 4, 0);
            lblData.Name = "lblData";
            lblData.Size = new Size(49, 25);
            lblData.TabIndex = 2;
            lblData.Text = "Data";
            // 
            // lblInfos
            // 
            lblInfos.AutoSize = true;
            lblInfos.Location = new Point(17, 75);
            lblInfos.Margin = new Padding(4, 0, 4, 0);
            lblInfos.Name = "lblInfos";
            lblInfos.Size = new Size(52, 25);
            lblInfos.TabIndex = 3;
            lblInfos.Text = "Infos";
            // 
            // btnAddTask
            // 
            btnAddTask.Cursor = Cursors.Hand;
            btnAddTask.Font = new Font("Segoe UI", 11F);
            btnAddTask.Location = new Point(403, 212);
            btnAddTask.Margin = new Padding(4, 5, 4, 5);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(301, 108);
            btnAddTask.TabIndex = 4;
            btnAddTask.Text = "Adicionar Tarefa";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // TechLeaderForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnAddTask);
            Controls.Add(lblInfos);
            Controls.Add(lblData);
            Controls.Add(btnGerTasks);
            Controls.Add(btnAddDev);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "TechLeaderForm";
            Text = "Início";
            FormClosed += TechLeaderForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddDev;
        private Button btnGerTasks;
        private Label lblData;
        private Label lblInfos;
        private Button btnAddTask;
    }
}