   M S B A M L   `   `   `  ����B  >WpfApp8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp8WpfApp8  5          WpfApp8.Page1   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp8     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          N� Title$  Page1��5      .��5      � -   5         �Name$ gd��5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� .��6   家庭6   5      �� 5   
   $��1��6   $ 
Horizontal=�6%   .+�5      �� ��6   �� *
FamilyName+�� 5      .��6   	成员:6   5       �� 5"   
   $��2��6   $ 
Horizontal=�6%   .+�5#      �� ��6   �� *Merbers/PersonName+�� 5$      .��6   	爱好：6   5%      �� 5&   
   -   5         ��Name$
 lst1��5'      $��1��5(       �� DisplayMemberPath$ 
FamilyName��5)      $ �� IsSynchronizedWithCurrentItem$
 TrueY�5*      ��5+      �� �� 5,   
   -   5        $
 lst2��5-      $��1��5.      $��1��5/      $ 
PersonName��50      ��51      �� *	Merbers+�� 52   
   -   5        $
 lst3��53      $��1��54      $��2��55      $ LikeName��56      ��57      �� *Merbers/PLike+58      59      