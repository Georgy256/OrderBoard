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
using System.Windows.Shapes;
using OrderBoard.ViewModels;

namespace OrderBoard.Views
{
    public partial class AppControlView : Window
    {
        private Button? _selectedButton = null;
        public AppControlView()
        {
            InitializeComponent();

            DataContext = new AppControlViewModel();
            SetSelectedButton(OrdersButton);
            SelectMenuButton(OrdersButton);
        }

        public void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            Button? button = e.Source as Button;
            if (_selectedButton is not null)
            {
                UnselectButton(_selectedButton);
                SetSelectedButton(null);
            }
            if (button is not null)
            {
                SelectMenuButton(button);
                SetSelectedButton(button);
            }
        }

        private void SetSelectedButton(Button? button)
        {
            _selectedButton = button;
        }

        private void SelectMenuButton(Button button)
        {
            button.Style = (Style)this.Resources["SelectedMenuButton"];
        }

        private void UnselectButton(Button button)
        {
            button.Style = (Style)this.Resources["MenuButton"];
        }
    }
}
