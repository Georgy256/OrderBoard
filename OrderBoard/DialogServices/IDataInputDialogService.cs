using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBoard.DialogServices
{
    public interface IDataInputDialogService<T>
    {
        T DataInput { get; set; }
        bool Open();
    }
}
