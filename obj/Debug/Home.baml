   M S B A M L   `   `   `  ����L  HCurrencyConverter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CurrencyConverterCurrencyConverter  5   	       CurrencyConverter.Home   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:CurrencyConverter     5   	   -   5          � Title$  Log In��5   	   $	��400��6   $	��650��6%    � 
ResizeMode$ NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � AllowsTransparency . 
������� � WindowStyle$
 None=�5   	   .��5      �� $��1q�6   
�������._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5      $
��435* �6#    � RowDefinitions 5      �� 5      $��45 �6    �� 5      $
��310* �6    �� 5      $��45 �6    .+�5      �� $��0��6   $��0��6!   $��2��61   $	��Top=�5      $
��Left=�6,   $��20(�5      $��Convert currenct in word��6"   $��3,0,0,0q�5      �� 5      -   5         ��Name$ imgClose��5      $��0��6&   $��2��63   $��15��6C   $��15��6O   $	��Top=�6Z   $��Right=�5       $��images/delete.png��6,    � ToolTip$
 Exit��6G   $��0,5,5,0q�5!      6!   �� 5#      $��1��6   $��0��6"   $��0 0 1 0q�62   
�������$��	0,15,0,20q�6_   ._�5$      �� $��5,0,5,5q�6   .+�5%      �� -   5        	 ��Name$	 
btnConvert��5%      $��5,5,0,0q�61   ���#FEFEFE.��5&      ]� $
��Left=�6$   $	��175��6?   .+�5'      �� $��20��6$   $��20��60   $
��Left=�6;   $ ��images/currency_dollar.png��6V   $
��Fill=�6z   $��0,2,0,0q�6�   $	��Top=�6�   �� 5(      $��Convert currency to word��6$   5)      5*      �� 5,      -   5        $	 btnInformation��5,      $��5,5,0,0q�65   ���#FEFEFE.��5-      ]� $
��Left=�6$   $	��175��6?   .+�5.      �� $��20��6$   $��20��60   $
��Left=�6;   $��images/information.png��6V   �� 5/      $��Information��6$   50      51      52      53      �� 55      -   5        $��stkMain��55   6   $��1��6   $��1��6&   $��	5,10,0,20q�6E   �� 57      $��2��6   $��2��6&   ���#E0E0E0.+�58      �� -   5        $��btnClose��58      $��Close��6)   $��Right=�59      $��Center=�65   $��75��5:      $��25��6$   $��0,10,5,0q�60   5;      5=      5>      5?      