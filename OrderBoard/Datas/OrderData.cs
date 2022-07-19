using System;
using System.ComponentModel.DataAnnotations.Schema;
using OrderBoard.AppHelpers;
using OrderBoard.Constants;

namespace OrderBoard.Datas
{
    public class OrderData : Notifier
    {
        public int OrderId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int? ClientId { get; set; }
        public ClientData? ClientData { get; set; }
        public int? ContractId { get;set; }
        public ContractData? ContractData { get; set; }
        public DateTime? EndDate { get; set; }
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Open;
        public OrderPriority OrderPriority { get; set; } = OrderPriority.Middle;
    }
}
