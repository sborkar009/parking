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
   public class CRUDTotalamount
    {
        public void VehicleTotalamount()
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            String query = "InsertTotalamount";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@amountid", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@TicketID", SqlDbType.Int).Value = 305;
            cmd.Parameters.Add("@vehiclename", SqlDbType.VarChar).Value = "FORTUNER";
            cmd.Parameters.Add("@amount", SqlDbType.Int).Value = 50;
            cmd.Parameters.Add("@parkingduration", SqlDbType.Int).Value = 160;
            cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = "I";
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

        }
    }
}
