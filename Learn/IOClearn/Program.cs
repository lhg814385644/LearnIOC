using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOClearn.Orders;

namespace IOClearn
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new Order();
            order.Add();


            Console.ReadKey();
        }
    }
}
