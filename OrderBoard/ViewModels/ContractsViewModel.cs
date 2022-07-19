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
    public class ContractsViewModel
    {
        private ContractsModel _contractsModel;
        public ContractsViewModel()
        {
            _contractsModel = AppController.Instance.ModelStorage.Contracts;
            ListViewModel = new ListViewModel<ContractData>(_contractsModel);
            AddContractCommand = new DelegateCommand(AddClient);
        }

        public ListViewModel<ContractData> ListViewModel { get; set; }

        public DelegateCommand AddContractCommand { get; set; }

        private void AddClient(object? parameter)
        {
            IDataInputDialogService<ContractData> contractDialogService = new ContractDialogService();
            if (contractDialogService.Open())
            {
                _contractsModel.AddContract(contractDialogService.DataInput);
            }
        }
    }
}
