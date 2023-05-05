using Microsoft.Data.SqlClient;
using MyProject.BLL;
using MyProject.MODEL;
using System.Data;

namespace MyProject.APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Projeto> list = ProjetoRepository.GetAll();
            dataGridView1.DataSource = list;
        }
    }
}