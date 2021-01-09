using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using Entity;

namespace BL
{//TODO: Continue from book operations
    public class BookOperations
    {
        DAL.DAL access = new DAL.DAL();
        public List<Books> Show()
        {
            OleDbDataReader reader = access.GetDataReader("SELECT * FROM Books", CommandType.Text);

            if (reader.HasRows)
            {
                List<Books> books = new List<Books>();
                while (reader.Read())
                {
                    Books log = new Books
                    {
                        book_id = int.Parse(reader["book_id"].ToString()),
                        book_name = reader["book_name"].ToString(),
                        author = reader["author"].ToString(),
                        book_number = reader["book_number"].ToString(),
                        tour = reader["tour"].ToString()
                    };
                    books.Add(log);
                }
                return books;
            }
            return null;
        }

        DAL.DAL access2 = new DAL.DAL();
        public List<Books> Show(string location, string value)
        {
            OleDbDataReader reader = access2.GetDataReader("SELECT * FROM Books WHERE " + location + "='" + value + "'", CommandType.Text);

            if (reader.HasRows)
            {
                List<Books> books = new List<Books>();
                while (reader.Read())
                {
                    Books log = new Books
                    {
                        book_id = int.Parse(reader["book_id"].ToString()),
                        book_name = reader["book_name"].ToString(),
                        author = reader["author"].ToString(),
                        book_number = reader["book_number"].ToString(),
                        tour = reader["tour"].ToString()
                    };
                    books.Add(log);
                }
                return books;
            }
            return null;
        }

        DAL.DAL access3 = new DAL.DAL();
        public int Add(string name, string author, string number, string tour)
        {
            int result = access3.UpdateDB("INSERT INTO Books (book_name, author, book_number, tour) VALUES ('"
                + name + "','" + author + "','" + number + "','" + tour + "')", CommandType.Text);

            return result;
        }

        DAL.DAL access4 = new DAL.DAL();
        public int Update(int id, string name, string author, string number, string tour)
        {
            int result = access4.UpdateDB("UPDATE Books SET book_name='" + name + 
                "', author='" + author + 
                "', book_number='" + number + 
                "', tour='" + tour + 
                "' WHERE book_id=" + id + "", 
                CommandType.Text);

            return result;
        }

        DAL.DAL access5 = new DAL.DAL();
        public int Delete(int id)
        {
            int result = access5.UpdateDB("DELETE FROM Books WHERE book_id=" + id + "", CommandType.Text);
            return result;
        }
    }
}
