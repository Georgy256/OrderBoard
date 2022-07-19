using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderBoard.Datas;

namespace OrderBoard.Events.Args
{
    public class OrderEventArgs : EventArgs
    {
        public OrderEventArgs(OrderData orderData)
        {
            OrderData = orderData;
        }

        public OrderData OrderData { get; set; }
    }
}
