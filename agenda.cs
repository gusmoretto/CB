using System;
using mysql

public class Class1
{
	public agenda()
	{
      

	}
    public int agendar()
    {
        conexao con = new conexao();
        con.open();
        string sql = "insert into agenda (id_medico,id_cliente,data_consulta,horario) values (@id_medico,@id_cliente,@data_consulta,@horario)";
        mysqlcommand 
    }


}
