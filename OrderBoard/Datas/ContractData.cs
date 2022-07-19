using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderBoard.AppHelpers;

namespace OrderBoard.Datas
{
    public class ContractData : Notifier
    {
        public int ContractId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int ClientId { get; set; }
        public ClientData? Client { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Price { get; set; }
        public List<OrderData>? OrderDatas { get; set; }
    }
}
