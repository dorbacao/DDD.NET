using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System.Xml;


public partial class Triggers
{
    // Enter existing table or view for the target and uncomment the attribute line
    [Microsoft.SqlServer.Server.SqlTrigger(Name = "ClienteTrigger", Target = "Cliente", Event = "FOR INSERT")]
    public static void ClienteTrigger()
    {
        using (SqlConnection sc = new SqlConnection("context connection=true"))
        {
            string query = GetQuery();
            using (SqlCommand cmdInsert = new SqlCommand(query, sc))
            {
                try
                {
                    DataTable dataTableRowInserida = ObterLinhaInserida(sc);

                    //ao invés dos parâmetros abaixo serem preenchidos em "hard Coded" o método 
                    //obterLinhaInserido deverá retornar o tabela inserted que é a tabela de contexto da trigger com o registro inserido
                    cmdInsert.Parameters.Add("@cod_cliente", SqlDbType.Int, 5).Value = 1;
                    cmdInsert.Parameters.Add("@nom_cliente", SqlDbType.VarChar).Value = "Marcus Dorbação";
                    cmdInsert.Parameters.Add("@dat_nascimento", SqlDbType.DateTime).Value = Convert.ToDateTime("18/06/1986");
                    cmdInsert.Parameters.Add("@nom_usuario_banco", SqlDbType.VarChar).Value = "sef_usuario";
                    cmdInsert.Parameters.Add("@cod_usuario_aplicacao", SqlDbType.VarChar).Value = "mcarreira";
                    cmdInsert.Parameters.Add("@dth_ocorrencia", SqlDbType.DateTime).Value = DateTime.Now;
                    cmdInsert.Parameters.Add("@tip_ocorrencia", SqlDbType.SmallInt).Value = 1; //0 = Insert, 1 = Update, 2 = Delete

                    cmdInsert.ExecuteNonQuery();
                }
                catch (XmlException xe)
                {
                    SqlContext.Pipe.Send("Error parsing XML message: " + xe.Message);
                }
                catch (SqlException ex)
                {
                    SqlContext.Pipe.Send("Error executing SQL statement: " + ex.Message);
                }
                catch (Exception ex)
                {
                    SqlContext.Pipe.Send("Error executing SQL statement: " + ex.Message);
                }
                finally
                {
                    sc.Close();
                }
            }
        }
    }

    /// <summary>
    /// Este método deverá retornar um dataTable contendo o que acabou de ser inserido na tabela em questão
    /// </summary>
    /// <param name="connection"></param>
    /// <returns></returns>
    private static DataTable ObterLinhaInserida(SqlConnection connection)
    {
        string queryExemplo = "Select * from Inserted";
        return null;

    }

    private static string GetQuery()
    {
        return "INSERT INTO LOG_SEF.dbo.LOG_Cliente (cod_cliente, nom_cliente, dat_nascimento, nom_usuario_banco, cod_usuario_aplicacao, dth_ocorrencia, tip_ocorrencia) " +
        "VALUES (@cod_cliente, @nom_cliente, @dat_nascimento, @nom_usuario_banco,@cod_usuario_aplicacao, @dth_ocorrencia, @tip_ocorrencia)";
    }
}
