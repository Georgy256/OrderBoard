using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBoard.DataManagement
{
    public interface IChangeableDataService<T> : IDataService<T>
    {
        void Update(T data);
    }
}
