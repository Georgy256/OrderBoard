   M S B A M L   `   `   `  ����E  AOrderBoard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:OrderBoard.ViewsOrderBoard.Views  5      !    OrderBoard.Views.OrdersView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:OrderBoard.Views     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3b+http://schemas.microsoft.com/xaml/behaviors  5        N� Title$  
OrdersView��5
      .��5      � .+�5   
   �� ��6   �� *List+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� View 5      �� 5       �� AllowsColumnReorder$ False��6   .P�5      �� $��Приоритет��6%    �� CellTemplate 5      �� 5      .R�5   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5   &   �� $��5��60   $��	-5 0 10 0q�6:   $��Stretch=�6M   ��5   *   �� 5   .    �� Triggers 5   2   �� 5   6    �� Binding 6B   �� *Order.OrderPriority+	 �� Value	 Low6j   .a�5   :   �� 
 �� Property
 � �� �� Value
 � � �6[   5   7   �� 5   6    6B   �� *Order.OrderPriority+
	 Middle6j   .a�5   :   �� 
 � ��
 � ���6[   5   7   �� 5   6    6B   �� *Order.OrderPriority+	 High6j   .a�5    :   �� 
 � ��
 �  ��6[   5!   7   5#   /   5%   '   �� 5&   &   ��60   �� *Order.OrderPriority+5'   #   5(      5*      �� 5+       �� DisplayMemberBinding 6%   �� *Order.OrderId+.��6T   
Номер6[   �� 5,       6%   �� *
Order.Name+.��6Q   Название6[   �� 5-       6%   �� *Order.ClientData.Name+.��6\   Клиент6d   �� 5.      $��Статус��6%    5/      �� 50      .R�51   "   �� ��6+   �� *CurrentStatusList+$ TwoWay=�$ PropertyChanged=� �� SelectedItem 53   K   �� *CurrentStatus+$ TwoWay=�$ PropertyChanged=�55      57      �� 58      $��Действия��6%    59      �� 5:      .R�5;   "   �� 
�������$��0q�6<   ��6P   �� *OrderEditCommand+.��5<   &   �� $.��(/Resources/Images/ButtonIcons/pencil.png��6,   $��25��6^   5=   #   5>      5@      5A      5C      5D      5E      