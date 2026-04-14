using System;
using Task6.core;
using Task6.services;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        public async static Task Main(String[] args){
            OrderProcessor processor = new OrderProcessor(5);
            WarehouseService warehouse = new WarehouseService();
            LoggingService logger = new LoggingService();
            NotificationService notfiy = new NotificationService();

            processor.OnBatchReady += warehouse.PrepareShipment;
            processor.OnBatchReady += notfiy.SendNotification;
            processor.OnBatchReady += logger.LogOrder;


            for (int i = 0; i < 12; i++)
            {
                processor.AddOrder();

                await Task.Delay(1000); 
            }


        }
    }
}