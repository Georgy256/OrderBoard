using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderBoard.Datas;
using OrderBoard.DbHelpers.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace OrderBoard.DataManagement
{
    public class OrdersDataService : IChangeableDataService<OrderData>
    {
        private SqlServerHelper _dbHelper;

        public OrdersDataService()
        {
            _dbHelper = new SqlServerHelper();
        }

        public void AddData(OrderData data)
        {
            _dbHelper.OrderDatas.Add(data);
            _dbHelper.SaveChanges();
        }

        public List<OrderData> GetDatas()
        {
            return _dbHelper.OrderDatas.Include(o => o.ClientData).Include(o => o.ContractData).ToList();
        }

        public void RemoveData(OrderData data)
        {
            _dbHelper.OrderDatas.Remove(data);
            _dbHelper.SaveChanges();
        }

        public void Update(OrderData data)
        {
            bool success = false;
            do
            {
                try
                {
                    _dbHelper.OrderDatas.Update(data);
                    _dbHelper.SaveChanges();
                    success = true;
                }
                catch (InvalidOperationException ex)
                {
                    _dbHelper.OrderDatas.Remove(data);
                }

            } while (!success);
        }
    }
}
