using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBoard.Constants
{
    public enum OrderStatus
    {
        Open=1,
        Closed,
        Await,
        Solved,
        Deleted
    }
}
