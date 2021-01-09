using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;

namespace DAL
{
    public class DAL
    {
        private OleDbCommand WriteQuery(string query, CommandType commandType)
        {
            Connect connect = new Connect();
            OleDbCommand cmd = connect.WIRE_CONNECTION.CreateCommand();
            cmd.CommandText = query;
            cmd.CommandType = commandType;

            return cmd;
        }

        List<OleDbParameter> parameters = new List<OleDbParameter>();
        public void AddInputParameter(string parameterName, object parameterValue)
        {
            OleDbParameter parameter = new OleDbParameter();
            parameter.ParameterName = parameterName;
            parameter.Value = parameterValue;
            parameters.Add(parameter);
        }

        public void AddOutParameter(string parameterName, object parameterValue)
        {
            OleDbParameter parameter = new OleDbParameter();
            parameter.ParameterName = parameterName;
            parameter.Value = parameterValue;
            parameter.Direction = ParameterDirection.Output;
            parameters.Add(parameter);
        }

        private void AddParametersToQuery(OleDbCommand command)
        {
            command.Parameters.AddRange(parameters.ToArray());
        }

        public object GetParameterValue(string parameterName)
        {
            foreach (var value in parameters)
            {
                if (value.ParameterName == parameterName)
                    return value.Value.ToString();
            }

            return null;
        }

        public int UpdateDB(string query, CommandType commandType)
        {
            try
            {
                return TryExecuteQuery(query, commandType);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public object FirstRowAndColumn(string query, CommandType commandType)
        {
            try
            {
                return TryExecuteQuery(query, commandType);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private int TryExecuteQuery(string query, CommandType commandType)
        {
            OleDbCommand cmd = WriteQuery(query, commandType);
            AddParametersToQuery(cmd);

            int result = cmd.ExecuteNonQuery();

            if (cmd.Connection.State == ConnectionState.Open)
                cmd.Connection.Close();

            cmd.Connection.Dispose();
            cmd.Dispose();

            return result;
        }

        public OleDbDataReader GetDataReader(string query, CommandType commandType)
        {
            OleDbCommand cmd = WriteQuery(query, commandType);
            AddParametersToQuery(cmd);
            OleDbDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }

        public DataTable GetDataTable(string query, CommandType commandType)
        {
            try
            {
                OleDbDataReader reader = GetDataReader(query, commandType);
                DataTable table = new DataTable();

                table.Load(reader);

                return table;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
