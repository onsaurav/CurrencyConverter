   M S B A M L   `   `   `  ���� L  HCurrencyConverter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CurrencyConverterCurrencyConverter  "    CurrencyConverter.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:CurrencyConverter     -     � Title$  Log In��$	��400��$	��650�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � AllowsTransparency . 
������� � WindowStyle$
 None=�.���� $��1q�
�������._��  � ColumnDefinitions �� $	��200 ��� $
��435* � � RowDefinitions �� $��45 ��� $
��310* ��� $��45 �.+��� $��0��$��0��$��2��$	��Top=�$
��Left=�$��20(�$��Convert currenct in word��$��3,0,0,0q��� -    ��Name$ imgClose��$��0��$��2��$��15��$��15��$	��Top=�$��Right=�$��images/delete.png�� � ToolTip$
 Exit��$��0,5,5,0q��� $��1��$��0��$��0 0 1 0q�
�������$��	0,15,0,20q�._��� $��5,0,5,5q�.+��� -   	 ��Name$	 
btnConvert��$��5,5,0,0q����#FEFEFE.��]� $
��Left=�$	��175��.+��� $��20��$��20��$
��Left=�$ ��images/currency_dollar.png��$
��Fill=�$��0,2,0,0q�$	��Top=��� $��Convert currency to word���� -   $	 btnInformation��$��5,5,0,0q����#FEFEFE.��]� $
��Left=�$	��175��.+��� $��20��$��20��$
��Left=�$��images/information.png���� $��Information���� -   $��stkMain��$��1��$��1��$��	5,10,0,20q��� $��2��$��2�����#E0E0E0.+��� -   $��btnClose��$��Close��$��Right=�$��Center=�$��75��$��25��$��0,10,5,0q�