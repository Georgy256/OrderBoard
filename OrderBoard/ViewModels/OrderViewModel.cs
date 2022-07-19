using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderBoard.Commands;
using OrderBoard.Constants;
using OrderBoard.Datas;
using OrderBoard.AppHelpers;
using OrderBoard.Views;
using System.Windows;

namespace OrderBoard.ViewModels
{
    public class OrderViewModel : Notifier
    {
        private AppController _appController;
        public OrderViewModel(OrderData orderData)
        {
            _appController = AppController.Instance;
            Order = orderData;
            LoadStatusList(orderData.OrderStatus);
            OrderEditCommand = new DelegateCommand(EditOrder);
        }

        public OrderData Order { get; set; }
        public ObservableCollection<OrderStatus> CurrentStatusList { get; set; } = new();
        public OrderStatus CurrentStatus 
        {
            get => Order.OrderStatus;
            set
            {
                Order.OrderStatus = value;
                CurrentStatus_Changed(value);
            }
        }
        public DelegateCommand OrderEditCommand { get; set; }
        public void LoadStatusList(OrderStatus orderStatus)
        {
            CurrentStatusList = new(_appController.OrderStatusDictonary[orderStatus]);
        }
        private void CurrentStatus_Changed(OrderStatus orderStatus)
        {
            if (orderStatus == OrderStatus.Deleted)
            {
                _appController.ModelStorage.Orders.RemoveOrder(Order);
            }
            else
            {
                _appController.ModelStorage.Orders.UpdateOrder(Order);
            }
        }

        private void EditOrder(object? parameter)
        {
            
            OrderEditingView orderEditingView = new OrderEditingView(Order);
            orderEditingView.Owner = Application.Current.MainWindow;
            orderEditingView.Show();
        }
    }
}
