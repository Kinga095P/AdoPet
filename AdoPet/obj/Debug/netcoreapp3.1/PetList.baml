   M S B A M L   `   `   `  ����A  =AdoPet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AdoPetAdoPet  5   	       AdoPet.PetList   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:AdoPet     5   	     � Title$  PetList��5   	   $	��450��6   $	��800��6&    � 	Resources 5	       �� 
TargetType �� 	Resources �� Property �� Value��%H  '��       '�� �     �� 5
   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��CornerRadius$ 8��65   5      5      5      �� 5   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��CornerRadius$ 6��65   5      5      5      5      .��5      � ��5   
   �� 5       �� ImageSource$ /Pic/bluegradient.jpg��6    �� Opacity$	 0.6Q�6=    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��4* �6   �� 5       $��* �6   	 � ColumnDefinitions	 5"   
   �� 5#      $��* �6   .+�5%   
   &   System.Windows.Controls.DataGrid  -   5        
  Name$
 dataGrid��5%      $��20q�6D   $��10q�6P      CanUserAddRows$ False��6]   $��1��6t   ��6%   �� *Animal+   Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *ID+  5(      $	 Typ��6%    62   �� *Type+  5)      $ Imię��6%    63   �� *Name+  5*      $
 Wiek��6%    63   �� *Age+  5+      $ Płeć��6%    63   �� *Sex+  5,      $
 Waga��6%    63   �� *Weight+  5-      $ Aktywność��6%    68   �� *
Activity+  5.      $ 
Wielkość��6%    67   �� *Size+4  .System.Windows.Controls.DataGridCheckBoxColumn  5/         
IsReadOnly$
 True��6)   $ Szczepienia��6;    6P   �� *
Vaccines+  50      $
 True��6)   $ Sterylizacja��6;    6Q   �� *Sterylization+  51      $
 True��6)   $ PrzyjaznyDzieciom��6;    6V   �� *ChildFriendly+  52      $
 True��6)   $ Szkolony��6;    6M   �� *	Trained+  53      $
 True��6)   $ AkceptujeKoty��6;    6R   �� *
AcceptCats+  54      $
 True��6)   $ AkceptujePsy��6;    6Q   �� *
AcceptDogs+4  .System.Windows.Controls.DataGridTemplateColumn  55         CellTemplate 56      �� 57      .R�58      �� -   5        $��Dodaj szczepienie��58   %   ���	#FF520E79
�������6k   59      5;        5<       5=      �� 5>      .R�5?      �� -   5        $��Pokaż szczegóły��5?   %   ���	#FF520E79
�������6i   5@      5B        5C       5D      �� 5E      .R�5F      ��  ��Name$ btnEdit��6%   -   5        $��Edytuj��5F   6   ���	#FF520E79
�������6q   5G      5I        5J       5K      �� 5L      .R�5M      �� $ 	btnDelete��6%   -   5        $��Usuń��5M   8   ���	#FF520E79
�������6q   5N      5P      5R      �� 5S   
   -   5        $ btnAdd��5S      $��Dodaj zwierzę do bazy��6!   $��558,15,20,15q�6A   ���	#FFF7F7F7$��16(�6o   $
��Bold"�6}   $��2��6�   ���	#FF520E796�   �� 5T   
   -   5        $ btnPrint��5T      $��Drukuj listę zwierząt��6#   $��0��6C   $
��Left=�6Q   $��
20,20,0,20q�6l   $	��134��6�   ���	#FF520E79���	#FF520E79
�������6�   � 5U   
   $��0��6   $��0��6   .+�5V      �� -   5         ��Name$ 	txtSearch��5V      $��0��6)   $��14(�66   $��511,15,15,15q�6D   ���	#FFF6F6F6$��Center=�6�   �� 5W       J� IsHitTestVisible$ False��6   $��Wyszukaj zwierzę��61   $��Center=�6I   $
��Left=�6d   $��	533,0,0,0q�6   
���������5X      �� 5Y      " ��6   .�5Z      ��  � y�$ 	Collapsed=�67    �� Triggers 5[      �� 5\       �� Binding 6*   �� *Text+ �� ElementName$ 	txtSearch�� �� Value  6Z   .a�5]   "   ��  � y�$ Visible=�6?   5^      5`      5b      5c      5d      5e      