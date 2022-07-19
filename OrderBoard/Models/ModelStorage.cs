using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderBoard.DataManagement;

namespace OrderBoard.Models
{
    public class ModelStorage
    {
        public ModelStorage()
        {
            OrdersDataService ordersDataService = new OrdersDataService();
            Orders = new OrdersModel(ordersDataService);

            ClientsDataService clientsDataService = new ClientsDataService();
            Clients = new ClientsModel(clientsDataService);

            ContractsDataService contractsDataService = new ContractsDataService();
            Contracts = new ContractsModel(contractsDataService);
        }
        public OrdersModel Orders { get; set; }
        public ClientsModel Clients { get; set; }
        public ContractsModel Contracts { get; set; }
    }
}
