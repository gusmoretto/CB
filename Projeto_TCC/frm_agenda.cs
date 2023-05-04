using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_TCC
{
    public partial class frm_agenda : Form
    {
        int id_cliente;
        int id_medico;
        DateTime data_consulta;
        string horario;
        public frm_agenda()
        {
            InitializeComponent();
        }

        private void btn_agendar_Click(object sender, EventArgs e)
        {
            conexao con = new conexao();
            agenda agendar = new agenda();
            data_consulta = dtp_data.Value;
            MessageBox.Show(data_consulta.ToString());
            dgv_horario.DataSource = agendar.agenda_horario(id_medico,data_consulta);
            //horario = txt_horario.Text;
           /* if (agendar.agendar(id_medico,id_cliente,data_consulta,horario) == true)
            {
                MessageBox.Show("cadastrado com sucesso");
            }*/




        }

        private void frm_agenda_Load(object sender, EventArgs e)
        {
            conexao con = new conexao();
            cbo_cliente.DataSource = con.Getcliente_Nome();
            cbo_cliente.DisplayMember = "nome";
            cbo_cliente.ValueMember = "id_cliente";

            cbo_medico.DataSource = con.Getmedico();
            cbo_medico.DisplayMember = "nome";
            cbo_medico.ValueMember = "id_medico";


        }

      

        private void cbo_medico_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_medico = Convert.ToInt32(((DataRowView)cbo_medico.SelectedItem)["id_medico"]);

        }

        private void cbo_cliente_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            id_cliente = Convert.ToInt32(((DataRowView)cbo_cliente.SelectedItem)["id_cliente"]);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 cadastro = new Form3();
            cadastro.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cadastro Cadastromedico = new Cadastro();
            Cadastromedico.ShowDialog();
        }
    }
}
