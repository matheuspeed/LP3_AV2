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

        int idCapturado;

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dataGridView1.Rows[e.RowIndex];
                idCapturado = Convert.ToInt32(linha.Cells[0].Value.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (idCapturado != 0)
            {
                if (ProjetoRepository.GetById(idCapturado) != null)
                {
                    Projeto j = ProjetoRepository.GetById(idCapturado);
                    Form3 form3 = new Form3(idCapturado);
                    form3.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nenhum projeto selecionado");
                }

            }
            else
            {
                MessageBox.Show("Nenhum projeto selecionado");
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(idCapturado != 0)
            {
                if (ProjetoRepository.GetById(idCapturado) != null)
                {
                    Projeto j = ProjetoRepository.GetById(idCapturado);
                    ProjetoRepository.Excluir(j);
                    MessageBox.Show("Projeto excluído\nFavor atualizar a lista");
                }
                else
                {
                    MessageBox.Show("Nenhum projeto selecionado");
                }

            }
            else
            {
                MessageBox.Show("Nenhum projeto selecionado");
            }


        }
    }
}