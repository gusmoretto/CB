using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_TCC
{
    public partial class Cursos : Form
    {
        public int codigo = 0;
        public int id_curso_rap;
        public int id_curso_apr;
        public int id_curso_tec;
        conexao con = new conexao();
        
        
        public Cursos()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void Cursos_Load(object sender, EventArgs e)
        {
            dados_curso.AutoGenerateColumns = false;
            DataGridViewColumn Column = dados_curso.Columns[7];
            //Column.Height = 150;
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void txcurso_TextChanged(object sender, EventArgs e)
        {

        }

        



        private void r_t_CheckedChanged(object sender, EventArgs e)
        {

            dados_curso.Visible = true;
            //dados_curso.DataSource = con.Getcursos(1);

        }

        private void r_r_CheckedChanged(object sender, EventArgs e)
        {
            dados_curso.Visible = true;
           // dados_curso.DataSource = con.Getcursos(2);

        }

        private void r_a_CheckedChanged(object sender, EventArgs e)
        {
            dados_curso.Visible = true;
            //dados_curso.DataSource = con.Getcursos(3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cadastro sistema = new Cadastro();
            sistema.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Usuario.logado = true; criar if, se o usuario ta logado, ele nao vai ser deslogado.
            MessageBox.Show("Clique duas vezes para selecionar o curso desejado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void b_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dados_curso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dados_curso_CellDobleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{

            //    this.codigo = Convert.ToInt32(dados_curso.Rows[e.RowIndex].Cells[0].Value);
            //    MessageBox.Show("Codigo usuário: " + this.codigo);
            //    dados_curso.DataSource = con.Getcursos(this.codigo);


            //    string nomesql = "select nome_curso from tb_curso where id_curso=" + this.codigo;
            //    MySqlCommand comando = new MySqlCommand(nomesql, Conexao);
            //    MySqlDataReader registro = comando.ExecuteReader();
            //    Ncurso.Text = Convert.ToString(registro["nome_curso"]);
            //    Ncurso.Text = Convert.ToString(con.Getcursos(this.codigo));

            //}
            //MySqlConnection Conexao = con.getconexao();
            //string query = "select * from tb_curso where id_curso =" + this.codigo;

            //MySqlCommand cmd = new MySqlCommand(query, Conexao);
            //try
            //{
            //    Conexao.Open();
            //    MySqlDataReader dataReader;
            //    dataReader = cmd.ExecuteReader();
            //    while (dataReader.Read())
            //    {
            //        Ncurso.Text = dataReader.GetString("nome_curso");
            //        Desqcurso.Text = dataReader.GetString("descricao");
            //        Reqcurso.Text = dataReader.GetString("requisitos");
            //        Pcurso.Text = "Preço = " + dataReader.GetString("preco");


            //    }

            //}
            //catch (MySqlException er)
            //{
            //    MessageBox.Show("Erro de conexão: " + er);
            //}

        }

        private void dados_curso_SelectionChanged(object sender, EventArgs e)
        {


            Ncurso.Visible = true;
            Desqcurso.Visible = true;
            Reqcurso.Visible = true;
            Pcurso.Visible = true;
            Hcurso.Visible = true;
            Mcurso.Visible = true;
            Tcurso.Visible = true; 
            L_curso.Visible=true;
            panel3.Visible = true;





            if (dados_curso.CurrentRow==null)
            {
                return;
            }
            int index= dados_curso.CurrentRow.Index;
             if (index >= 0)
            {

                this.codigo = Convert.ToInt32(dados_curso.Rows[index].Cells[0].Value);
                //MessageBox.Show("Codigo usuário: " + this.codigo);
                //dados_curso.DataSource = con.Getcursos(this.codigo);


                //string nomesql = "select nome_curso from tb_curso where id_curso=" + this.codigo;
                //MySqlCommand comando = new MySqlCommand(nomesql, Conexao);
                //MySqlDataReader registro = comando.ExecuteReader();
                //Ncurso.Text = Convert.ToString(registro["nome_curso"]);
                //Ncurso.Text = Convert.ToString(con.Getcursos(this.codigo));

            }
            MySqlConnection Conexao = con.getconexao();
            string query = @"select id_curso,nome_curso,requisitos,descricao,localizacao,preco,carga_horaria,tb_tipo_curso.tipo_curso,tb_modalidade.modalidade,tb_turno.tipo_turno from tb_curso 
            inner join tb_tipo_curso on tb_curso.id_tipo_curso=tb_tipo_curso.id_tipo_curso inner join tb_modalidade on tb_curso.id_modalidade=tb_modalidade.id_modalidade inner join tb_turno on tb_curso.id_turno=tb_turno.id_turno where id_curso ="+ this.codigo;

            MySqlCommand cmd = new MySqlCommand(query, Conexao);
            try
            {
                Conexao.Open();
                MySqlDataReader dataReader;
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Ncurso.Text = dataReader.GetString("nome_curso");
                    Desqcurso.Text = "Descrição:\n\n"+dataReader.GetString("descricao");
                    Reqcurso.Text = "Requisitos:\n\n"+dataReader.GetString("requisitos");
                    Pcurso.Text = "Preço: "+ dataReader.GetString("preco");
                    Hcurso.Text = "Carga Horaria:"+dataReader.GetString("carga_horaria");
                    Mcurso.Text = "Modalidade:\n"+dataReader.GetString("modalidade");
                    Tcurso.Text = "Turno:\n" + dataReader.GetString("tipo_turno");
                    L_curso.Text = "Localização:\n" + dataReader.GetString("localizacao");


                    //usar o dapper para atribuir os text a alteracao ou vinculação de registros por ex para a matricula e se matricular nos cursos

                }

            }
            catch (MySqlException er)
            {
                MessageBox.Show("Erro de conexão: " + er);
            }
        }

        private void dados_curso_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
