   M S B A M L   `   `   `  ����E  AOrderBoard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:OrderBoard.ViewsOrderBoard.Views  5      =#clr-namespace:OrderBoard.ConvertersOrderBoard.Converters  5      (    "OrderBoard.Views.OrderCreationView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:OrderBoard.Views     5      4conv#clr-namespace:OrderBoard.Converters     5        N� Title$  CreationOrderView��5
       � 	Resources 5      2   ,OrderBoard.Converters.OrderPriorityConverter   OrderPriorityConverter.   (OrderBoard.Converters.IndexToIdConverter  IndexToIdConverter��%:   &	        &	        5   
   6&     5   
   6"   5      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   ��  	 Title#��[ 6   Новая заявка6A   �� 5   
   $��1��6   .+�5      ��  
 Prompt#��[ 6   $��0 10 0 5q�68   Название6T   �� 5        Text#��[ 6   ��64   �� *
Order.Name+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5    
   $��2��6   .+�5!      �� #��[ 6   $��0 10 0 5q�68   Описание6T   �� 5"      #��[ 6    �� AcceptsReturn$
 True��64   $	��200��5#       �� TextWrapping$
 Wrap=�6#   ��5$      �� *Order.Description+$ TwoWay=�$ PropertyChanged=�5&      �� 5'   
   $��3��6   $��Создать��6   $	��150��5(      $��40��6   $��18(�5)      $
��Left=�6   
������$��Bottom=�5*      ��5'   0   �� *OrderAddCommand+5*      � 5+   
   $��1��6   $��4��6   $��10 0 0 0q�60    5,      �� 5-      $
��auto �6    60   �� 5.      $
��auto �6    60   �� 5/      $
��auto �6    60   �� 50      $
��auto �6    60   .+�52      �� .+�53      �� #��[ 6   $��0 10 0 5q�6<   Клиент6V   �� 54       �� DisplayMemberPath$
 Name��6;   ��6   �� *	Clients+	 �� SelectedItem	 55      �� *Order.ClientData+$ TwoWay=�$ PropertyChanged=�57      �� 58      $��1��6   .+�59      �� #��[ 6   $��0 10 0 5q�6<   Договор6W   �� 5:      $
 Name��6=   ��6   �� *	Contracts+	 5;      �� *Order.ContractData+$ TwoWay=�$ PropertyChanged=�5=      �� 5>      $��2��6   .+�5?      �� #��[ 6   $��0 10 0 5q�6<   Приоритет6Y   �� 5@      
 �� SelectedValue
 6   �� *Order.OrderPriority+$ TwoWay=�$ PropertyChanged=���5A   ;   �� *OrderPriorities+5B      5C      �� 5D      $��3��6   .+�5E      �� #��[ 6   $��0 10 0 5q�6<   *(Плановая дата решения6e   (  "System.Windows.Controls.DatePicker  5F      -   5        $��datePicker1��5F         IsDropDownOpen$ False��5G         SelectedDateFormat$ Short=�5H         SelectedDate 64   �� *Order.EndDate+5I      5J      5K      5L      