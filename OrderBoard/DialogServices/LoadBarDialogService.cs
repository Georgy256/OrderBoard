using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderBoard.Views;
using OrderBoard.AppHelpers;

namespace OrderBoard.DialogServices
{
    public class LoadBarDialogService
    {
        public void Open()
        {
            LoadBarView loadBarView = new LoadBarView();
            loadBarView.DataContext = this;
         
            loadBarView.Show();
        }

        public void Close()
        {
            AppController.Instance.GetActiveWindow().Close();
        }
    }
}
