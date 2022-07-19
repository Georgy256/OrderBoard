using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderBoard.ViewModels
{
    public interface IListViewModel<T>
    {
        public ObservableCollection<T> List { get; set; }

        public void LoadList();
        public void ClearList();
    }
}
