   M S B A M L   `   `   `  ����M  IWpfCarConfigurator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfCarConfiguratorWpfCarConfigurator  5   	   #    WpfCarConfigurator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WpfCarConfigurator     5   	     � Title$  WpfCarConfigurator��5   	   $	��450��6$   $	��800��61   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��266 �6   �� 5      $	��266 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $	��150 �6   �� 5      $	��150 �6   �� 5      $��* �6   .+�5   
   �� $��1��6    �� Orientation$ Vertical=�6%   .+�5      �� -   5         ��Name$ cmbAuto��5      $��Center=�6(   $	��Top=�6E   $	��229��6]   $��1��6j   $��0,10,0,0q�6z   .@�5      �� -   5         ��Name$ cmbV8��5      $"�� Continental V8 (85000 euro)��6.   6X   �� 5      -   5        $ cmbConvertible��5      $��Convertible (72000 euro)��67   6]   �� 5      -   5        $ cmbMuslsanne��5      $��mulsanne (653000euro)��65   6W   5      	� 5      -   5         	�Name$ rdbBlauw��5       d� 	IsChecked$ FalseY�6,   $��blauw��6?   $��1��6O   $
��Left=�6_   $��	12,60,0,0q�6z   6�   	� 5      -   5        $ rdbGroen��5      $ FalseY�6,   $��groen (+250 euro)��6?   $��1��6[   $
��Left=�6k   $��12,5,0,0q�6�   6�   	� 5      -   5        $ rdbRood��5      $ FalseY�6+   $��rood (+700 euro)��6>   $��1��6Y   $
��Left=�6i   $��12,0,0,0q�6�   6�   5      �� 5!   
   $��1��6   $��1��6%   $ Vertical=�62   .+�5"      �� -   5         ��Name$ chkdBose��5"      $ FalseY�6)   $&�� Bose audio speakers (+1250 euro)��6;   $��1��6f   $��	12,45,0,0q�6w   $��1��6�   6�   �� 5#      -	   5        $ 
chkdMatjes��5#      $ FalseY�6+   $��Delux matjess (+450 euro)��6>   $��1��6b   $��	12,10,0,0q�6s   $��1��6�   6�   �� 5$      -
   5        $ 
chkdVelgen��5$      $ FalseY�6+   $"��Aluminium velgen (+300 euro)��6?   $��1��6f   $��	12,10,0,0q�6v   $��1��6�   6�   5%      �� 5&   
   -   5        	 ��Name$	 imgAuto��5&      $��2��6"   $	��111��63   $��
5,10,10,20q�6@   $	��217��6U   �� 5'   
   $��2��6   $��1��6%   $ Vertical=�62   .+�5)      �� -   5        $	 imgAudio��5)   #   
 J� Opacity$	
 0.3Q�6   $��img/opties_audio.jpg��65   $
��Left=�6T   $��43��6o   $��0,0,0,10q�6{   $��95��6�   �� 5*      -   5        $	 	imgMatjes��5*   "   $	
 0.3Q�6   $��img/opties_matjes.jpg��65   $
��Left=�6U   $��43��6p   $��0,0,0,10q�6|   $��95��6�   �� 5+      -   5        $	 	imgVelgen��5+   "   $	
 0.3Q�6   $��img/opties_velgen.jpg��65   $
��Left=�6U   $��43��6p   $��0,0,0,0q�6|   $��95��6�   5-      �� 5/   
   -   5         ��Name$ 	lblTotaal��5/      $�� ��6#   $��1��6.   $
��Left=�6>   $��	25,50,0,0q�6Y   $��2��6l   $	��Top=�6y   $��14(�6�   $
��Bold"�6�   �� 51   
   $��MODEl EN KLEUR��6   $��Center=�6)   $	��Top=�6F   $
��Bold"�6^   $��14(�6p   $��0,40,0,0q�6~   �� 52   
   $��
ACCESOIRES��6   $��Center=�6%   $��1��6C   $��Center=�6P   $
��Bold"�6k   $��14(�6}   �� 53   
   $��TOTAALPRIJS��6   $��Center=�6&   $	��Top=�6C   $
��Bold"�6\   $��14(�6n   $��0,50,0,0q�6|   $��2��6�   $	��108��6�   55      56      