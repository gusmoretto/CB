using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Security;

namespace Projeto_TCC
{
    class conexao
    {
       
    
        


        static private string servidor = "localhost";
        static private string bancodedados = "db_clinica";
        static private string usuario = "root";
        static private string senha = "";
        public MySqlConnection conn = null;


        static private string StrCon = "server=" + servidor + ";database=" + bancodedados + ";user id=" + usuario + ";password=" + senha;
        public MySqlConnection getconexao()
        {
            MySqlConnection conn = new MySqlConnection(StrCon);
            return conn;
        }
        public bool conectar()
        {
            var result = false;
            try
            {
                getconexao().Open();
                result = true;
            }catch(Exception ex)
            {
                result = false;
                MessageBox.Show("Falha: " + ex.Message);
            }
            return result;
        }
        public void desconectar()
        {
            getconexao().Close();
        }
        public DataTable Getcliente_Nome()
        {
            MySqlConnection conexao = getconexao();
            string SQL = "select id_cliente, nome from cliente";
            conexao.Open();
            MySqlCommand comando = new MySqlCommand(SQL, conexao);
            MySqlDataAdapter dados = new MySqlDataAdapter(comando);
            DataTable tb_cliente = new DataTable();
            dados.Fill(tb_cliente);
            return tb_cliente;
        }
       
        public DataTable Getmedico()
        {
            MySqlConnection conexao = getconexao();
            string SQL = "select id_medico,nome from medico";
            conexao.Open();
            MySqlCommand comando = new MySqlCommand(SQL, conexao);
            MySqlDataAdapter dados = new MySqlDataAdapter(comando);
            DataTable tb_curso = new DataTable();
            dados.Fill(tb_curso);
            return tb_curso;
        }

        public int cadastrar(string[] campos, string[] valores, string SQLinsert)
        {
            int registro = -1;
            try
            {
                conn = getconexao();
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(SQLinsert, conn);
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = SQLinsert;
                for (int i = 0; i < valores.Length; i++)
                {
                    cmd.Parameters.AddWithValue(campos[i], valores[i]);
                }
                registro = cmd.ExecuteNonQuery();
                conn.Close();
                return registro;
            }
            catch (Exception ex)
            {
                throw new System.Exception(ex.Message);
            }

        }

    }
}
 