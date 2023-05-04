using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Projeto_TCC
{
    public partial class Inicio : Form
    {
        conexao con =new conexao();
        
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursos sistema = new Cursos();
            sistema.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cadastro sistema = new Cadastro();
            sistema.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login sistema = new Login();
            sistema.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //painel_menu.BackColor = Color.Gray;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void painel_menu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
 
