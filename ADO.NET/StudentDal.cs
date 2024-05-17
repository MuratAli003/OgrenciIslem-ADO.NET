using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ADO.NET
{
    internal class StudentDal
    {
        
        SqlConnection _connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB;initial catalog = Students; integrated security = true");

        
        private void connectionIsOpen()
        {
            if(_connection.State == ConnectionState.Closed) 
            {
                _connection.Open();
            }
        }

        
        public List<Student> GetAll()
        {
            connectionIsOpen();

            SqlCommand command = new SqlCommand("Select * from Student", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Student> students = new List<Student>();

            while(reader.Read())
            {
                Student student = new Student()
                {
                    Id = Convert.ToInt32(reader["ID"]),
                    Name = Convert.ToString(reader["Name"]),
                    Surname = Convert.ToString(reader["Surname"]),
                    No = Convert.ToInt32(reader["No"])
                };
                students.Add(student);
            }

            reader.Close();
            _connection.Close();
            return students;
        }

        public void Add(Student student)
        {
            connectionIsOpen();

            SqlCommand command = new SqlCommand("Insert into Student values (@name,@surname,@no)", _connection);

            command.Parameters.AddWithValue("@name", student.Name);
            command.Parameters.AddWithValue("@surname", student.Surname);
            command.Parameters.AddWithValue("@no", student.No);
            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Update(Student student)
        {
            connectionIsOpen();

            SqlCommand command = new SqlCommand("Update Student set  Name = @name ,Surname = @surname  ,No = @no where Id = @ıd", _connection);

            command.Parameters.AddWithValue("@name", student.Name);
            command.Parameters.AddWithValue("@surname", student.Surname);
            command.Parameters.AddWithValue("@no", student.No);
            command.Parameters.AddWithValue("@ıd", student.Id);
            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Delete(int id)
        {
            connectionIsOpen() ;
            SqlCommand command = new SqlCommand("Delete from Student where Id = @ıd", _connection);
            command.Parameters.AddWithValue("@ıd", id);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
