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

namespace OrderBoard.ViewModels
{
    public class OrderCreationViewModel : OrderFormViewModel
    {
        public OrderCreationViewModel(): base()
        {
            OrderAddCommand = new DelegateCommand(AddOrder, CanAddOrder);
            OrderAddCommand.ExecuteHandler += ClearOrder;
        }
        public DelegateCommand OrderAddCommand { get; set; }

        public void AddOrder(object? parameter)
        {
            _ordersModel.AddOrder(Order);
        }

        public bool CanAddOrder(object? parameter)
        {
            bool canExecute = true;
            if(Order.Name == "" ||
                Order.Description == "" ||
                Order.EndDate == null || 
                Order.ClientData == null || 
                Order.ContractData == null)
                canExecute = false;
            return canExecute;
        }
    }
}
