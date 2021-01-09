using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using Entity;

namespace BL
{ //TODO: Refactor reader rows
    public class RentOperations
    {
        DAL.DAL access = new DAL.DAL();
        public List<Rent> LoadRent()
        {
            OleDbDataReader reader = access.GetDataReader("Select * from Rent", CommandType.Text);

            if (reader.HasRows)
            {
                List<Rent> log = new List<Rent>();
                while (reader.Read())
                {
                    Rent load = new Rent
                    {
                        book_id = int.Parse(reader["book_id"].ToString()),
                        student_id = int.Parse(reader["student_id"].ToString()),
                        start_date = reader["start_date"].ToString(),
                        end_date_expected = reader["end_date_expected"].ToString(),
                        end_date = reader["end_date"].ToString(),
                        debt = reader["debt"].ToString(),
                        process_type = reader["process_type"].ToString()
                    };
                    log.Add(load);
                }
                return log;
            }

            return null;
        }

        DAL.DAL access1 = new DAL.DAL();
        public int RentEdit(int book_id, int student_id, string process_type)
        {
            int result = access1.UpdateDB("UPDATE Rent SET process_type='" + process_type +
                "' WHERE student_id=" + student_id + 
                " AND book_id=" + book_id + "", 
                CommandType.Text);

            return result;
        }

        public List<Rent> ListRecords (int id)
        {
            OleDbDataReader reader = access.GetDataReader("SELECT * FROM Rent " +
                "WHERE student_id " +
                "IN (SELECT student_id FROM Students WHERE student_number ='" +
                id + "') ", CommandType.Text);

            if (reader.HasRows)
            {
                List<Rent> log = new List<Rent>();
                while (reader.Read())
                {
                    Rent load = new Rent
                    {
                        book_id = int.Parse(reader["book_id"].ToString()),
                        student_id = int.Parse(reader["student_id"].ToString()),
                        start_date = reader["start_date"].ToString(),
                        end_date_expected = reader["end_date_expected"].ToString(),
                        end_date = reader["end_date"].ToString(),
                        debt = reader["debt"].ToString(),
                        process_type = reader["process_type"].ToString()
                    };
                    log.Add(load);
                }
                return log;
            }
            return null;
        }

        DAL.DAL access2 = new DAL.DAL();
        public int RentOperation(int book_id, int student_id, DateTime start_date, 
            DateTime end_date_expected, string process_type)
        {
            int result = access2.UpdateDB("INSERT INTO Rent (book_id,student_id,start_date,end_date_expected,process_type) VALUES (" +
                book_id + "," + student_id + ",'" + start_date + "','" + end_date_expected + "','" + process_type + "')", CommandType.Text);

            return result;
        }

        DAL.DAL access3 = new DAL.DAL();
        public List<Rent> ListStudentRent(string id)
        {
            OleDbDataReader reader = access3.GetDataReader("SELECT * FROM Rent WHERE student_id " +
                "IN (SELECT student_id FROM Students WHERE " +
                "student_number='" + id + "')", CommandType.Text);

            if (reader.HasRows)
            {
                List<Rent> log = new List<Rent>();
                while (reader.Read())
                {
                    Rent load = new Rent
                    {
                        book_id = int.Parse(reader["book_id"].ToString()),
                        student_id = int.Parse(reader["student_id"].ToString()),
                        start_date = reader["start_date"].ToString(),
                        end_date_expected = reader["end_date_expected"].ToString(),
                        end_date = reader["end_date"].ToString(),
                        debt = reader["debt"].ToString(),
                        process_type = reader["process_type"].ToString()
                    };
                    log.Add(load);
                }
                return log;
            }
            return null;
        }

        DAL.DAL access4 = new DAL.DAL();
        public List<Rent> ListWantedRecord(string value, string location)
        {
            OleDbDataReader reader = access4.GetDataReader("SELECT * FROM Rent WHERE book_id IN " +
                "(SELECT book_id FROM Books " +
                "WHERE " + location + " ='" + value + "')", CommandType.Text);

            if (reader.HasRows)
            {
                List<Rent> log = new List<Rent>();
                while (reader.Read())
                {
                    Rent load = new Rent
                    {
                        book_id = int.Parse(reader["book_id"].ToString()),
                        student_id = int.Parse(reader["student_id"].ToString()),
                        start_date = reader["start_date"].ToString(),
                        end_date_expected = reader["end_date_expected"].ToString(),
                        end_date = reader["end_date"].ToString(),
                        debt = reader["debt"].ToString(),
                        process_type = reader["process_type"].ToString()
                    };
                    log.Add(load);
                }
                return log;
            }
            return null;
        }
    }
}
