   M S B A M L   `   `   `  ����Q  MWpfAppBalieMedewerkers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WpfAppBalieMedewerkersWpfAppBalieMedewerkers  5      +    %WpfAppBalieMedewerkers.PageReservatie   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:WpfAppBalieMedewerkers     5        N� Title$  PageReservatie��5	      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $	��115 �6   6-   �� 5      $	��150 �6   6-   �� 5      $	��550 �6   6-   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��70 �6   6*   �� 5      $	��350 �6   6,   �� 5      $��* �6   6*   .+�5   
   �� $��1��6   $��1��6%   $
��Left=�62   $	��120��6M   $��2��6Y   .+�5      �� -   5         ��Name$ lblId��5      $�� ��6#   $
��Left=�6.   $��30��6I   $	��5,0q�6T   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ dprDatumReservatie��5      $
��Left=�66   �� 5      -   5        $ lblExemplaar_id��5      $�� ��6-   $��30��68   $	��5,5q�6C   $
��Left=�6P   �� 5      -   5        $ lblLid_lidnummer��5      $�� ��6.   $��30��69   $	��5,0q�6D   $
��Left=�6Q   5      �� 5#   
   $��0��6   $��1��6%   $��Center=�62   $��90��6O   .+�5$      �� $	��id:��6   $
��Left=�6"   �� 5%      $��datum reservatie:��6   $
��Left=�60   �� 5&      $��exemplaar_id:��6   $
��Left=�6,   �� 5'      $��
lidnummer:��6   $
��Left=�6)   5)      �� 5+   
   $��3��6   $��40��6%   $��Center=�61    �� Orientation$ 
Horizontal=�6N   $��Center=�6g   .+�5,      �� -   5         ��Name$ btnVerwijderen��5,      $��Verwijder Reservatie��6-   $��	10,10,0,0q�6L   6_   5-      �� 5/   
   $��1��6   $��2��6$   $
��Auto=�64   $	��Top=�6W   $	��350��6o   .��50      �� -   5         ��Name$ lbxDataReservatie��50      6j   51      �� 52   
   $��Lijst van Reservaties��6   $��2��60   $��Center=�6@   $��Center=�6^   $��20(�6y   $
��Bold"�6�   �� 53   
   $��Reservatie Info��6   $��Center=�6*   $��Center=�6H   $��2��6c   $	��160��6w   $��20(�6�   $
��Bold"�6�   �� 54   
   -   5         ��Name$ txtZoek��54      $��3��6#   $��Center=�63   $��23��6P   $��	10,60,0,0q�6\   $��1��6o   	 �� TextWrapping$
	 Wrap=�6|   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 55   
   -   5        $ btnZoek��55      $
��Zoek��6"   $��3��61   $��Right=�6A   $��1��6]   $	��Top=�6j   $��	0,60,40,0q�6�   $��75��6�   6�   �� 56   
   $��Zoek via Lidnummer��6   $��3��6-   $��Center=�6=   $��20q�6Z   $��1��6g   $	��Top=�6t   $
��Bold"�6�   �� 57   
   -	   5        $ lblError��57      $�� ��6"   $��3��6-   $��Center=�6=   $	��100q�6Z   $��1��6h   $	��Top=�6u   58      59      