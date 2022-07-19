using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderBoard.AppHelpers;
using OrderBoard.Datas;
using OrderBoard.Models;
using OrderBoard.Commands;
using OrderBoard.DialogServices;

namespace OrderBoard.ViewModels
{
    public class ClientsViewModel
    {
        private ClientsModel _clientsModel;
        public ClientsViewModel()
        {
            _clientsModel = AppController.Instance.ModelStorage.Clients;
            ListViewModel = new ListViewModel<ClientData>(_clientsModel);
            AddClientCommand = new DelegateCommand(AddClient);
        }

        public ListViewModel<ClientData> ListViewModel { get; set; }

        public DelegateCommand AddClientCommand { get; set; }

        private void AddClient(object? parameter)
        {
            IDataInputDialogService<ClientData> clientDialogService = new ClientDialogService();
            if (clientDialogService.Open())
            {
                _clientsModel.AddClient(clientDialogService.DataInput);
            }
        }

    }
}
