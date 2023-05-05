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
    public partial class Form3 : Form
    {

        private int idRecebido;
        public Form3(int _idRecebido)
        {
            InitializeComponent();
            idRecebido = _idRecebido;
            Projeto j = ProjetoRepository.GetById(idRecebido);
            textBox1.Text = j.Nome;
            textBox2.Text = j.Gerente;
            textBox4.Text = j.Status;
            textBox3.Text = j.Resumo;
            monthCalendar1.SelectionStart = (DateTime)j.DataInicio;
            monthCalendar1.SelectionEnd = (DateTime)j.DataInicio;
            monthCalendar2.SelectionStart = (DateTime)j.DataFim;
            monthCalendar2.SelectionEnd = (DateTime)j.DataFim;
        }

        private DateTime dataselecionada1;
        private DateTime dataselecionada2;

        private void button1_Click(object sender, EventArgs e)
        {
            Projeto j = ProjetoRepository.GetById(idRecebido);
            j.Nome = textBox1.Text;
            j.Gerente = textBox2.Text;
            j.Status = textBox4.Text;
            j.Resumo = textBox3.Text;
            j.DataInicio = dataselecionada1;
            j.DataFim = dataselecionada2;
            ProjetoRepository.Update(j);
            MessageBox.Show("Projeto atualizado\nFavor atualizar lista");
            this.Close();
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
