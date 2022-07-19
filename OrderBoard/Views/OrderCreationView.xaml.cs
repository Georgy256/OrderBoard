using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OrderBoard.DataManagement;
using OrderBoard.Models;
using OrderBoard.ViewModels;

namespace OrderBoard.Views
{
    /// <summary>
    /// Логика взаимодействия для CreationOrderView.xaml
    /// </summary>
    public partial class OrderCreationView : Page
    {
        public OrderCreationView()
        {
            InitializeComponent();

            DataContext = new OrderCreationViewModel();
        }
    }
}
