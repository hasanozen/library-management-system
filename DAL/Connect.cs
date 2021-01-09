using System.Data;
using System.Data.OleDb;

namespace DAL
{
    class Connect
    {
        OleDbConnection conn;

        public OleDbConnection WIRE_CONNECTION
        {
            get
            {
                if (conn != null)
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    return conn;
                }
                else
                {
                    conn = new OleDbConnection(Provider());

                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    return conn;
                }
            }
        }

        private string Provider()
        {
            return ConnectionSettings.CONNECTION_STRING;
        }
    }
}
