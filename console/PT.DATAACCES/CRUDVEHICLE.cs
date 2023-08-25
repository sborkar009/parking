using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace PT.DATAACCES
{
    public class CRUDVEHICLE
    {
        public void vehicle()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());

            string query = "Vehicle1";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.Add("@VehicleID", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@VehicleNoPlate", SqlDbType.VarChar).Value = "MH34 GD 0009";
            cmd.Parameters.Add("@OwnerName", SqlDbType.VarChar).Value = "shubham";
            cmd.Parameters.Add("@ContactNo", SqlDbType.VarChar).Value = "8668582779";
            cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = "I";
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void vehicle2()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            String query = "Vehicle1";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@VehicleID", SqlDbType.Int).Value = 226;
            cmd.Parameters.Add("@VehicleNoPlate", SqlDbType.VarChar).Value = "MH33 FF 0001";
            cmd.Parameters.Add("@OwnerName", SqlDbType.VarChar).Value = "RAM";
            cmd.Parameters.Add("@ContactNo", SqlDbType.VarChar).Value = "8168582779";
            cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = "U";

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void vehicle3()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            String query = "Vehicle1";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@VehicleID", SqlDbType.Int).Value = 230;
            cmd.Parameters.Add("@VehicleNoPlate", SqlDbType.VarChar).Value = "MH33 FF 0001";
            cmd.Parameters.Add("@OwnerName", SqlDbType.VarChar).Value = "RAM";
            cmd.Parameters.Add("@ContactNo", SqlDbType.VarChar).Value = "8168582779";
            cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = "D";
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        public void vehicle4()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            String query = "insert into Vehicle values('MH12 DF 4500','ASHU','6890699845',GETDATE())";

            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

        }
        public void vehicle5()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            String query = "update  Vehicle set OwnerName='Akshay' where VehicleId=201";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void vehicle6()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            String query = "delete from Vehicle  where VehicleId=225";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void vehicle7()
        {

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            String query = "SELECT* FROM Vehicle";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            {
                while (dr.Read())
                {
                    Console.WriteLine("VehicleID: " + dr["VehicleID"] + "VehicleNoPlate: " + dr["VehicleNoPlate"] + "OwnerName: " + dr["OwnerName"] + "ContactNo: " + dr["ContactNo"]);

                }
            }
            connection.Close();
            Console.ReadLine();

        }
        public void vehicle8()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            string query1 = "select *from Vehicle";
            SqlDataAdapter cmd = new SqlDataAdapter(query1, connection);
            DataSet ds = new DataSet();
            cmd.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)

            {
                Console.WriteLine("{0} {1} {2} {3} {4}", row[0], row[1], row[2], row[3], row[4]);
            }
            Console.ReadLine();
        }

    }
}

    

