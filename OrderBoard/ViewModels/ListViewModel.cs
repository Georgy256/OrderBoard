using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderBoard.Models;
using OrderBoard.AppHelpers;
using System.Collections.ObjectModel;

namespace OrderBoard.ViewModels
{
    public sealed class ListViewModel<T> : Notifier, IListViewModel<T>
    {
        private IModel<T> _model;
        private ObservableCollection<T> _listViewModel = new();

        public ListViewModel(IModel<T> model)
        {
            _model = model;
            _model.ModelChanged += model_Changed;
            LoadList();
        }

        public ObservableCollection<T> List
        {
            get => _listViewModel;
            set
            {
                _listViewModel = value;
                OnPropertyChanged("List");
            }
        }

        public void LoadList()
        {
            List = _model.GetDatas();
        }
        public void ClearList()
        {
            List = new();
        }

        private void model_Changed(object? sender, EventArgs e)
        {
            ClearList();
            LoadList();
            //to do: оптимизировать загрузку
        }
    }
}
