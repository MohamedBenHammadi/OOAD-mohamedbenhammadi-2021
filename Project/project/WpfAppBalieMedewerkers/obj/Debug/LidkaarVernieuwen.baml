   M S B A M L   `   `   `  ����Q  MWpfAppBalieMedewerkers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:WpfAppBalieMedewerkersWpfAppBalieMedewerkers  5      .    (WpfAppBalieMedewerkers.LidkaarVernieuwen   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:WpfAppBalieMedewerkers     5        N� Title$  LidkaarVernieuwen��5	      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      $��80 �6   6,   �� 5      $	��300 �6   6-   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $	��100 �6   6+   �� 5      $	��100 �6   6+   �� 5      $��* �6   6)   .+�5   
   �� $	��0,5q�6   $��1��6   $��1��6*   $��Vervaldatum:��6:   $	��Top=�6Q   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ dprVervalDatum��5      $	��0,9q�61   $��23��6>   $��1��6J   $��1��6W   $	��Top=�6g   $	��120��6�   $��Center=�6�   �� 5   
   -   5         ��Name$ btnPasVervaldatum��5      $��Wijzig vervaldatum��6,   $��2��6I   $��Center=�6Y   $��2��6w   $��Center=�6�   $	��105��6�   6�   �� 5   
   $��Huidige vervaldatum��6   $��1��6.   $��Center=�6>   $��Bottom=�6\   $
��Bold"�6w   $��14(�6�     5"   
   -   5        $ dprVervalDatumNieuw��5"      $	��0,9q�62   $��23��6?   $��2��6K   $��1��6X   $	��Top=�6h   $	��120��6�   $��Center=�6�   �� 5&   
   $��Nieuwe vervaldatum��6   $��1��6-   $��1��6=   $��Center=�6J   $��Bottom=�6h   $
��Bold"�6�   $��14(�6�   5)      5*      