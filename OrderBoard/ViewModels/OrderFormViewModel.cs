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
using OrderBoard.Constants;

namespace OrderBoard.ViewModels
{
    public class OrderFormViewModel : Notifier
    {
        protected readonly OrdersModel _ordersModel;
        protected OrderData _orderData = new();
        public OrderFormViewModel()
        {
            _ordersModel = AppController.Instance.ModelStorage.Orders;

            LoadContracts();
            LoadClients();

            OrderPriorities = new List<OrderPriority>() { OrderPriority.Low, OrderPriority.Middle,OrderPriority.High };
        }
        public OrderData Order
        {
            get => _orderData;
            set
            {
                _orderData = value;
                OnPropertyChanged("Order");
            }
        }
        public ObservableCollection<ContractData> Contracts { get; set; }
        public ObservableCollection<ClientData> Clients { get; set; }
        public List<OrderPriority> OrderPriorities { get; set; } 

        public void ClearOrder(object? parameter)
        {
            Order = new();
        }

        private void LoadContracts()
        {
            Contracts = AppController.Instance.ModelStorage.Contracts.GetDatas();
        }
        private void LoadClients()
        {
            Clients = AppController.Instance.ModelStorage.Clients.GetDatas();
        }
    }
}
