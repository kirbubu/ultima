   M S B A M L   `   `   `  ����P  LUltima 5 Cheat Engine, Version=0.0.0.1, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Ultima_5_Cheat_Engine.ViewUltima_5_Cheat_Engine.View  5      Q-clr-namespace:Ultima_5_Cheat_Engine.ConverterUltima_5_Cheat_Engine.Converter  5	      )    #Ultima_5_Cheat_Engine.View.MainView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:Ultima_5_Cheat_Engine.View     5      f bGalaSoft.MvvmLight.Platform, Version=5.3.0.19032, Culture=neutral, PublicKeyToken=5f873c45e98af8a1.Command http://www.galasoft.ch/mvvmlight  5      X TXceed.Wpf.Toolkit, Version=3.4.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      =	Converter-clr-namespace:Ultima_5_Cheat_Engine.Converter  5	        � DataContext  5      ��    Locator �� Source# [   �� Path$ MainViewModel� � 	Resources 5      7   1Ultima_5_Cheat_Engine.Converter.GameDataConverter  GameDataConverter��%   &	         5   
   6&   5      .��5      � -   5         �Name$ 
LayoutRoot��5      .+�5   
   �� $��Players��6   $��368,10,136,-10q�6"   �� 5   
   -   5         ��Name$ 	PlayerBox��5      $	��155��6%   $	��325��61   $	��Top=�6>   $
��Left=�6V   $��
368,56,0,0q�6�   ��5      �� *
Characters+5      �� 5   
   -   5         ��Name$ SelectButton��5      $��Select Player��6'   $��30��6?   $��541,56,173,564q�5   W   ��5   K   �� *MouseDoubleClick+{�6p   �� *SelectButtonOn+��5      ��  �� ElementName$ 	PlayerBox��$ SelectedItem�6W   �� 5   
   -   5        $ 
SaveButton��5      $��Save Player��6%   $��30��6;   $��541,99,173,521q�5      ��5   G   �� *SavePlayerCommand+{�6m   �� *SaveButtonOn+��5      `� 5       `� 	Converter# [ 6   .1�5      �� $ Strength��6   $
 Text�65   �� 5      $ 	Dexterity��6   $
 Text�66   �� 5       $ Intelligence��6   $
 Text�69   �� 5!      $ 	HitPoints��6   $
 Text�66   �� 5"      $ MaxHP��6   $
 Text�62   �� 5#      $ 
Experience��6   $
 Text�67   �� 5$      $
 Gold��6   $
 Text�61   5%      5(      �� 5)   
   -   5        $��FileBox��5)      $	��250��6!   $��30��6-   $	��Top=�69   {�.  $��10,56,540,0q�6}   ��6Q   �� *
FileName+6}   �� 5*   
   -   5        $��
FileButton��5*      $��Get File��6#   $��70��66   $��30��6A   $��10,10,720,610q�6s   ��6M   �� *FileButtonCommand+6s   �� 5+   
   $��Find SAVED.GAME��6   $��101,10,576,610q�6*   � 5-   
   -   5        $��Grid2��5-      $��
10,129,0,0q�6   	 � ColumnDefinitions	 5.      �� 5/      $	��100 �6#   �� 50      $	��100 �6#   �� 51      $	��100 �6#   �� 52      $	��100 �6#   �� 53      $	��100 �6#   
 � RowDefinitions
 55      �� 56      $��75 �6    �� 57      $��75 �6    �� 58      $��75 �6    �� 59      $��75 �6    �� 5:      $��75 �6    .+�5<      �� $��	HitPoints��6   $��0��6(   $��0��65   $
��Left=�6E   %  Xceed.Wpf.Toolkit.IntegerUpDown  5=      -   5        $��	HitPoints��5=   !   $��75��63   $��25��6>   $��0��6J   $��0��6W   $
��Left=�6g   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Maximum$	 999X�5>   <      Minimum$ 1X�6J   ,  &Xceed.Wpf.Toolkit.Primitives.InputBase   Text 6!   �� *	HitPoints+6J   �� 5@      $��Hit Point Max��6   $��1��6,   $��0��69   $
��Left=�6I     5A      -	   5        $��MaxHP��5A   "   $��75��60   $��25��6;   $��1��6G   $��0��6T   $
��Left=�6d   $	 999X�5B   ?   $ 1X�6M    6!   �� *MaxHitPoints+6M   �� 5D      $��Strength��6   $��2��6'   $��0��64   $
��Left=�6D     5E      -
   5        $��Strength��5E   !   $��75��62   $��25��6=   $��2��6I   $��0��6V   $
��Left=�6f   $	 100X�5F   ;   $ 1X�6I    6!   �� *
Strength+6I   �� 5H      $��	Dexterity��6   $��3��6)   $��0��66   $
��Left=�6F     5I      -   5        $��	Dexterity��5I   !   $��75��63   $��25��6>   $��3��6J   $��0��6W   $
��Left=�6g   $	 100X�5J   <   $ 1X�6J    6!   �� *	Dexterity+6J   �� 5L      $��Intelligence��6   $��4��6+   $��0��68   $
��Left=�6H     5M      -   5        $��Intelligence��5M   !   $��75��66   $��25��6A   $��4��6M   $��0��6Z   $
��Left=�6j   $	 100X�5N   ?   $ 1X�6M    6!   �� *Intelligence+6M   �� 5P      $��
Experience��6   $��0��6)   $��1��66   $
��Left=�6F     5Q      -   5        $��
Experience��5Q   !   $��75��64   $��25��6?   $��0��6K   $��1��6X   $
��Left=�6h   $
 9999X�5R   =   $ 0X�6L    6!   �� *
Experience+6L   �� 5T      $��
Party Gold��6   $��1��6)   $��1��66   $
��Left=�6F     5U      -   5        $
��Gold��5U   !   $��75��6.   $��25��69   $��1��6E   $��1��6R   $
��Left=�6b   $
 9999X�5V   7   $ 0X�6F    6!   �� *Gold+6F   �� 5W      $��	100 Keys?��6   $��2��6(   $��1��65   $
��Left=�6F   �� 5X      -   5        $��	KeyButton��5X      $��2��6&   $��1��63   $��Change��6C   $��75��6T   $��25��6_   $
��Left=�6k   ��5Y      �� *
KeyCommand+�� 5[      $��100 Skull Keys?��6   $��3��6.   $��1��6;   $
��Left=�6L   �� 5\      -   5        $��SkullKeyButton��5\      $��3��6+   $��1��68   $��Change��6H   $��75��6Y   $��25��6d   $
��Left=�6p   ��5]      �� *SkullKeyCommand+�� 5_      $��	100 Gems?��6   $��4��6(   $��1��65   $
��Left=�6F   �� 5`      -   5        $��	GemButton��5`      $��4��6&   $��1��63   $��Change��6C   $��75��6T   $��25��6_   $
��Left=�6k   ��5a      �� *
GemCommand+�� 5c      $��Black Badge?��6   $��0��6+   $��2��68   $
��Left=�6I   �� 5d      -   5        $��BlackBadgeButton��5d      $��0��6-   $��2��6:   $��Change��6J   $��75��6[   $��25��6f   $
��Left=�6r   ��5e      �� *BlackBadgeCommand+�� 5g      $��2 Magic Carpets?��6   $��1��6/   $��2��6<   $
��Left=�6M   �� 5h      -   5        $��MagicCarpetButton��5h      $��1��6.   $��2��6;   $��Change��6K   $��75��6\   $��25��6g   $
��Left=�6s   ��5i      �� *MagicCarpetCommand+�� 5k      $��10 Magic Axes?��6   $��2��6-   $��2��6:   $
��Left=�6K   �� 5l      -   5        $��MagicAxeButton��5l      $��2��6+   $��2��68   $��Change��6H   $��75��6Y   $��25��6d   $
��Left=�6p   ��5m      �� *MagicAxeCommand+5n      5p      5q      