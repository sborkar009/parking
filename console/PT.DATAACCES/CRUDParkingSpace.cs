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
  public class CRUDParkingSpace
    {
        public void vehicaParkingSpace()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Defaultconnection"].ToString());
            string query = "ParkingSpace1";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@SpaceID", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@NOOFSPACE", SqlDbType.Int).Value = 500;
            cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = "I";
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
