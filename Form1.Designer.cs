namespace Portal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_nome = new TextBox();
            txt_idade = new TextBox();
            txt_curso = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            label5 = new Label();
            lv_alunos = new ListView();
            Aluno = new ColumnHeader();
            Idade = new ColumnHeader();
            Curso = new ColumnHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(140, 49);
            label1.Name = "label1";
            label1.Size = new Size(118, 30);
            label1.TabIndex = 0;
            label1.Text = "Formulário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(92, 106);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(92, 177);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 2;
            label3.Text = "Idade:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(92, 245);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 3;
            label4.Text = "Curso";
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(92, 130);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(208, 23);
            txt_nome.TabIndex = 4;
            // 
            // txt_idade
            // 
            txt_idade.Location = new Point(92, 201);
            txt_idade.Name = "txt_idade";
            txt_idade.Size = new Size(208, 23);
            txt_idade.TabIndex = 5;
            txt_idade.TextChanged += textBox2_TextChanged;
            // 
            // txt_curso
            // 
            txt_curso.Location = new Point(92, 269);
            txt_curso.Name = "txt_curso";
            txt_curso.Size = new Size(208, 23);
            txt_curso.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Location = new Point(142, 317);
            button1.Name = "button1";
            button1.Size = new Size(104, 29);
            button1.TabIndex = 7;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lv_alunos);
            panel1.Location = new Point(400, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 450);
            panel1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(11, 9);
            label5.Name = "label5";
            label5.Size = new Size(154, 30);
            label5.TabIndex = 10;
            label5.Text = "Lista de alunos";
            label5.Click += label5_Click;
            // 
            // lv_alunos
            // 
            lv_alunos.Columns.AddRange(new ColumnHeader[] { Aluno, Idade, Curso });
            lv_alunos.Location = new Point(16, 48);
            lv_alunos.Name = "lv_alunos";
            lv_alunos.Size = new Size(372, 336);
            lv_alunos.TabIndex = 9;
            lv_alunos.UseCompatibleStateImageBehavior = false;
            lv_alunos.View = View.Details;
            // 
            // Aluno
            // 
            Aluno.Text = "Nome";
            Aluno.Width = 120;
            // 
            // Idade
            // 
            Idade.Text = "Idade";
            Idade.Width = 120;
            // 
            // Curso
            // 
            Curso.Text = "Curso";
            Curso.Width = 120;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(txt_curso);
            Controls.Add(txt_idade);
            Controls.Add(txt_nome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Portal do aluno";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_nome;
        private TextBox txt_idade;
        private TextBox txt_curso;
        private Button button1;
        private Panel panel1;
        private ListView lv_alunos;
        private ColumnHeader Aluno;
        private ColumnHeader Idade;
        private ColumnHeader Curso;
        private Label label5;
    }
}
