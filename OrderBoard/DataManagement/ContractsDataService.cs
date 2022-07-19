using OrderBoard.Datas;
using OrderBoard.DbHelpers.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OrderBoard.DataManagement
{
    public class ContractsDataService : IDataService<ContractData>
    {
        private SqlServerHelper _dbHelper;
        public ContractsDataService()
        {
            _dbHelper = new SqlServerHelper();
        }
        public void AddData(ContractData data)
        {
            _dbHelper.ContractDatas.Add(data);
            _dbHelper.SaveChanges();
        }

        public List<ContractData> GetDatas()
        {
            return _dbHelper.ContractDatas.Include(c => c.Client).ToList();
        }

        public void RemoveData(ContractData data)
        {
            _dbHelper.ContractDatas.Remove(data);
            _dbHelper.SaveChanges();
        }
    }
}
