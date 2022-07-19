using OrderBoard.DataManagement;
using OrderBoard.Datas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBoard.Models
{
    public class ClientsModel : IModel<ClientData>
    {
        public event EventHandler? ModelChanged;
        private IDataService<ClientData> _dataService;

        public ClientsModel(IDataService<ClientData> dataService)
        {
            _dataService = dataService;
        }

        protected void OnModelChanged()
        {
            ModelChanged?.Invoke(this, new EventArgs());
        }

        public void AddClient(ClientData client)
        {
            _dataService.AddData(client);
            OnModelChanged();
        }

        public ObservableCollection<ClientData> GetDatas()
        {
            return new( _dataService.GetDatas());
        }
    }
}
