   M S B A M L   `   `   `  ����A  =AdoPet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AdoPetAdoPet  5   	       AdoPet.AdoptionForm   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:AdoPet     5   	     � Title$  AdoptionForm��5   	   $	��450��6   $	��800��6+    � 	Resources 5	       �� 
TargetType �� 	Resources �� Property �� Value��%H  '��       '�� �     �� 5
   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��CornerRadius$ 8��65   5      5      5      �� 5   
   " ��6    5      ���� 5      '��       " ��6   .�5      ��  �@��CornerRadius$ 6��65   5      5      5      5      .��5      � ��5   
   �� 5       �� ImageSource$ /Pic/bluegradient.jpg��6    �� Opacity$	 0.6Q�6=    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5       $��* �6   �� 5!      $��* �6   	 � RowDefinitions	 5#   
   �� 5$      $��* �6   �� 5%      $��* �6   �� 5&      $��* �6   �� 5'      $��* �6   �� 5(      $��* �6   �� 5)      $��* �6   �� 5*      $��* �6   .+�5,   
   �� $��Formularz adopcyjny��6   $��1��6.   $��0��6>   $��2��6K   $��20(�6_   $��Center=�6m   $��Center=�6�   ���	#FF520E79$
��Bold"�6�   �� 5-   
   $��Data adopcji��6   $��0��6'   $��1��67   $��16(�6D   $��Center=�6R   $��Center=�6o   ���	#FFFDFDFD$
��Bold"�6�   (  "System.Windows.Controls.DatePicker  5.   
   -   5        
  Name$
 dpAdoptDate��5.      $��1��6*   $��1��67   $��15q�6G   �� 5/   
   $��Zwierzak do adopcji*��6   $��2��6/   $��1��6?   $��16(�6L   $��Center=�6Z   $��Center=�6w   $
��Bold"�6�   ���	#FFFDFDFD6�   �� 50   
   -   5         ��Name$ cbPetToAdoption��50       �� 
IsEditable$
 True��6,   $��3��6>   $��1��6N   $��15q�6[   $��16(�6g   $��Center=�6u   �� 51   
   $��Imię*��6   $��0��6    $��2��60   $��16(�6=   $��Center=�6K   $��Center=�6h   $
��Bold"�6�   ���	#FFFDFDFD6�   �� 52   
   -   5         ��Name$ txtName��52      $��1��6#   $��2��63   $��15q�6@   $��16(�6L   $��Center=�6Z   �� 53   
   $��	Nazwisko*��6   $��0��6$   $��3��64   $��16(�6A   $��Center=�6O   $��Center=�6l   $
��Bold"�6�   ���	#FFFDFDFD6�   �� 54   
   -   5        $ 
txtSurname��54      $��1��6&   $��3��66   $��15q�6C   $��16(�6O   $��Center=�6]   �� 55   
   $��Adres zamieszkania*��6   $��0��6.   $��4��6>   $��16(�6K   $��Center=�6Y   $��Center=�6v   $
��Bold"�6�   ���	#FFFDFDFD6�   �� 56   
   -   5        $ 
txtAddress��56      $��1��6&   $��4��66   $��2��6C   $��15q�6W   $��16(�6c   $��Center=�6q   �� 57   
   $��Numer telefonu*��6   $��0��6*   $��5��6:   $��16(�6G   $��Center=�6U   $��Center=�6r   ���	#FFFDFDFD6�   �� 58   
   -   5        $ txtPhoneNumber��58      $��1��6*   $��5��6:   $��15q�6G   $��16(�6S   $��Center=�6a   �� 59   
   $��E-mail*��6   $��0��6"   $��6��62   $��16(�6?   $��Center=�6M   $��Center=�6j   $
��Bold"�6�   ���	#FFFDFDFD6�   �� 5:   
   -   5        $ txtEmail��5:      $��1��6$   $��6��64   $��15q�6A   $��16(�6M   $��Center=�6[   �� 5;   
   -   5         ��Name$ btnAdoption��5;      $��3��6&   $��6��66   $��Adoptuj��6C   $��10q�6U   
����������	#FFB359E7���	#FF520E79$��16(�6�   6�   5<      5=      