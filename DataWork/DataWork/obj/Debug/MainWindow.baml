   M S B A M L   `   `   `  ����C  ?DataWork, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DataWorkDataWork  5   	       DataWork.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:DataWork     5   	     � Title$  
MainWindow��5   	   $	��400��6   $	��400��6)    � 
ResizeMode$ NoResize=�65   .��5	      �  � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��0��6   $��0��6   $��3��6,   
���   �$��5��6O   	 �� X1$ 0��6c   	 �� X2$	 400��6j   	 �� Y1$	 115��6s   	 �� Y2$	 115��6|   6�   �� 5   
   $��1��6   $��0��6   $��3��6,   
���   �$��5��6O   $ 0��6c   $	 400��6j   $	 100��6s   $	 100��6|   6�   �� 5   
   $��0��6   $��0��6!   $��3��61   $��40(�6E   $��Center=�6S   $��Center=�6p   Введите дату6�   �� 5   
   $��1��6   $��0��6"   $��22(�62   $��Center=�6@   
Число6d   �� 5   
   $��1��6   $��1��6"   $��22(�62   $��Center=�6@   
Месяц6d   �� 5   
   $��1��6   $��2��6"   $��22(�62   $��Center=�6@   Год6b   �� 5   
   -   5         ��Name$ chislo��5      $��1��6#   $��0��60   $��30 40q�6@   	 �� SelectedIndex$	 0��6n   $��22(�6�   ��6O   �� *number+6�   �� 5   
   -   5        $ mesac��5      $��1��6"   $��1��6/   $
��0 40q�6?   $	 0��6k   $��22(�6}   ��6M   �� *month+6�   �� 5   
   -   5        
 ��Name$	
 god��5      $��1��6   $��2��6,   $��20 40q�6<   $��24(�6K    �� TextAlignment$ Center=�6Y   .��6p   19986v   �� 5   
   -   5         ��Name$ vchera��5      $��0��6!   $��2��61   $
��5 40q�6>   $��14(�6L   .��6o   Вчерашняя дата6   �� 5   
   -   5        $ visokosnost��5      $��1��6&   $��2��66   $
��0 40q�6C   $��12(�6Q   .��6y   '%Дней до конца месяца6�   �� 5    
   -   5        $ zavtra��5       $��2��6!   $��2��61   $
��5 40q�6>   $��14(�6L   .��6o   Завтрашняя дата6�   5!      5"      