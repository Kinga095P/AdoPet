   M S B A M L   `   `   `  ����A  =AdoPet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AdoPetAdoPet  5   	       AdoPet.AdoptionDetails   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:AdoPet     5   	     � Title$  AdoptionDetails��5   	   $	��450��6!   $	��800��6.   .��5	      � ��5
   
   �� 5       �� ImageSource$ /Pic/bluegradient.jpg��6    �� Opacity$	 0.6Q�6=    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��3* �6   �� 5      $��* �6   .+�5   
   �� $$��Szczegóły dotyczące adopcji��6   $��0��66   $��0��6C   $��Center=�6S   $��Center=�6w   $��16(�6�   
�������$
��Bold"�6�   �� 5   
   -   5         ��Name$ 
txbPetName��5      $��0��6(   $��1��65   $��Center=�6E   $��Center=�6b   $��16(�6}   
�������$
��Bold"�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	dgDetails��5      $��1��6&   $��2��63   $
��60,0q�6G      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Data adopcji��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6\   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6;   �� *DateAdoption+6\     5      $ Imię��6%   $	 * 6L   
 63   �� *Name+6L     5      $ Nazwisko��6%   $	 * 6T   
 67   �� *
Surrname+6T     5      $ Adres��6%   $	 * 6P   
 64   �� *	Address+6P     5      $ Telefon��6%   $	 * 6V   
 66   �� *PhoneNumber+6V     5      $ Email��6%   $	 * 6N   
 64   �� *Email+6N   5!      �� 5"   
   -   5        $��Zamknij szczegóły��5"      $��2��6-   $��0��6:   $��2��6J   $��200,15,200,15q�6^   ���	#FF520E79
�������$��16(�6�   $
��Bold"�6�   5#      5$      