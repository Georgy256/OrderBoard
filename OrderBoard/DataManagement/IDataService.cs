using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBoard.DataManagement
{
    public interface IDataService<T>
    {
        void AddData(T data);
        void RemoveData(T data);
        List<T> GetDatas();
    }
}
