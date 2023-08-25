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
   public class CRUDParkingTicket
    {
        public void VehicleParkingTicket()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Defaultconnection"].ToString());
            String query = "ParkingTicket12";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TicketID", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@VehicleID", SqlDbType.Int).Value = 207;
            cmd.Parameters.Add("@SpaceID", SqlDbType.Int).Value = 407;
            cmd.Parameters.Add("@EntryDateTime", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.Add("@ExitDateTime", SqlDbType.DateTime).Value = DateTime.Now;
            cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = "I";
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();


        }
    }
}
