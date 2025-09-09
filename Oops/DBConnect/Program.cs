using Microsoft.Data.SqlClient;
using System.Data;

namespace DBConnect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Mircosoft.data.sqlclient is dependency for this to work
            //5 steps of data Connection
            //1. Create a connection string ". or instance name //default port number 1433
            //2. Open the connection
            //3. Write Command
            //4. Execute Command
            //5. Close the connection
            //SqlConnection con=new SqlConnection("server=.;database=Sanjay;uid=sa;pwd=rps@12345;encrypt=false;TrustServerCertificate=false");

            //con.Open();
            //Console.WriteLine("Enter marks ");
            //string m=Console.ReadLine();


            //SqlCommand cmd = new SqlCommand("select * from student where Marks > @marks", con);
            //cmd.Parameters.AddWithValue("@marks", con);

            //SqlDataReader dr=cmd.ExecuteReader();
            //Console.WriteLine();

            //while (dr.Read())
            //{
            //    //Console.WriteLine("{0} {1}", dr[0], dr[1]);
            //    Console.WriteLine("{0} {1} ", dr["StId"], dr["sname"]);
            //}
            //con.Close();
            //Console.WriteLine("Enter name");
            //string m = Console.ReadLine();
            //SqlCommand cmd = new SqlCommand("select * from Student where sname=@nm", con);
            //cmd.Parameters.AddWithValue("@nm", m);
            //SqlDataReader dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //    //Console.WriteLine("{0} {1}",dr[0],dr[1]);
            //    Console.WriteLine("{0} {1}", dr["StID"], dr["Sname"]);
            //}
            //con.Close();

            //Execute Scaler

            //SqlConnection con = new SqlConnection("server=.;database=HR;uid=sa;pwd=rps@12345;encrypt=false;TrustServerCertificate=false");

            //con.Open();

            //SqlCommand cmd = new SqlCommand("select sum(sal) from emp",con);

            //object val = cmd.ExecuteScalar();
            //Console.WriteLine(val);


            //DML operations
            //SqlConnection con = new SqlConnection("server=.;database=Sanjay;uid=sa;pwd=rps@12345;encrypt=false;TrustServerCertificate=false");

            //con.Open();
            //SqlCommand cmd = new SqlCommand("insert into Demo1 (id,name) values (@id,@name)", con);
            //Console.WriteLine("Enter id and  name ");
            //cmd.Parameters.AddWithValue("@id", Console.ReadLine());
            //cmd.Parameters.AddWithValue("@name", Console.ReadLine());

            //int r = cmd.ExecuteNonQuery();


            //if (r > 0)
            //{

            //    Console.WriteLine(" {0} Rows affected ", r);
            //}


            //SqlCommand cmd1 = new SqlCommand("Update Demo1 Set name=@name where id=@id",con);
            //Console.WriteLine("Enter id and  Name wher Name is update");
            //cmd1.Parameters.AddWithValue("@id", Console.ReadLine());
            //cmd1.Parameters.AddWithValue("@name", Console.ReadLine());

            //int r2= cmd1.ExecuteNonQuery();
            //if (r > 0)
            //{
            //    Console.WriteLine("Rows affected");
            //}

            //SqlConnection con = new SqlConnection("server=.;database=Sanjay;uid=sa;pwd=rps@12345;encrypt=false;TrustServerCertificate=false");
            //con.Open();

            //SqlCommand cmd2 = new SqlCommand("stu", con);
            //SqlDataReader reader = cmd2.ExecuteReader();

            //while (reader.Read())
            //{
            //    Console.WriteLine(reader["Sname"]);
            //}
            //stored procedure with parameter sql query

            //SqlCommand cmd2 = new SqlCommand("exec Markwith @marks", con);
            //cmd2.Parameters.AddWithValue("@marks",Console.ReadLine());
            //SqlDataReader reader = cmd2.ExecuteReader();

            //while (reader.Read())
            //{
            //    Console.WriteLine(reader["Sname"]);
            //}

            SqlConnection con = new SqlConnection("server=.;database=Sanjay;uid=sa;pwd=rps@12345;encrypt=false;TrustServerCertificate=false");
            try
            {
                con.Open();

                SqlCommand cmd2 = new SqlCommand("Markwith", con);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@marks", Console.ReadLine());
                SqlDataReader reader = cmd2.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader["Sname"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
            con.Close();
            }





        }
    }
}
