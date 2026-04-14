using System;
using Task6.delegates;

namespace Task6.core
{
class OrderProcessor
{
    private int OrderCount = 0;
    private int sno = 0;
    private int threshold;

    public event OrderBatchReadyHandler OnBatchReady;

    public OrderProcessor(int threshold)
    {
        this.threshold = threshold;
    }

    public void AddOrder()
    {
        OrderCount++;
        sno++;
        Console.WriteLine($"order received -- order no : {this.sno} , undispatched orders : {this.OrderCount}");

        if(OrderCount == threshold)
        {
            RaiseEvent();
            OrderCount = 0;
        }
    }

    public void RaiseEvent()
    {
        Console.WriteLine($"Threshold reached || [Triggering EVENT]");
        OnBatchReady?.Invoke(threshold);
    }
}

}