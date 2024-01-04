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
            button2 = new Button();
            lblData = new Label();
            lblInfos = new Label();
            btnAddTask = new Button();
            SuspendLayout();
            // 
            // btnAddDev
            // 
            btnAddDev.Cursor = Cursors.Hand;
            btnAddDev.Font = new Font("Segoe UI", 11F);
            btnAddDev.Location = new Point(282, 351);
            btnAddDev.Name = "btnAddDev";
            btnAddDev.Size = new Size(211, 65);
            btnAddDev.TabIndex = 0;
            btnAddDev.Text = "Adicionar Desenvolvedor";
            btnAddDev.UseVisualStyleBackColor = true;
            btnAddDev.Click += btnAddDev_Click;
            // 
            // button2
            // 
            button2.Location = new Point(282, 239);
            button2.Name = "button2";
            button2.Size = new Size(211, 65);
            button2.TabIndex = 1;
            button2.Text = "Gerenciar Tarefas";
            button2.UseVisualStyleBackColor = true;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(362, 9);
            lblData.Name = "lblData";
            lblData.Size = new Size(31, 15);
            lblData.TabIndex = 2;
            lblData.Text = "Data";
            lblData.Click += label1_Click;
            // 
            // lblInfos
            // 
            lblInfos.AutoSize = true;
            lblInfos.Location = new Point(12, 45);
            lblInfos.Name = "lblInfos";
            lblInfos.Size = new Size(33, 15);
            lblInfos.TabIndex = 3;
            lblInfos.Text = "Infos";
            // 
            // btnAddTask
            // 
            btnAddTask.Cursor = Cursors.Hand;
            btnAddTask.Font = new Font("Segoe UI", 11F);
            btnAddTask.Location = new Point(282, 127);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(211, 65);
            btnAddTask.TabIndex = 4;
            btnAddTask.Text = "Adicionar Tarefa";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // TechLeaderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddTask);
            Controls.Add(lblInfos);
            Controls.Add(lblData);
            Controls.Add(button2);
            Controls.Add(btnAddDev);
            Name = "TechLeaderForm";
            Text = "TaskManager";
            FormClosed += TechLeaderForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddDev;
        private Button button2;
        private Label lblData;
        private Label lblInfos;
        private Button btnAddTask;
    }
}