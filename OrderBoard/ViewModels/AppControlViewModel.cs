using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using OrderBoard.Commands;

namespace OrderBoard.ViewModels
{
    public class AppControlViewModel
    {
        public AppControlViewModel()
        {
            AppExitCommand = new DelegateCommand((obj) => { Application.Current.Shutdown(); });

            PageManagerViewModel = new PageManagerViewModel();
        }

        public DelegateCommand AppExitCommand { get; set; }

        public PageManagerViewModel PageManagerViewModel { get; set; }
    }
}
