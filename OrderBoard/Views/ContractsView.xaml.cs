﻿using System;
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
using OrderBoard.ViewModels;
using OrderBoard.Models;

namespace OrderBoard.Views
{
    /// <summary>
    /// Логика взаимодействия для ContractsView.xaml
    /// </summary>
    public partial class ContractsView : Page
    {
        public ContractsView()
        {
            InitializeComponent();

            DataContext = new ContractsViewModel();
        }
    }
}
