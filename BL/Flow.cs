using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using Entity;

namespace BL
{
    public class Flow
    {
        DAL.DAL access = new DAL.DAL();
        public int List()
        {
            int counter = 0;
            OleDbDataReader reader = access.GetDataReader("SELECT book_id FROM Books", CommandType.Text);

            if (reader.HasRows)
            {
                List<Books> books = new List<Books>();
                while (reader.Read())
                    counter++;

                return counter;
            }

            return 0;
        }
        public int GetRented()
        {
            int counter = 0;
            OleDbDataReader reader = access.GetDataReader("SELECT * FROM Rent WHERE process_type='" + "get" + "'", CommandType.Text);

            if (reader.HasRows)
            {
                List<Books> books = new List<Books>();
                while (reader.Read())
                    counter++;

                return counter;
            }

            return 0;
        }
    }
}
