﻿using MyProject.BLL;
using MyProject.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyProject.APP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private DateTime dataselecionada1;
        private DateTime dataselecionada2;


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Projeto j = new Projeto();
            j.Nome = textBox1.Text;
            j.Gerente = textBox2.Text;
            j.Status = textBox4.Text;
            j.Resumo = textBox3.Text;
            j.DataInicio = dataselecionada1;
            j.DataFim = dataselecionada2;
            ProjetoRepository.Add(j);
            MessageBox.Show("Projeto adicionado\nFavor atualizar lista");
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dataselecionada1 = e.Start;
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            dataselecionada2 = e.Start;
        }
    }
}
