   M S B A M L   `   `   `  ����A  =AdoPet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AdoPetAdoPet  5   	       AdoPet.VaccinesPanel   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:AdoPet     5   	     � Title$  VaccinesPanel��5   	   $	��450��6   $	��800��6,    � 	Resources 5	       �� 
TargetType �� 	Resources �� Property �� Value��%H  '��       '�� �     �� 5
   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��CornerRadius$ 8��65   5      5      5      �� 5   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��CornerRadius$ 6��65   5      5      5      5      .��5      � ��5   
   �� 5       �� ImageSource$ /Pic/bluegradient.jpg��6    �� Opacity$
 0.55Q�6=    � ColumnDefinitions 5   
   �� 5      $��3* �6   �� 5      $��2* �6   	 � RowDefinitions	 5!   
   �� 5"      $��5* �6   �� 5#      $��1* �6   .+�5&   
   �  5'      �� 5(      $��* �6#   5+      � 5,   
   $��1��6   	 5-      �� 5.      $��* �6    �� 5/      $��* �6    �� 50      $��* �6    �� 51      $��* �6    .+�53      �� $��Słownik szczepień��6   $��15,20,15,20q�60   
�������$��18(�6Y   $
��Bold"�6g   $��Center=�6y   $��Center=�6�   � 54      $��1��6   $��0��6    .+�55      �� -   5        
 ��Name$
 
txtVaccine��55   <   $��Center=�6   $��15,20,15,20q�6Q   ���	#FFB359E76f   �� 56       J� IsHitTestVisible$ False��6   $��Podaj nazwę szczepionki��65   $��Center=�6T   $
��Left=�6o   $��20,0,0,0q�6�   
���������57      �� 58      " ��6    .�59      ��  � y�$ 	Collapsed=�6;    �� Triggers 5:      �� 5;   "    �� Binding 6.   �� *Text+ �� ElementName$ 
txtVaccine�� �� Value  6_   .a�5<   &   ��  � y�$ Visible=�6C   5=   #   5?      5A      5B      � 5C      $��2��6   $��0��6    .+�5D      �� -   5        $
 txtMonth��5D      $��0��6,   $��2��6<   $��15,20,15,20q�6I   ���	#FFB359E7$��Center=�6v   �� 5E      $ False��6   $0��*Podaj ważność szczepionki w miesiącach��65   $��Center=�6c   $
��Left=�6~   $��20,0,0,0q�6�   
���������5F      �� 5G      " ��6    .�5H      ��  � y�$ 	Collapsed=�6;    5I      �� 5J   "    6.   �� *Text+$ txtMonth��  6]   .a�5K   &   ��  � y�$ Visible=�6C   5L   #   5N      5P      5Q      �� 5R      -   5         ��Name$ btnEditVaccine��5R      $��Edytuj��6-   $��3��6>   $��
15,20,0,20q�6K   
����������	#FFB359E7���	#FF520E79$��16(�6�   $
��Bold"�6�   $
��Left=�6�   $	��135��6�   �� 5S      -   5        $ btnAddVaccine��5S      $��Dodaj��6,   $��3��6<   $��172,20,0,20q�6I   
����������	#FFB359E7���	#FF520E79$��16(�6�   $
��Bold"�6�   $
��Left=�6�   $	��135��6�   5T      &   System.Windows.Controls.DataGrid  5U   
   -   5          Name$ 
dgVaccines��5U      $��15q�6J   ��6'   �� *
PetVaccine+   Columns 5V      0  *System.Windows.Controls.DataGridTextColumn  5W      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *ID+6H     5X      $ Nazwa szczepionki��6%   $ 4* 6Y    6@   �� *Name+6Y     5Y      $! Data ważności (miesiące)��6%   $ 4* 6i    6G   �� *ValidInMonths+6i   4  .System.Windows.Controls.DataGridTemplateColumn  5Z      $ 2* 6)      CellTemplate 5[      �� 5\      .R�5]      �� $ btnEdit��6%   -   5        $��Edytuj��5]   6   ���	#FF520E79
�������6t   5^      5`        5a      $ 2* 6)    5b      �� 5c      .R�5d      �� $ 	btnDelete��6%   -   5        $��Usuń��5d   8   ���	#FF520E79
�������6r   5e      5g      5i      5j      5k      