using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using MySql.Data.MySqlClient;


namespace Projeto_TCC
{
    public partial class Atualizar_cadastro : Form
    {
        Cadastro1 cad;
        Endereco endereco;
        conexao con = new conexao();
        public Atualizar_cadastro()
        {
            InitializeComponent();
        }
        int escolaridade;
        private void btn_dados_pessoais_Click(object sender, EventArgs e)
        {

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            box_bairro.Visible = false;
            box_cep.Visible = false;
            box_cidade.Visible = false;
            box_comp.Visible = false;
            box_estado.Visible = false;
            box_rua.Visible = false;
            box_num.Visible = false;
            t_cpf.Visible = true;
            t_cpf_r.Visible = true;
            t_data_nasc.Visible = true;
            t_email.Visible = true;
            t_fone.Visible = true;
            t_nome.Visible = true;
            t_nome_r.Visible = true;
            t_rg.Visible = true;
            t_rg_r.Visible = true;
            t_senha.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            box_cpf.Visible = true;
            box_cpf_r.Visible = true;
            box_email.Visible = true;
            box_fone.Visible = true;
            box_rg.Visible = true;
            box_rg_r.Visible = true;
            box_nome.Visible = true;
            box_nome_r.Visible = true;
            data_nasc.Visible = true;
            box_senha.Visible = true;
            comboBox1.Visible = true;
            box_sabendo.Visible = true;


        }

        private void btn_endereco_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            box_bairro.Visible = true;
            box_cep.Visible = true;
            box_cidade.Visible = true;
            box_comp.Visible = true;
            box_estado.Visible = true;
            box_rua.Visible = true;
            box_num.Visible = true;
            t_cpf.Visible = false;
            t_cpf_r.Visible = false;
            t_data_nasc.Visible = false;
            t_email.Visible = false;
            t_fone.Visible = false;
            t_nome.Visible = false;
            t_nome_r.Visible = false;
            t_rg.Visible = false;
            t_rg_r.Visible = false;
            t_senha.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            box_cpf.Visible = false;
            box_cpf_r.Visible = false;
            box_email.Visible = false;
            box_fone.Visible = false;
            box_rg.Visible = false;
            box_rg_r.Visible = false;
            box_nome.Visible = false;
            box_nome_r.Visible = false;
            data_nasc.Visible = false;
            box_senha.Visible = false;
            comboBox1.Visible = false;
            box_sabendo.Visible = false;

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = con.getconexao();
            MessageBox.Show("Cadastro Atualizado","Aviso",MessageBoxButtons.OK);
            
            

            





            
            string SQL = "update tb_endereco set estado='" + box_estado.Text + "',cidade='" + box_cidade.Text + "',bairro='" + box_bairro.Text + "',rua='" + box_rua.Text + "',cep='" + box_cep.Text + "',numero_casa='" + box_num.Text + "',complemento='" + box_comp.Text + "'where id_endereco=" + Usuario.id_usuario;
            conexao.Open();
            MySqlCommand comando = new MySqlCommand(SQL, conexao);
            MySqlDataAdapter dados = new MySqlDataAdapter(comando);
            DataTable tb_endereco = new DataTable();
            dados.Fill(tb_endereco);
            if (comboBox1.Text == "Ensino Fundamental Completo")
            {
                escolaridade = 1;
            }
            if (comboBox1.Text == "Ensino Medio Incompleto")
            {
                escolaridade = 2;
            }
            if (comboBox1.Text == "Ensino Medio Completo")
            {
                escolaridade = 3;
            }

            //if (box_senha.Text == "")
            //{
            //    MessageBox.Show("Campo da Senha em Branco, ")
            //}

            string SQL2 = "Update tb_cadastro set nome='" + box_nome.Text + "',nome_responsavel='" + box_nome_r.Text + "',cpf_responsavel='" + box_cpf_r.Text + "',cpf='" + box_cpf.Text + "',como_ficou_sabendo='" + box_sabendo.Text + "',rg_responsavel='" + box_rg_r.Text + "',rg='" + box_rg.Text + "',e_mail='" + box_email.Text + "',data_nascimento='" + data_nasc.Value.ToString("yyyy-MM-dd") + "',numero_telefone='" + box_fone.Text + "',senha='" + Usuario.getMD5hash(box_senha.Text) + "',id_endereco='" + cad.id_endereco + "',id_escolaridade='" + cad.id_escolaridade + "'where id_cadastro=" + Usuario.id_usuario;
            conexao.Execute(SQL2);




        }

        private void Atualizar_cadastro_Load(object sender, EventArgs e)
        {
            MySqlConnection conexao = con.getconexao();
            carregar_estados();

            box_estado.DataSource = estados;
            box_estado.DisplayMember = "UF";
            box_estado.ValueMember = "id_estado";






            string SQL3 = "select  nome,nome_responsavel,cpf_responsavel,cpf,como_ficou_sabendo,rg_responsavel,rg,e_mail,data_nascimento,numero_telefone,id_endereco,id_escolaridade from tb_cadastro where id_cadastro=" + Usuario.id_usuario;
            cad = conexao.QueryFirstOrDefault<Cadastro1>(SQL3);

            string SQL5 = "select  estado,cidade,bairro,rua,cep,numero_casa,complemento from tb_endereco where id_endereco=" + cad.id_endereco;
            endereco = conexao.QueryFirstOrDefault<Endereco>(SQL5);
            //foi criado duas classes para trocar os dados do DB elas sao as Endereco e Cadastro1 
            box_nome.Text = cad.Nome;
            box_nome_r.Text = cad.nome_responsavel;
            box_cpf_r.Text = cad.cpf_responsavel;
            box_cpf.Text = cad.cpf;
            box_sabendo.Text = cad.como_ficou_sabendo;
            box_rg_r.Text = cad.rg_responsavel;
            box_rg.Text = cad.rg;
            box_email.Text = cad.e_mail;
            data_nasc.Value = cad.data_nascimento;
            box_fone.Text = cad.numero_telefone;
            box_senha.Text = cad.senha;
            comboBox1.SelectedValue = cad.id_escolaridade;

            box_rua.Text = endereco.rua;
            box_estado.Text = endereco.estado;
            box_cidade.Text = endereco.cidade;
            box_num.Text = endereco.numero_casa.ToString();
            box_bairro.Text = endereco.bairro;
            box_cep.Text = endereco.cep.ToString();
            box_comp.Text = endereco.complemento;


        }

        private void painel_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void box_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btn_dados_pessoais_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
