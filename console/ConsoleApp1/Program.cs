using PT.DATAACCES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT.DATAACCES

{
     class Program
    {
        static void Main(string[] args)
        {
            CRUDTotalamount obj = new CRUDTotalamount();
            obj.VehicleTotalamount();


            CRUDParkingTicket obj2 = new CRUDParkingTicket();
            obj2.VehicleParkingTicket();


            CRUDParkingSpace obj3 = new CRUDParkingSpace();
            obj3.vehicaParkingSpace();

            CRUDVEHICLE obj4 = new CRUDVEHICLE();
            obj4.vehicle();



        }
    }
}
