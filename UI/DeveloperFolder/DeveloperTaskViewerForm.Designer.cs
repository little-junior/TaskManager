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
            cbboxStatus = new ComboBox();
            lblStatusBox = new Label();
            btnEditar = new Button();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // lboxTasks
            // 
            lboxTasks.FormattingEnabled = true;
            lboxTasks.ItemHeight = 25;
            lboxTasks.Location = new Point(13, 96);
            lboxTasks.Margin = new Padding(4, 5, 4, 5);
            lboxTasks.Name = "lboxTasks";
            lboxTasks.Size = new Size(458, 629);
            lboxTasks.TabIndex = 0;
            lboxTasks.SelectedIndexChanged += lboxTasks_SelectedIndexChanged;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(506, 96);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(70, 25);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome: ";
            lblNome.Visible = false;
            // 
            // lblDescricao
            // 
            lblDescricao.Location = new Point(506, 157);
            lblDescricao.Margin = new Padding(4, 0, 4, 0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(607, 105);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição: ";
            lblDescricao.Visible = false;
            // 
            // lblResponsavel
            // 
            lblResponsavel.AutoSize = true;
            lblResponsavel.Location = new Point(506, 284);
            lblResponsavel.Margin = new Padding(4, 0, 4, 0);
            lblResponsavel.Name = "lblResponsavel";
            lblResponsavel.Size = new Size(119, 25);
            lblResponsavel.TabIndex = 3;
            lblResponsavel.Text = "Responsável: ";
            lblResponsavel.Visible = false;
            // 
            // lblDuracao
            // 
            lblDuracao.AutoSize = true;
            lblDuracao.Location = new Point(506, 341);
            lblDuracao.Margin = new Padding(4, 0, 4, 0);
            lblDuracao.Name = "lblDuracao";
            lblDuracao.Size = new Size(139, 25);
            lblDuracao.TabIndex = 4;
            lblDuracao.Text = "Duração (dias) : ";
            lblDuracao.Visible = false;
            // 
            // lblAprovada
            // 
            lblAprovada.AutoSize = true;
            lblAprovada.Location = new Point(503, 394);
            lblAprovada.Margin = new Padding(4, 0, 4, 0);
            lblAprovada.Name = "lblAprovada";
            lblAprovada.Size = new Size(103, 25);
            lblAprovada.TabIndex = 5;
            lblAprovada.Text = "Aprovada? ";
            lblAprovada.Visible = false;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(507, 491);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(69, 25);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status: ";
            lblStatus.Visible = false;
            // 
            // cbboxStatus
            // 
            cbboxStatus.FormattingEnabled = true;
            cbboxStatus.Location = new Point(241, 34);
            cbboxStatus.Name = "cbboxStatus";
            cbboxStatus.Size = new Size(230, 33);
            cbboxStatus.TabIndex = 7;
            cbboxStatus.SelectedIndexChanged += cbboxStatus_SelectedIndexChanged;
            // 
            // lblStatusBox
            // 
            lblStatusBox.AutoSize = true;
            lblStatusBox.Location = new Point(13, 37);
            lblStatusBox.Name = "lblStatusBox";
            lblStatusBox.Size = new Size(64, 25);
            lblStatusBox.TabIndex = 8;
            lblStatusBox.Text = "Status:";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(1019, 533);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Visible = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(647, 630);
            button1.Name = "button1";
            button1.Size = new Size(172, 35);
            button1.TabIndex = 10;
            button1.Text = "Com impedimento";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(506, 630);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 11;
            label1.Text = "Marcar como: ";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(843, 630);
            button2.Name = "button2";
            button2.Size = new Size(172, 35);
            button2.TabIndex = 12;
            button2.Text = "Abandonada";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Location = new Point(647, 684);
            button3.Name = "button3";
            button3.Size = new Size(172, 35);
            button3.TabIndex = 13;
            button3.Text = "Concluída (análise)";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(843, 684);
            button4.Name = "button4";
            button4.Size = new Size(172, 35);
            button4.TabIndex = 14;
            button4.Text = "Atrasada";
            button4.UseVisualStyleBackColor = true;
            // 
            // DeveloperTaskViewerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnEditar);
            Controls.Add(lblStatusBox);
            Controls.Add(cbboxStatus);
            Controls.Add(lblStatus);
            Controls.Add(lblAprovada);
            Controls.Add(lblDuracao);
            Controls.Add(lblResponsavel);
            Controls.Add(lblDescricao);
            Controls.Add(lblNome);
            Controls.Add(lboxTasks);
            Margin = new Padding(4, 5, 4, 5);
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
        private ComboBox cbboxStatus;
        private Label lblStatusBox;
        private Button btnEditar;
        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}