using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderBoard.AppHelpers;
using OrderBoard.Commands;
using OrderBoard.Datas;
using OrderBoard.Views;

namespace OrderBoard.DialogServices
{
    public class ClientDialogService : IDataInputDialogService<ClientData>
    {
        public ClientDialogService()
        {
            AddDataCommand = new DelegateCommand(AddData, CanAddData);
        }
        public ClientData DataInput { get; set; } = new();
        public DelegateCommand AddDataCommand { get; set; }

        public bool Open()
        {
            ClientCreationView clientCreationView = new ClientCreationView();
            clientCreationView.DataContext = this;
            return clientCreationView.ShowDialog() == true;
        }

        private void AddData(object? parameter)
        {
            AppController.Instance.GetActiveWindow().DialogResult = true;
        }

        private bool CanAddData(object? parameter)
        {
            if (DataInput.PhoneNumber == string.Empty ||
                DataInput.Email == string.Empty ||
                 DataInput.Name == string.Empty ||
                 DataInput.Address == string.Empty)
            {
                return false;
            }
            return true;
        }
    }
}
