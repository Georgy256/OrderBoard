using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderBoard.Datas;
using OrderBoard.Commands;
using OrderBoard.Models;
using OrderBoard.AppHelpers;
using System.Collections.ObjectModel;
using System.Windows;
using OrderBoard.Constants;

namespace OrderBoard.ViewModels
{
    public class OrderEditingViewModel : OrderFormViewModel
    {
        public OrderEditingViewModel(OrderData orderData) : base()
        {
            Order = orderData;
            Order.ClientData = Clients.Where((c) => c.ClientId == orderData.ClientId).FirstOrDefault();
            Order.ContractData = Contracts.Where((c) => c.ContractId == orderData.ContractId).FirstOrDefault();
            Order.OrderPriority = OrderPriorities.Where((o) => o == Order.OrderPriority).FirstOrDefault();
            OrderEditCommand = new DelegateCommand(EditOrder,CanEditOrder);
            OrderEditCommand.ExecuteHandler += RealeseOrderEditing;
        }

        public DelegateCommand OrderEditCommand { get; set; }

        public void EditOrder(object? parameter)
        {
            _ordersModel.UpdateOrder(Order);
        }

        public bool CanEditOrder(object? parameter)
        {
            bool canExecute = true;
            if (Order.Name == "" ||
                Order.Description == "" ||
                Order.EndDate == null ||
                Order.ClientData == null ||
                Order.ContractData == null)
                canExecute = false;
            return canExecute;
        }

        public void RealeseOrderEditing(object? parameter)
        {
            Window activeWindow = AppController.Instance.GetActiveWindow();
            activeWindow?.Close();
        }
    }
}
