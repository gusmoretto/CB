using System;
using MySql.Data.MySqlClient;
using Projeto_TCC;
using System.Data;

public class agenda
{
    bool resultado;


	public agenda()
	{
      

	}
    public bool agendar(int id_medico,int id_cliente, DateTime data_consulta, string horario)
    {
        try
        {
            string sql = "INSERT INTO agenda (id_medico,id_cliente,data_consulta,horario) values (@id_medico,@id_cliente,@data_consulta,@horario)";
            string[] campos = { "@id_medico","@id_cliente","@data_consulta","@horario"};
            
            string[] valores = { id_medico.ToString(), id_cliente.ToString(), data_consulta.ToString(), horario.ToString() };
            conexao con = new conexao();
            if (con.cadastrar(campos, valores, sql) >= 1)
            {
                return resultado = true;
            }
            else
            {
                return resultado = false;
            }
        }
        catch (System.Exception ex)
        {
            throw new System.Exception(ex.Message);

        }

    }

    public DataTable agenda_horario(int id_medico, DateTime data)
    {
        //string sql = "select horario.horario,medico.nome from medico_agenda inner join medico on medico_agenda.id_medico = medico.id_medico inner join horario on horario.id_medico_agenda = medico_agenda.id_medico_agenda where medico_agenda.data_medico = '"+ data + "'and medico_agenda.id_medico = "+ id_medico;
        string sql = "select horario.id_horario,horario.horario,horario.status_horario,medico.nome from medico_agenda inner join medico on medico_agenda.id_medico = medico.id_medico inner join horario on horario.id_medico_agenda = medico_agenda.id_medico_agenda where medico_agenda.data_medico = '2023/05/03' and medico.id_medico =" + id_medico;
        conexao con = new conexao();
        MySqlConnection conexao = con.getconexao();
        conexao.Open();

        MySqlCommand comando = new MySqlCommand(sql, conexao);
        MySqlDataAdapter dados = new MySqlDataAdapter(comando);
        DataTable tb_medico_agenda = new DataTable();
        dados.Fill(tb_medico_agenda);
        return tb_medico_agenda;






    }



}
