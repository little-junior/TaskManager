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
            btnAddTask.BackColor = Color.Transparent;
            btnAddTask.Cursor = Cursors.Hand;
            btnAddTask.Font = new Font("Microsoft Sans Serif", 13F);
            btnAddTask.ForeColor = Color.Blue;
            btnAddTask.Location = new Point(444, 482);
            btnAddTask.Margin = new Padding(4, 5, 4, 5);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(253, 85);
            btnAddTask.TabIndex = 0;
            btnAddTask.Text = "Adicionar Tarefa";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Microsoft Sans Serif", 13F);
            button2.ForeColor = Color.Blue;
            button2.Location = new Point(444, 294);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(253, 85);
            button2.TabIndex = 1;
            button2.Text = "Ver Tarefas";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Cursor = Cursors.Hand;
            lblData.Font = new Font("Verdana", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblData.ForeColor = Color.FromArgb(64, 64, 64);
            lblData.Location = new Point(403, 9);
            lblData.Margin = new Padding(4, 0, 4, 0);
            lblData.Name = "lblData";
            lblData.Size = new Size(70, 26);
            lblData.TabIndex = 2;
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
            lblInfos.TabIndex = 3;
            lblInfos.Text = "Infos";
            // 
            // DeveloperForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1143, 750);
            Controls.Add(lblInfos);
            Controls.Add(lblData);
            Controls.Add(button2);
            Controls.Add(btnAddTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "DeveloperForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Início";
            FormClosed += DeveloperForm_FormClosed;
            Load += DeveloperForm_Load;
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