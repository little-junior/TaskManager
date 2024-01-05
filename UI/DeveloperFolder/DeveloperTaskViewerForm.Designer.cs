namespace UI.DeveloperFolder
{
    partial class DeveloperTaskViewerForm
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
            lboxTasks = new ListBox();
            lblNome = new Label();
            lblDescricao = new Label();
            lblResponsavel = new Label();
            lblDuracao = new Label();
            lblAprovada = new Label();
            lblStatus = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // lboxTasks
            // 
            lboxTasks.FormattingEnabled = true;
            lboxTasks.ItemHeight = 15;
            lboxTasks.Location = new Point(12, 14);
            lboxTasks.Name = "lboxTasks";
            lboxTasks.Size = new Size(322, 319);
            lboxTasks.TabIndex = 0;
            lboxTasks.SelectedIndexChanged += lboxTasks_SelectedIndexChanged;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(354, 49);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(46, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome: ";
            lblNome.Visible = false;
            // 
            // lblDescricao
            // 
            lblDescricao.Location = new Point(354, 86);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(425, 63);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição: ";
            lblDescricao.Visible = false;
            // 
            // lblResponsavel
            // 
            lblResponsavel.AutoSize = true;
            lblResponsavel.Location = new Point(354, 162);
            lblResponsavel.Name = "lblResponsavel";
            lblResponsavel.Size = new Size(78, 15);
            lblResponsavel.TabIndex = 3;
            lblResponsavel.Text = "Responsável: ";
            lblResponsavel.Visible = false;
            // 
            // lblDuracao
            // 
            lblDuracao.AutoSize = true;
            lblDuracao.Location = new Point(354, 196);
            lblDuracao.Name = "lblDuracao";
            lblDuracao.Size = new Size(92, 15);
            lblDuracao.TabIndex = 4;
            lblDuracao.Text = "Duração (dias) : ";
            lblDuracao.Visible = false;
            // 
            // lblAprovada
            // 
            lblAprovada.AutoSize = true;
            lblAprovada.Location = new Point(352, 228);
            lblAprovada.Name = "lblAprovada";
            lblAprovada.Size = new Size(66, 15);
            lblAprovada.TabIndex = 5;
            lblAprovada.Text = "Aprovada? ";
            lblAprovada.Visible = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(355, 286);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(45, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status: ";
            lblStatus.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(12, 350);
            button1.Name = "button1";
            button1.Size = new Size(59, 23);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(102, 350);
            button2.Name = "button2";
            button2.Size = new Size(59, 23);
            button2.TabIndex = 8;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 411);
            button3.Name = "button3";
            button3.Size = new Size(59, 23);
            button3.TabIndex = 9;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(102, 411);
            button4.Name = "button4";
            button4.Size = new Size(59, 23);
            button4.TabIndex = 10;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(194, 350);
            button5.Name = "button5";
            button5.Size = new Size(59, 23);
            button5.TabIndex = 11;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(194, 411);
            button6.Name = "button6";
            button6.Size = new Size(59, 23);
            button6.TabIndex = 12;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(275, 350);
            button7.Name = "button7";
            button7.Size = new Size(59, 23);
            button7.TabIndex = 13;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(275, 411);
            button8.Name = "button8";
            button8.Size = new Size(59, 23);
            button8.TabIndex = 14;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // DeveloperTaskViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblStatus);
            Controls.Add(lblAprovada);
            Controls.Add(lblDuracao);
            Controls.Add(lblResponsavel);
            Controls.Add(lblDescricao);
            Controls.Add(lblNome);
            Controls.Add(lboxTasks);
            Name = "DeveloperTaskViewerForm";
            Text = "DeveloperTaskViewerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lboxTasks;
        private Label lblNome;
        private Label lblDescricao;
        private Label lblResponsavel;
        private Label lblDuracao;
        private Label lblAprovada;
        private Label lblStatus;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}