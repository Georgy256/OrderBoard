using OrderBoard.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderBoard.DbHelpers.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace OrderBoard.DataManagement
{
    public class ClientsDataService : IDataService<ClientData>
    {
        private SqlServerHelper _dbHelper;
        public ClientsDataService()
        {
            _dbHelper = new SqlServerHelper();
        }

        public void AddData(ClientData data)
        {
            _dbHelper.ClientDatas.Add(data);
            _dbHelper.SaveChanges();
        }

        public List<ClientData> GetDatas()
        {
            return _dbHelper.ClientDatas.ToList();
        }

        public void RemoveData(ClientData data)
        {
            _dbHelper.ClientDatas.Remove(data);
            _dbHelper.SaveChanges();
        }
    }
}
