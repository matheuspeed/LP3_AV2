namespace MyProject.APP
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            monthCalendar1 = new MonthCalendar();
            monthCalendar2 = new MonthCalendar();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 36);
            label1.Name = "label1";
            label1.Size = new Size(262, 37);
            label1.TabIndex = 4;
            label1.Text = "Controle de projetos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 104);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 5;
            label2.Text = "Nome do projeto";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(62, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(62, 215);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 23);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 181);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 7;
            label3.Text = "Gerente do projeto";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 349);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 9;
            label4.Text = "Data de inicio";
            label4.Click += label4_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(307, 215);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(149, 57);
            textBox5.TabIndex = 14;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(307, 181);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 13;
            label6.Text = "Resumo do projeto";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(307, 138);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(149, 23);
            textBox6.TabIndex = 12;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(307, 104);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 11;
            label7.Text = "Status do projeto";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(39, 395);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 17;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(284, 395);
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 19;
            monthCalendar2.DateChanged += monthCalendar2_DateChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(307, 349);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 18;
            label5.Text = "Data de término";
            // 
            // button1
            // 
            button1.Location = new Point(62, 601);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 20;
            button1.Text = "Adicionar projeto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 645);
            Controls.Add(button1);
            Controls.Add(monthCalendar2);
            Controls.Add(label5);
            Controls.Add(monthCalendar1);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private MonthCalendar monthCalendar1;
        private MonthCalendar monthCalendar2;
        private Label label5;
        private Button button1;
    }
}