   M S B A M L   `   `   `  ����E  AOrderBoard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:OrderBoard.ViewsOrderBoard.Views  5   	   +    %OrderBoard.Views.ContractCreationView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:OrderBoard.Views     5   	     � Title$  ContractCreationView��5   	   $	��450��6&   $	��800��63   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   ��  	  Title#��[  6   Новый договор6B   �� 5   
   $��1��6   .+�5      ��  
 Prompt#��[ 6   $��0 10 0 5q�68   Название6T   �� 5        Text#��[ 6   ��64   �� *DataInput.Name+5      �� 5   
   $��2��6   .+�5      �� #��[ 6   $��0 10 0 5q�68   Клиент6R   �� 5       �� DisplayMemberPath$
 Name��67   ��6   �� *	Clients+ �� SelectedItem 6P   �� *DataInput.Client+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�5      � 5   
   $��3��6    � Orientation$ 
Horizontal=�6!   .+�5      �� $
��Left=�6   .+�5      �� #��[ 6   $��0 10 0 5q�6<   Дата начала6[   (  "System.Windows.Controls.DatePicker  5         IsDropDownOpen$ False��5          SelectedDateFormat$ Short=�5!      	   SelectedDate	 64   �� *DataInput.StartDate+5"      �� 5#      $��	500 0 0 0q�6   $��Right=�6,   .+�5$      �� #��[ 6   $��0 10 0 5q�6<   Дата окончания6^     5%      $ False��5&      $ Short=�5'      	 64   �� *DataInput.EndDate+5(      5)      �� 5*   
   $��4��6   .+�5+      �� #��[ 6   $��0 10 0 5q�68   Стоимость6U   �� 5,      #��[ 6   ��64   �� *DataInput.Price+5-      �� 5.   
   $��5��6   $��Добавить��6   $	��150��5/      $��40��6   $��18(�50      $
��Left=�6   
������$��Bottom=�51      ��5.   1   �� *AddDataCommand+51      52      53      