using OrderBoard.Constants;
using OrderBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using OrderBoard.DialogServices;

namespace OrderBoard.AppHelpers
{
    public class AppController
    {
        public ModelStorage ModelStorage { get; set; }
        public Dictionary<OrderStatus, List<OrderStatus>> OrderStatusDictonary { get; set; }
        public LoadBarDialogService LoadBarDialogService { get; set; }
        private AppController() 
        {
            ModelStorage = new ModelStorage();
            OrderStatusDictonary = new();
            FillOrderStatusDictionary(OrderStatusDictonary);
            LoadBarDialogService = new LoadBarDialogService();
        }

        private static AppController? _instance;

        public static AppController Instance
        {
            get 
            { 
                return _instance ?? (_instance = new AppController()); 
            }
        }

        public Window GetActiveWindow()
        {
            WindowCollection windowCollection = Application.Current.Windows;
            foreach(Window window in windowCollection)
            {
                if (window.IsActive)
                {
                    return window;
                }
            }
            return null;
        }

        private void FillOrderStatusDictionary(Dictionary<OrderStatus, List<OrderStatus>> dic)
        {
            dic.Add(OrderStatus.Open, new() { OrderStatus.Open, OrderStatus.Await, OrderStatus.Solved });
            dic.Add(OrderStatus.Await, new() { OrderStatus.Await, OrderStatus.Open, OrderStatus.Solved });
            dic.Add(OrderStatus.Solved, new() { OrderStatus.Solved, OrderStatus.Open, OrderStatus.Closed });
            dic.Add(OrderStatus.Closed, new() { OrderStatus.Closed, OrderStatus.Deleted });
        }
    }
}
