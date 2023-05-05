namespace MyProject.APP
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
            dataGridView1 = new DataGridView();
            cNome = new DataGridViewTextBoxColumn();
            cGerente = new DataGridViewTextBoxColumn();
            cDataInicio = new DataGridViewTextBoxColumn();
            cDataFim = new DataGridViewTextBoxColumn();
            cStatus = new DataGridViewTextBoxColumn();
            cResumo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Gerente = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cNome, cGerente, cDataInicio, cDataFim, cStatus, cResumo });
            dataGridView1.Location = new Point(58, 247);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(645, 172);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cNome
            // 
            cNome.HeaderText = "Nome";
            cNome.Name = "cNome";
            // 
            // cGerente
            // 
            cGerente.HeaderText = "Gerente";
            cGerente.Name = "cGerente";
            // 
            // cDataInicio
            // 
            cDataInicio.HeaderText = "Data inicio";
            cDataInicio.Name = "cDataInicio";
            // 
            // cDataFim
            // 
            cDataFim.HeaderText = "Data fim";
            cDataFim.Name = "cDataFim";
            // 
            // cStatus
            // 
            cStatus.HeaderText = "Status";
            cStatus.Name = "cStatus";
            // 
            // cResumo
            // 
            cResumo.HeaderText = "Resumo";
            cResumo.Name = "cResumo";
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Gerente
            // 
            Gerente.HeaderText = "Gerente";
            Gerente.Name = "Gerente";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nome";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // button1
            // 
            button1.Location = new Point(58, 157);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 1;
            button1.Text = "Adicionar projeto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(58, 201);
            button2.Name = "button2";
            button2.Size = new Size(120, 23);
            button2.TabIndex = 2;
            button2.Text = "Atualizar lista";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(58, 39);
            label1.Name = "label1";
            label1.Size = new Size(262, 37);
            label1.TabIndex = 3;
            label1.Text = "Controle de projetos";
            label1.Click += label1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(58, 442);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(161, 442);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "Excluir";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 525);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn cNome;
        private DataGridViewTextBoxColumn cGerente;
        private DataGridViewTextBoxColumn cDataInicio;
        private DataGridViewTextBoxColumn cDataFim;
        private DataGridViewTextBoxColumn cStatus;
        private DataGridViewTextBoxColumn cResumo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Gerente;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
        private Button button4;
    }
}