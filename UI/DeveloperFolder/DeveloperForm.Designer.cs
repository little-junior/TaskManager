namespace UI.Developer
{
    partial class DeveloperForm
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
            btnAddTask = new Button();
            button2 = new Button();
            lblData = new Label();
            lblInfos = new Label();
            SuspendLayout();
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(292, 282);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(177, 51);
            btnAddTask.TabIndex = 0;
            btnAddTask.Text = "Adicionar Tarefa";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // button2
            // 
            button2.Location = new Point(292, 169);
            button2.Name = "button2";
            button2.Size = new Size(177, 51);
            button2.TabIndex = 1;
            button2.Text = "Ver Tarefas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(12, 20);
            lblData.Name = "lblData";
            lblData.Size = new Size(31, 15);
            lblData.TabIndex = 2;
            lblData.Text = "Data";
            // 
            // lblInfos
            // 
            lblInfos.AutoSize = true;
            lblInfos.Location = new Point(12, 54);
            lblInfos.Name = "lblInfos";
            lblInfos.Size = new Size(33, 15);
            lblInfos.TabIndex = 3;
            lblInfos.Text = "Infos";
            // 
            // DeveloperForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInfos);
            Controls.Add(lblData);
            Controls.Add(button2);
            Controls.Add(btnAddTask);
            Name = "DeveloperForm";
            Text = "DeveloperForm";
            FormClosed += DeveloperForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddTask;
        private Button button2;
        private Label lblData;
        private Label lblInfos;
    }
}