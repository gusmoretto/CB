using MySql.Data.MySqlClient;
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
    public partial class Login : Form

    {
        conexao con = new conexao();
        public Login()
        {
            InitializeComponent();
        }

 


        private void Entrar_Click(object sender, EventArgs e)
        {
            string id_E;
            String logar = "SELECT e_mail,senha,id_cadastro,tipo_escolaridade from tb_cadastro inner join tb_escolaridade on tb_escolaridade.id_escolaridade=tb_curso.id_escolaridade  where tb_cadastro.e_mail=@e_mail AND tb_cadastro.senha=@senha";
            MySqlConnection conexao = con.getconexao();
            MySqlCommand comando = new MySqlCommand(logar, conexao);
            conexao.Open();


            comando.Parameters.AddWithValue("@e_mail", textBox1.Text);
            comando.Parameters.AddWithValue("@senha", textBox2.Text);

            MySqlDataReader registro = comando.ExecuteReader();
            
            if (registro.HasRows)
            {
                registro.Read();
                Usuario.email = Convert.ToString(registro["e_mail"]);
                
                //usu.id_usuario = ;
                Usuario.logado = true;
                MessageBox.Show("Bem Vindo");
                //btn_cursos.Visible = true;
                btn_desc.Visible = true;
                Usuario.id_usuario = Convert.ToInt32(registro["id_cadastro"]);
                id_E = Convert.ToString(registro["tipo_escolaridade"]);
                if (id_E== "Ensino Fundamental Completo")
                {
                    Cadastro sistema = new Cadastro();
                    sistema.ShowDialog();
                }
                


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Usuario.logado = false;
            Usuario.email = "";
            Usuario.id_usuario = 0;
            //btn_cursos.Visible = false;
            Close();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MySqlConnection conexao = con.getconexao();
            
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            Entrar.Visible = true;
        }

        private void b_atualizar_Click(object sender, EventArgs e)
        {
            Atualizar_cadastro sistema = new Atualizar_cadastro();
            sistema.ShowDialog();
        }

        private void btn_cursos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("teste");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar =  true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void gp_senai_Click(object sender, EventArgs e)
        {

        }

        private void Login_MouseHover(object sender, EventArgs e)
        {
               
        
        }
    }
}
