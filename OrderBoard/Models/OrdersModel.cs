using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderBoard.Datas;
using OrderBoard.DataManagement;

namespace OrderBoard.Models
{
    public class OrdersModel : IModel<OrderData>
    {
        public event EventHandler? ModelChanged;
        private IChangeableDataService<OrderData> _dataService;

        public OrdersModel(IChangeableDataService<OrderData> dataService)
        {
            _dataService = dataService;
        }

        public void AddOrder(OrderData order)
        {
            order.ClientId = order.ClientData?.ClientId;
            order.ContractId = order.ContractData?.ContractId;
            order.ClientData = null;
            order.ContractData = null;
            _dataService.AddData(order);
            OnModelChanged();
        }

        public void RemoveOrder(OrderData orderData)
        {
            _dataService.RemoveData(orderData);
            OnModelChanged();
        }

        public void UpdateOrder(OrderData order)
        {
            _dataService.Update(order);
            OnModelChanged();
        }

        protected void OnModelChanged()
        {
            ModelChanged?.Invoke(this,new EventArgs());
        }

        public ObservableCollection<OrderData> GetDatas()
        {
            return new(_dataService.GetDatas());
        }
    }
}
