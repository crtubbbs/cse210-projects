using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

class _CTSalesReport
{
    private List<_CTOrder> _CTOrders;

    public _CTSalesReport(List<_CTOrder> _CTOrders)
    {
        this._CTOrders = _CTOrders;
    }

    public void GenerateReport()
    {
        Console.WriteLine("Sales Report:");
        Console.WriteLine("==============");

        decimal totalSales = 0;

        foreach (var order in _CTOrders)
        {
            Console.WriteLine($"Table Number: {order._CTTableNumber}");
            Console.WriteLine("Items:");

            foreach (var item in order._CTItems)
            {
                Console.WriteLine($"- {item._CTName}: {item._CTPrice:C}");
            }

            Console.WriteLine($"Total Price: {order._CTTotalPrice:C}");
            Console.WriteLine($"Order Time: {order._CTOrderTime}");

            Console.WriteLine();
            totalSales += order._CTTotalPrice;
        }

        Console.WriteLine($"Total Sales: {totalSales:C}");
    }
}
