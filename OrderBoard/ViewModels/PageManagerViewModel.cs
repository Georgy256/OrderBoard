using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderBoard.Commands;
using System.Runtime.CompilerServices;
using OrderBoard.AppHelpers;

namespace OrderBoard.ViewModels
{
    public class PageManagerViewModel : Notifier
    {
        public PageManagerViewModel()
        {
            PagePathChangeCommand = new DelegateCommand(ChangePagePath);
            ChangePagePath("OrdersView");
        }

        public DelegateCommand PagePathChangeCommand { get;set; }
        public string CurrentPagePath { get; set; } = null!;
        public void ChangePagePath(object? name)
        {
            CurrentPagePath = $"/Views/{name}.xaml";
            OnPropertyChanged("CurrentPagePath");
        }
    }
}
