   M S B A M L   `   `   `  ����A  =AdoPet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AdoPetAdoPet  5   	       AdoPet.Calculator   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:AdoPet     5   	     � Title$  
Calculator��5   	   $	��450��6   $	��800��6)    � 	Resources 5	       �� 
TargetType �� 	Resources �� Property �� Value��%H  '��       '�� �     �� 5
   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��CornerRadius$ 8��65   5      5      5      �� 5   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��CornerRadius$ 6��65   5      5      5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5       $��* �6   �� 5!      $��* �6   �� 5"      $��* �6   �� 5#      $��* �6   �� 5$      $��* �6   �� 5%      $��* �6   �� 5&      $��* �6   .+�5(   
   �� $��2��6   $��0��6"   $��0��62   $��2��6?   ��6S   Z� ��6i   Z� .��5)      �� $��Pic/dog.png��6    J� OpacityMask
 �   �$��5q�6=   5*      �� 5+   
   $��1��6   $��2��6"   $��0��63   ��6@   Z� ��6V   Z� �� 5,   
   $
��Pies��6   $��2��6   $��0��6,   $��2��6<   $��Center=�6P   $	��Top=�6m   $��25(�6�   �� 5-   
   $��Waga zwierzaka��6   $��2��6)   $��0��69   $��25(�6F   $��Center=�6T   ���	#FFB359E7$
��Bold"�6�   �� 5.   
   -   5        	 ��Name$	 	txbWeight��5.      $��1��6%   $��2��62   $��Center=�6B   $��Center=�6f   $��20(�6�   ���	#FFB359E7$	��219��6�   ���	#FFB359E7$��15q�6�   �� 5/   
   $
��Wiek��6   $��0��6!   $��3��61   $��2��6>   $��2��6R   $��10q�6c   ���	#FFB359E7
���   �.��50      �� .+�51      	� -   5        
 	�Name$
 rbJunior��51      $��5q�60   .��6;   Junior6C   	� 52      -   5        $
 rbAdult��52      $��5q�6/   .��6:   
Dorosły6C   	� 53      -   5        $
 rbSenior��53      $��5q�60   .��6;   Senior6C   54      55      �� 56   
   $��Aktywność��6   $��2��6&   $��3��66   $��2��6C   $��2��6W   $��10q�6h   ���	#FFB359E7.��57      �� .+�58      	� $��5q�6   .��6)   Bardzo aktywny69   	� 59      $��5q�6   .��6)   	Aktywny62   	� 5:      $��5q�6   .��6)   Mało aktywny67   5;      5<      �� 5=   
   -   5        $��2��5=      $��5��6!   $��2��6.   $��10q�6?   ��6K   Z� ��6b   Z� .��5>      �� $��Pic/calculator.png��6   5?      �� 5@   
   $#��Dzienne zapotrzebowanie karmy��6   $��5��68   $��0��6E   $��2��6U   $��Center=�6i   $��Center=�6�   $��20(�6�   ���	#FFB359E7$
��Bold"�6�   �� 5A   
   -   5         ��Name$ 	txbResult��5A   F   $��6��6   $��0��6!   $��2��61   $��20(�6Y   $��Center=�6g   $��Center=�6�   $��15q�6�   $	��200��6�   ���	#FFB359E7$
��Bold"�6�   5B      5C      