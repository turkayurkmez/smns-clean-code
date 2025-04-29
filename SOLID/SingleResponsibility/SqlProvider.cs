using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class SqlProvider
    {
        private SqlConnection connection = null;
        public SqlProvider(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }

        public int ExecuteNonQuery(string commandText, Dictionary<string, object> parameters)
        {
            var command = createCommand(commandText, parameters);
            command.Connection.Open();
            var rowsCount = command.ExecuteNonQuery();
            command.Connection.Close();
            return rowsCount;
        }

        private SqlCommand createCommand(string commandText, Dictionary<string, object> parameters)
        {
            var command = connection.CreateCommand();
            command.CommandText = commandText;
            addParametersToCommand(command, parameters);
            return command;
        }

        private void addParametersToCommand(SqlCommand command, Dictionary<string, object> parameters)
        {
            foreach (var  parameter in parameters)
            {
                command.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }
        }
    }
}
