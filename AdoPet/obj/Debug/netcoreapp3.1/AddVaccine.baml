   M S B A M L   `   `   `  ����A  =AdoPet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AdoPetAdoPet  5   	       AdoPet.AddVaccine   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:AdoPet     5   	     � Title$  Details��5   	   $	��450��6   $	��800��6&      
GlobalFont#���   62    � 	Resources 5	       �� 
TargetType �� 	Resources �� Property �� Value��%H  '��       '�� �     �� 5
   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��CornerRadius$ 8��65   5      5      5      �� 5   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��CornerRadius$ 6��65   5      5      5      5      .��5      � ��5   
   �� 5       �� ImageSource$ /Pic/bluegradient.jpg��6    �� Opacity$
 0.55Q�6=    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��* �6   �� 5!      $��* �6   	 � RowDefinitions	 5#   
   �� 5$      $��* �6   �� 5%      $��* �6   �� 5&      $��* �6   �� 5'      $��* �6   �� 5(      $��* �6   �� 5)      $��* �6   �� 5*      $��* �6   �� 5+      $��* �6   .+�5-   
   �� $��Szczepienie��6   $��1��6&   $��0��63   $��16(�6D   $
��Bold"�6R   $��Center=�6d   $��Center=�6   
�������6�   �� 5.   
   -   5        
 ��Name$
 txbNameSelectedPet��5.      $��1��60   $��1��6@   $��Center=�6M   $��Center=�6h   $��16(�6�   $
��Bold"�6�   $��15q�6�   �� 5/   
   $��Wykonane szczepienia��6   $��1��6/   $��2��6<   $��2��6L   $��16(�6`   $
��Bold"�6n   $��Center=�6�   $��Center=�6�   
�������6�   �� 50   
   $�� ��6   $��1��6   $��2��6(   $��2��68   $��16(�6L   $
��Bold"�6Z   $��Center=�6l   $��Center=�6�   
�������6�   �� 51   
   $��Nazwa szczepionki��6   $��2��6,   $��0��69   $��16(�6I   $
��Bold"�6W   $��Center=�6i   $��Center=�6�   
�������$��	Amatic SC)�6�   �� 52   
   $��Data zaszczepienia��6   $��3��6-   $��0��6:   $��16(�6J   $
��Bold"�6X   $��Center=�6j   $��Center=�6�   
�������6�   �� 53   
   $ ��Data kolejnego szczepienia��6   $��4��65   $��0��6B   $��14(�6R   $
��Bold"�6`   $��Center=�6r   $��Center=�6�   
�������6�   �� 54   
   -   5         ��Name$ btnAddVacine��54      $��Dodaj szczepienie��6'   $��0��6C   $��7��6S   $��2��6`   $��60,10q�6t   ���	#FF520E79
�������$��16(�6�   $
��Bold"�6�   6�   �� 55   
   -   5         ��Name$ 	cbVaccine��55      $��2��6&   $��1��63   $��15q�6C   �� 56   
   -   5         ��Name$ txtDateNextVaccine��56      $��1��6.   $��4��6>   $��15q�6K    �� 
IsReadOnly$
 True��6W   (  "System.Windows.Controls.DatePicker  57   
   -   5          Name$ dpVaccinesDate��57      $��3��6-   $��1��6:   $��15q�6J   6V   � 58   
   $��5��6   $��0��6   $��2��6,   $��2��6@   .+�59      �� -   5        $ txtComments��59      ���	#FF520E79$��10q�6C   $��Center=�6O   �� 5:       J� IsHitTestVisible$ False��6   $(��"Wpisz uwagi dotyczące szczepienia��61   $	��Top=�6Z   $��Right=�6r   $��
0,23,187,0q�6�   
���������5;      �� 5<      " ��6   .�5=      ��  � y�$ 	Collapsed=�67    �� Triggers 5>      �� 5?       �� Binding 6*   �� *Text+ �� ElementName$ txtComments�� �� Value  6\   .a�5@   "   ��  � y�$ Visible=�6?   5A      5C      5E      5F      &   System.Windows.Controls.DataGrid  5G   
   -   5          Name$ dgPetVaccines��5G      $��3��6*   $��2��67   $��2��6G   $��4��6[   $��10q�6l      Columns 5H      0  *System.Windows.Controls.DataGridTextColumn  5I      ,  &System.Windows.Controls.DataGridColumn   Header$ Nazwa szczepionki��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6@   �� *NameVaccine+  5J      $ Data zaszczepienia��6%    6A   �� *InoculationDate+  5K      $  Data kolejnego szczepienia��6%    6J   �� *ValidityDate+4  .System.Windows.Controls.DataGridTemplateColumn  5L         CellTemplate 5M      �� 5N      .R�5O      �� $��Edytuj��6%   ���	#FF520E79
�������6M   5P      5R      5T      5U      5V      