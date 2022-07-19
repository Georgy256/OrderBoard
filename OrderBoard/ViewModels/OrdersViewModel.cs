using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using OrderBoard.Datas;
using OrderBoard.Models;
using OrderBoard.AppHelpers;
using OrderBoard.Commands;
using OrderBoard.Constants;

namespace OrderBoard.ViewModels
{
    public class OrdersViewModel : Notifier, IListViewModel<OrderViewModel>
    {
        private OrdersModel _ordersModel;
        private ObservableCollection<OrderViewModel> _orderViewModels = new();
        public OrdersViewModel()
        {
            _ordersModel = AppController.Instance.ModelStorage.Orders;
            _ordersModel.ModelChanged += ordersModel_Changed;
            LoadList();
        }
        public ObservableCollection<OrderViewModel> List
        {
            get => _orderViewModels;
            set
            {
                _orderViewModels = value;
                OnPropertyChanged("List");
            }
        }

        public void LoadList()
        {
            ObservableCollection<OrderData> orderDatas = _ordersModel.GetDatas();
            foreach (var orderData in orderDatas)
            {
                List.Add(new OrderViewModel(orderData));
            }
        }
        public void ClearList()
        {
            List = new();
        }
        
        private void ordersModel_Changed(object? sender, EventArgs e)
        {
            ClearList();
            LoadList();
            //to do: оптимизировать загрузку
        }
    }
}
