   M S B A M L   `   `   `  ����C  ?Wpftimer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpftimerWpftimer  5   	       Wpftimer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Wpftimer     5   	     � Title$  Timer��5   	   $	��400��6   $	��600��6$   .��5	      � -   5         �Name$ GrdTimer��5	      $��0,0,-0.4,0.4q�6    � ColumnDefinitions 5
   
   �� 5      $
��367* �6   �� 5      $
��227* �6   .+�5   
   �� -   5         ��Name$ btnStart��5      $��START��6#   $
��Left=�63   $��
129,27,0,0q�6N   $	��Top=�6b   $��94��6z   $��81��6�   6�   �� 5   
   -   5        $ btnStop��5      $
��STOP��6"   {�.  $
��Left=�6C   $��129,145,0,0q�6^   $	��Top=�6s   $��94��6�   $��85��6�   6�   �� 5   
   -   5        $ btnReset��5      $��RESET��6#   {�.  $
��Left=�6E   $��129,265,0,0q�6`   $	��Top=�6u   $��94��6�   $��81��6�   6�   �� 5   
   -   5         ��Name$ lblTijd��5      $�� ��6!   $
��Left=�6,   $��280,135,0,0q�6G   $	��Top=�6\   $	��130��6t   $	��285��6�   $��24(�6�   $��2��6�   5      5      