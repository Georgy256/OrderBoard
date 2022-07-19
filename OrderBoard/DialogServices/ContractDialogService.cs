using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderBoard.Datas;
using OrderBoard.Views;
using System.Collections.ObjectModel;
using OrderBoard.Commands;
using OrderBoard.AppHelpers;

namespace OrderBoard.DialogServices
{
    public class ContractDialogService : IDataInputDialogService<ContractData>
    {
        public ContractDialogService()
        {
            LoadClients();
            AddDataCommand = new DelegateCommand(AddData, CanAddData);
        }

        public ObservableCollection<ClientData> Clients { get; set; } = null!;
        public ContractData DataInput { get; set; } = new();
        public DelegateCommand AddDataCommand { get; set; }

        public bool Open()
        {
            ContractCreationView contractCreationView = new ContractCreationView();
            contractCreationView.DataContext = this;
            return contractCreationView.ShowDialog() == true;
        }

        private void AddData(object? parameter)
        {
            AppController.Instance.GetActiveWindow()!.DialogResult = true;
        }

        private bool CanAddData(object? parameter)
        {
            if (DataInput.StartDate == null ||
                DataInput.EndDate == null ||
                 DataInput.Name == string.Empty ||
                 DataInput.Price == null ||
                 DataInput.Client == null)
            {
                return false;
            }
            return true;
        }

        private void LoadClients()
        {
            Clients = AppController.Instance.ModelStorage.Clients.GetDatas();
        }
    }
}
