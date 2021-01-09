using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using Entity;

namespace BL
{
    public class StudentOperations
    {
        DAL.DAL access = new DAL.DAL();
        public List<Students> Show()
        {
            OleDbDataReader reader = access.GetDataReader("SELECT * FROM Students", CommandType.Text);

            if (reader.HasRows)
            {
                List<Students> students = new List<Students>();
                while (reader.Read())
                {
                    Students log = new Students
                    {
                        student_id = int.Parse(reader["student_id"].ToString()),
                        student_name = reader["student_name"].ToString(),
                        student_number = reader["student_number"].ToString(),
                        student_department = reader["student_department"].ToString()
                    };
                    students.Add(log);
                }
                return students;
            }
            return null;
        }

        DAL.DAL access2 = new DAL.DAL();
        public List<Students> Show(string number)
        {
            OleDbDataReader reader = access2.GetDataReader("SELECT * FROM Students WHERE student_number='" + number + "'", CommandType.Text);

            if (reader.HasRows)
            {
                List<Students> students = new List<Students>();
                while (reader.Read())
                {
                    Students log = new Students
                    {
                        student_id = int.Parse(reader["student_id"].ToString()),
                        student_name = reader["student_name"].ToString(),
                        student_number = reader["student_number"].ToString(),
                        student_department = reader["student_department"].ToString()
                    };
                    students.Add(log);
                }
                return students;
            }
            return null;
        }

        DAL.DAL access3 = new DAL.DAL();
        public int Add(string name, string number, string department)
        {
            int result = access3.UpdateDB("INSERT INTO Students (student_name, student_number, student_department) VALUES ('"
                + name + "','" + number + "','" + department + "')", CommandType.Text);

            return result;
        }

        DAL.DAL access4 = new DAL.DAL();
        public int Update(int id, string name, string number, string department)
        {
            int result = access4.UpdateDB("UPDATE Students SET name='" + name +
                "', student_number='" + number +
                "', student_department='" + department +
                "' WHERE student_id=" + id + "",
                CommandType.Text);

            return result;
        }

        DAL.DAL access5 = new DAL.DAL();
        public int Delete(int id)
        {
            int result = access5.UpdateDB("DELETE FROM Students WHERE student_id=" + id + "", CommandType.Text);
            return result;
        }
    }
}
