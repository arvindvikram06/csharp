using System;

namespace  Task6.services
{
    public class WarehouseService
    {
        static int dispatched = 0;
        public void PrepareShipment(int orders)
        {
            dispatched += orders;
            Console.WriteLine($"preparing shipment for {orders} orders");
            Console.WriteLine($"Totally Dispatched {dispatched} orders");

        }
    }
}