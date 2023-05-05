namespace MyProject.APP
{
    partial class Form3
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
            button1 = new Button();
            monthCalendar2 = new MonthCalendar();
            monthCalendar1 = new MonthCalendar();
            label6 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(64, 651);
            button1.Name = "button1";
            button1.Size = new Size(129, 23);
            button1.TabIndex = 44;
            button1.Text = "Editar projeto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(310, 435);
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 43;
            monthCalendar2.DateChanged += monthCalendar2_DateChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(34, 435);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 42;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(374, 393);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 41;
            label6.Text = "Data de término";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(86, 393);
            label7.Name = "label7";
            label7.Size = new Size(79, 15);
            label7.TabIndex = 40;
            label7.Text = "Data de inicio";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(345, 287);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(165, 62);
            textBox3.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(372, 253);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 38;
            label4.Text = "Resumo do projeto";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(84, 287);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 253);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 36;
            label5.Text = "Status do projeto";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(372, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(372, 115);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 34;
            label3.Text = "Gerente do projeto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(84, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 115);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 32;
            label2.Text = "Nome do projeto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 12);
            label1.Name = "label1";
            label1.Size = new Size(262, 37);
            label1.TabIndex = 31;
            label1.Text = "Controle de projetos";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 686);
            Controls.Add(button1);
            Controls.Add(monthCalendar2);
            Controls.Add(monthCalendar1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MonthCalendar monthCalendar2;
        private MonthCalendar monthCalendar1;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}