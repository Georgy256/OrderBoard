using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using OrderBoard.DataManagement;
using OrderBoard.Datas;

namespace OrderBoard.Models
{
    public class ContractsModel : IModel<ContractData>
    {
        public event EventHandler? ModelChanged;
        private IDataService<ContractData> _dataService;

        public ContractsModel(IDataService<ContractData> dataService)
        {
            _dataService = dataService;
        }

        protected void OnModelChanged()
        {
            ModelChanged?.Invoke(this, new EventArgs());
        }

        public ObservableCollection<ContractData> GetDatas()
        {
            return new(_dataService.GetDatas());
        }

        public void AddContract(ContractData contract)
        {
            contract.ClientId = contract.Client.ClientId;
            contract.Client = null;
            _dataService.AddData(contract);
            OnModelChanged();
        }
    }
}
