   M S B A M L   `   `   `  ����Q  MWpfAppBalieMedewerkers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WpfAppBalieMedewerkersWpfAppBalieMedewerkers  5   	   +    %WpfAppBalieMedewerkers.OntelingWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:WpfAppBalieMedewerkers     5   	     N� Title$  OntelingWindow��5   	   $	��500��6    $
��1000��6-   .��5	      � 
������� � ColumnDefinitions 5
   
   �� 5      $	��105 �6   6-   �� 5      $	��140 �6   6-   �� 5      $	��350 �6   6-   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��70 �6   6*   �� 5      $	��350 �6   6,   �� 5      $��* �6   6*   .+�5   
   �� $��1��6   $��1��6%   $
��Left=�62   $	��120��6M   .+�5      �� -   5         ��Name$ lblId��5      $�� ��6#   $��40��6/   $
��10,0q�6:   $
��Left=�6H   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ dprDatumUit��5      $
��Left=�6/     5      -   5        $ 
dprDatumIN��5      $
��Left=�6.     5      -   5        $ dprWerkelijkeDatum��5      $
��Left=�66   �� 5      -   5        $ lblBoeteBedrag��5      $��40��6-   $
��10,0q�68   $�� ��6F   $
��Left=�6Q     5      -   5        $ dprBoeteVoldaan��5      $
��Left=�63   �� 5      -   5        $ lblExemplaarId��5      $�� ��6,   $��40��68   $
��10,8q�6C   $
��Left=�6Q   �� 5      -   5        $ lblLidnummer��5      $��40��6*   $��10,0,0,0q�65   $�� ��6G   $
��Left=�6R   5       �� 5$   
   $��0��6   $��1��6%   $��Center=�62   $��90��6O   .+�5%      �� $	��id:��6   $
��Left=�6"   �� 5&      $��
Datum uit:��6   $
��Left=�6)   �� 5'      $��Uiterste datum in:��6   $
��Left=�61   �� 5(      $��Werkelijke datum in:��6   $
��Left=�63   $��10(�6N   �� 5)      $��Boete Bedrag:��6   $
��Left=�6,   �� 5*      $��Boete voldaan:��6   $
��Left=�6-   �� 5+      $��exemplaar_id:��6   $
��Left=�6,   �� 5,      $��Lid_nummer:��6   $
��Left=�6*   5-      �� 52   
   $��3��6   $��40��6%   $��Center=�61    �� Orientation$ 
Horizontal=�6N   $��Center=�6g   .+�53      �� -	   5         ��Name$ btnTerugbrengen��53      $��Onteling terug brengen��6.   $��	10,10,0,0q�6O   6b   54      �� 57   
   $��1��6   $��2��6$   $
��Auto=�64   $	��Top=�6W   $	��350��6o   .��58      �� -
   5         ��Name$ lbxDataOntleningen��58      6m   59      �� 5:   
   $��Lijst van Onteleningen��6   $��2��61   $��Center=�6A   $��Center=�6_   $��20(�6z   $
��Bold"�6�   �� 5;   
   $��Onteling info��6   $��Center=�6(   $��Center=�6F   $��2��6a   $	��138��6u   $��20(�6�   $
��Bold"�6�   �� 5=   
   -   5         ��Name$ txtZoek��5=      $��3��6#   $��Center=�63   $��23��6P   $��	10,60,0,0q�6\   $��1��6o   	 �� TextWrapping$
	 Wrap=�6|   $�� ��6�   $	��Top=�6�   $	��120��6�   �� 5>   
   -   5        $ btnZoek��5>      $
��Zoek��6"   $��3��61   $��Right=�6A   $��1��6]   $	��Top=�6j   $��	0,60,60,0q�6�   $��75��6�   6�   �� 5?   
   $��Zoek via Lidnummer��6   $��3��6-   $��Center=�6=   $��20q�6Z   $��1��6g   $	��Top=�6t   $
��Bold"�6�   �� 5@   
   -   5        $ lblEror��5@      $�� ��6!   $��3��6,   $
��Left=�6<   $��86.8,115,0,0q�6W   $��1��6m   $	��Top=�6z   5A      5B      