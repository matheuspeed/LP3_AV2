using MyProject.BLL;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Projeto j = new Projeto();
            j.Nome = textBox1.Text;
            j.Gerente = textBox2.Text;
            j.Status = textBox6.Text;
            j.Resumo = textBox5.Text;
            j.DataInicio = dataselecionada1;
            j.DataFim = dataselecionada2;
            ProjetoRepository.Add(j);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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
