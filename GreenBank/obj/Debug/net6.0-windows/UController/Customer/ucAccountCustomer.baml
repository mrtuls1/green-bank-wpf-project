   M S B A M L   `   `   `  ????D  @GreenBank, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:GreenBank.UController.CustomerGreenBank.UController.Customer  5      6    0GreenBank.UController.Customer.ucAccountCustomer   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:GreenBank.UController.Customer     5      -   5        .??5	      ?   ? RowDefinitions  5
   
   ?? 5      ?? 5      $??40 ?6   .+?5   
   ?? $??0??6   ._?5      &   System.Windows.Controls.DataGrid  -   5          Name$ grd_accounts??5      $??0q?6r   ???	#FF042263   
IsReadOnly$
 True??6?      	RowHeight$ 30Q?6?      CanUserAddRows$ False??6?      CanUserSortColumns$
 True??6?      HorizontalGridLinesBrush ?	#FF9B9B9B   VerticalGridLinesBrush ?	#FF9B9B9B   AutoGenerateColumns$ false??67     DataGridStyle1#???   6S  ??6-   ?? ??6E   Z? ??6\   Z? 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   
IsReadOnly$

 True??6F      Header$ Id??6X      MinWidth$	 100Q?6d   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   ??  ?? Path$ id?   ElementStyle 5      ?? 5       ?? 
TargetType" ??6$   .?5   "   ??  ?? Property ? ?? ?? Value$
 Left=?6H   ?? 5   "    ? ??$ Center=?6F   ?? 5   "    ?@??Padding$ 5q?6<   5      5        5      $

 True??6H   $ 
Hesap Adı??6Z   $	 100Q?6m    6)   ?? $
 name? 5      ?? 5      " ??6$   .?5   "   ??  ? ??$
 Left=?6H   ?? 5   "    ? ??$ Center=?6F   ?? 5   "    ?@??Padding$ 5q?6<   5       5"        5#      $

 True??6K   $ Tutar??6]   $	 100Q?6l    6)   ?? $ balance? 5$      ?? 5%      " ??6$   .?5&   "   ??  ? ??$
 Left=?6H   ?? 5'   "    ? ??$ Center=?6F   ?? 5(   "    ?@??Padding$ 5q?6<   5)      5+        5,      $

 True??6H   $ Borç??6Z   $	 100Q?6h    6)   ?? $
 debt? 5-      ?? 5.      " ??6$   .?5/   "   ??  ? ??$
 Left=?6H   ?? 50   "    ? ??$ Center=?6F   ?? 51   "    ?@??Padding$ 5q?6<   52      54        55      $

 True??6J   $ Alacak??6\   $	 100Q?6l    6)   ?? $ credit? 56      ?? 57      " ??6$   .?58   "   ??  ? ??$
 Left=?6H   ?? 59   "    ? ??$ Center=?6F   ?? 5:   "    ?@??Padding$ 5q?6<   5;      5=        5>      $

 True??6S   $ Hesap Türü??6e   $	 100Q?6y    6)   ?? $ account_type_id? 5?      ?? 5@      " ??6$   .?5A   "   ??  ? ??$
 Left=?6H   ?? 5B   "    ? ??$ Center=?6F   ?? 5C   "    ?@??Padding$ 5q?6<   5D      5F        5G      $

 True??6P   $ Açılış Tarihi??6b   $	 100Q?6y    6)   ?? $ opening_date? 5H      ?? 5I      " ??6$   .?5J   "   ??  ? ??$
 Left=?6H   ?? 5K   "    ? ??$ Center=?6F   ?? 5L   "    ?@??Padding$ 5q?6<   5M      5O        5P      $

 True??6K   $ Kredi Id??6]   $	 100Q?6o    6)   ?? $ loan_id? 5Q      ?? 5R      " ??6$   .?5S   "   ??  ? ??$
 Left=?6H   ?? 5T   "    ? ??$ Center=?6F   ?? 5U   "    ?@??Padding$ 5q?6<   5V      5X        5Y      $

 True??6M   $ Şube??6_   $	 100Q?6m    6)   ?? $ 	branch_id? 5Z      ?? 5[      " ??6$   .?5\   "   ??  ? ??$
 Left=?6H   ?? 5]   "    ? ??$ Center=?6F   ?? 5^   "    ?@??Padding$ 5q?6<   5_      5a        5b      $

 True??6O   $ 
Açıklama??6a   $	 100Q?6s    6)   ?? $ description? 5c      ?? 5d      " ??6$   .?5e   "   ??  ? ??$
 Left=?6H   ?? 5f   "    ? ??$ Center=?6F   ?? 5g   "    ?@??Padding$ 5q?6<   5h      5j      5l      5m      ?? 5n   
   
???????$??1??6$   5o      5p      5q      