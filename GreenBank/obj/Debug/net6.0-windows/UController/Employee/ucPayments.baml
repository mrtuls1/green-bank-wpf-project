   M S B A M L   `   `   `  ????D  @GreenBank, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:GreenBank.UControllerGreenBank.UController  5      &     GreenBank.UController.ucPayments   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:GreenBank.UController     5      -   5        .??5	      ?   ? RowDefinitions  5
   
   ?? 5      ?? 5      $??40 ?6   .+?5   
   ?? $??0??6   ._?5      &   System.Windows.Controls.DataGrid  -   5          Name$ grd_payments??5      $??0q?6r   ???	#FF042263   
IsReadOnly$
 True??6?      	RowHeight$ 30Q?6?      CanUserAddRows$ False??6?      CanUserSortColumns$
 True??6?      HorizontalGridLinesBrush ?	#FF9B9B9B   VerticalGridLinesBrush ?	#FF9B9B9B   AutoGenerateColumns$ false??67     DataGridStyle1#???   6S  ??6-   ?? ??6E   Z? ??6\   Z? 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   
IsReadOnly$

 True??6Q      Header$ Müşteri Adı??6c      MinWidth$	 100Q?6x   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   ??  ?? Path$ customer_name?   ElementStyle 5      ?? 5       ?? 
TargetType" ??6$   .?5   "   ??  ?? Property ? ?? ?? Value$
 Left=?6H   ?? 5   "    ? ??$ Center=?6F   ?? 5   "    ?@??Padding$ 5q?6<   5      5        5      $

 True??6T   $ Müşteri Soyadı??6f   $	 100Q?6~    6)   ?? $ customer_surname? 5      ?? 5      " ??6$   .?5   "   ??  ? ??$
 Left=?6H   ?? 5   "    ? ??$ Center=?6F   ?? 5   "    ?@??Padding$ 5q?6<   5       5"        5#      $

 True??6N   $ Hesap Id??6`   $	 100Q?6r    6)   ?? $ 
account_id? 5$      ?? 5%      " ??6$   .?5&   "   ??  ? ??$
 Left=?6H   ?? 5'   "    ? ??$ Center=?6F   ?? 5(   "    ?@??Padding$ 5q?6<   5)      5+        5,      $

 True??6P   $ 
Hesap Tipi??6b   $	 100Q?6v    6)   ?? $ account_type? 5-      ?? 5.      " ??6$   .?5/   "   ??  ? ??$
 Left=?6H   ?? 50   "    ? ??$ Center=?6F   ?? 51   "    ?@??Padding$ 5q?6<   52      54        55      $

 True??6J   $ Vade Süresi??6\   $	 100Q?6q    6)   ?? $ expiry? 56      ?? 57      " ??6$   .?58   "   ??  ? ??$
 Left=?6H   ?? 59   "    ? ??$ Center=?6F   ?? 5:   "    ?@??Padding$ 5q?6<   5;      5=        5>      $

 True??6L   $ Kredi Tutarı??6^   $	 100Q?6t    6)   ?? $ quantity? 5?      ?? 5@      " ??6$   .?5A   "   ??  ? ??$
 Left=?6H   ?? 5B   "    ? ??$ Center=?6F   ?? 5C   "    ?@??Padding$ 5q?6<   5D      5F        5G      $

 True??6O   $ Taksit Miktarı??6a   $	 100Q?6y    6)   ?? $ installment? 5H      ?? 5I      " ??6$   .?5J   "   ??  ? ??$
 Left=?6H   ?? 5K   "    ? ??$ Center=?6F   ?? 5L   "    ?@??Padding$ 5q?6<   5M      5O        5P      $

 True??6K   $ Kredi Id??6]   $	 100Q?6o    6)   ?? $ loan_id? 5Q      ?? 5R      " ??6$   .?5S   "   ??  ? ??$
 Left=?6H   ?? 5T   "    ? ??$ Center=?6F   ?? 5U   "    ?@??Padding$ 5q?6<   5V      5X      5[      5\      ?? 5]   
   
???????$??1??6$   ._?5^      ??  ?? Orientation$ 
Horizontal=?6   $??Right=?62   $??Center=?6N   .+?5_      ?? -   5         ??Name$ btn_payment_add??5_   h     userControlMusteriEkle#???  6   $??Ödeme PLanı Oluştur??6J   6?   5`      5a      5b      5c      