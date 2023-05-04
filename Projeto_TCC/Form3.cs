using System;
using MySql.Data.MySqlClient;
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
    public partial class Form3 : Form
    {
        conexao con = new conexao();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)

        {
            carregar_estados();

            box_estado.DataSource = estados;
            box_estado.DisplayMember = "uf";
            box_estado.ValueMember = "id_estado";


      
        }
        List<Estado> estados;

        void carregar_estados()
        {
            estados = new List<Estado>();
            estados.Add(new Estado(1, "Acre", "AC"));
            estados.Add(new Estado(2, "Alagoas", "AL"));
            estados.Add(new Estado(3, "Amazonas", "AM"));
            estados.Add(new Estado(4, "Amapá", "AP"));
            estados.Add(new Estado(5, "Bahia", "BA"));
            estados.Add(new Estado(6, "Ceará", "CE"));
            estados.Add(new Estado(7, "Distrito Federal", "DF"));
            estados.Add(new Estado(8, "Espírito Santo", "ES"));
            estados.Add(new Estado(9, "Goiás", "GO"));
            estados.Add(new Estado(10, "Maranhão", "MA"));
            estados.Add(new Estado(11, "Minas Gerais", "MG"));
            estados.Add(new Estado(12, "Mato Grosso do Sul", "MS"));
            estados.Add(new Estado(13, "Mato Grosso", "MT"));
            estados.Add(new Estado(14, "Pará", "PA"));
            estados.Add(new Estado(15, "Paraíba", "PB"));
            estados.Add(new Estado(16, "Pernambuco", "PE"));
            estados.Add(new Estado(17, "Piauí­", "PI"));
            estados.Add(new Estado(18, "Paraná", "PR"));
            estados.Add(new Estado(19, "Rio de Janeiro", "RJ"));
            estados.Add(new Estado(20, "Rio Grande do Norte", "RN"));
            estados.Add(new Estado(21, "Rondônia", "RO"));
            estados.Add(new Estado(22, "Roraima", "RR"));
            estados.Add(new Estado(23, "Rio Grande do Sul", "RS"));
            estados.Add(new Estado(24, "Santa Catarina", "SC"));
            estados.Add(new Estado(25, "Sergipe", "SE"));
            estados.Add(new Estado(26, "São Paulo", "SP"));
            estados.Add(new Estado(27, "Tocantins", "TO"));

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            MySqlConnection Conexao = con.getconexao();// chama a conexão mysql
            Conexao.Open();//abre conexao
            string INS_CAD = "insert into cliente values (default,@nome,@data_nasc,@telefone,@cpf,@rg,@rua,@numero_da_casa,@cidade,@bairro,@cep,@complemento,@uf,@email,@senha,@dados_adicionais) ";
      

            MySqlCommand comando3 = new MySqlCommand(INS_CAD, Conexao);//comando sql para montar

            comando3.Parameters.AddWithValue("@nome", box_nome.Text);
            comando3.Parameters.AddWithValue("@data_nasc", data_nasc.Value);
            comando3.Parameters.AddWithValue("@telefone", box_fone.Text);
            comando3.Parameters.AddWithValue("@cpf", box_cpf.Text);
            comando3.Parameters.AddWithValue("@rg", box_rg.Text);
            comando3.Parameters.AddWithValue("@rua", box_rua.Text);
            comando3.Parameters.AddWithValue("@numero_da_casa", box_num.Text);
            comando3.Parameters.AddWithValue("@cidade", box_cidade.Text);
            comando3.Parameters.AddWithValue("@bairro", box_bairro.Text);
            comando3.Parameters.AddWithValue("@cep", box_cep.Text);
            comando3.Parameters.AddWithValue("@complemento", box_comp.Text);
            comando3.Parameters.AddWithValue("@uf", box_estado.SelectedValue);
            comando3.Parameters.AddWithValue("@email", box_cep.Text);
            comando3.Parameters.AddWithValue("@senha", box_senha.Text);
            comando3.Parameters.AddWithValue("@dados_adicionais", box_sabendo.Text);
            comando3.ExecuteNonQuery();//ler os dados da consulta
            MessageBox.Show("Cadastrado com sucesso!", "AVISO", MessageBoxButtons.OK);
        }
    }
}