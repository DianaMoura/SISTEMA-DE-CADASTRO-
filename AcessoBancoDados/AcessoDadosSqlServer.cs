using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AcessoBancoDados.Properties;

namespace AcessoBancoDados
{
    public class AcessoDadosSqlServer
    {

        //Cria Conexão
        private SqlConnection CriarConexao()
        {

            return new SqlConnection(Settings.Default.stringConexao);
        
        
        
        }


        //Criar Parâmetros Que Vão Ao Banco 

        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void LimparParametros()

        {


            sqlParameterCollection.Clear();
        
        }

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {


            sqlParameterCollection.Add(new SqlParameter(nomeParametro,valorParametro));
        
        
        }

        //Criar Persistência -Inserir,Alterar,Excluir
        public object ExecutarManipulacao(CommandType commandType,string nomeStoredProcedureOuTextoSql) 
        {
            try
            {



                //Criar Conexão
                SqlConnection sqlConnection = CriarConexao();

                //Abrir Conexão 
                sqlConnection.Open();

                //Criar comando que vai levar os objetos
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200;


                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {

                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));



                }

                return sqlCommand.ExecuteScalar();

               }
              catch (Exception ex)

               {

                throw new Exception(ex.Message);
            }
          }

        //Consultar Registros
        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoredProcedureOuTextoSql)

        {
            try
            {



                //Criar Conexão
                SqlConnection sqlConnection = CriarConexao();

                //Abrir Conexão 
                sqlConnection.Open();

                //Criar comando que vai levar os objetos
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 7200;


                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {

                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));



                }

                //Criar um Adpatador
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);

                return dataTable;

            }
            catch (Exception ex)

            {

                throw new Exception(ex.Message);
            }


        }


    }
}
