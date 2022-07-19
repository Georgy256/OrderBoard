using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderBoard.AppHelpers;

namespace OrderBoard.Datas
{
    public class ClientData : Notifier
    {
        public int ClientId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public List<OrderData>? OrderDatas { get; set; } 
        public List<ContractData>? ContractDatas { get; set; } 
    }
}
