   M S B A M L   `   `   `  ????D  @GreenBank, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:GreenBank.ViewGreenBank.View  5   	       GreenBank.View.LoanDetail   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:GreenBank.View     5   	   -   5          ? Title$  
LoanDetail??5   	   $	??520??6   $	??820??6)    ? AllowsTransparency$
 True??65    ? WindowStyle$
 none=?6e    ? WindowStartupLocation$ CenterScreen=?6x   ??6O   Z? .??5	      ? .+?5
   
   ?? $??0??6   ._?5      ?? $??	0,0,0,-39q?6   .+?5      ?? $??/images/icons/read4.png??6   $??36??69   $??50??6E    ?? Left$ 8??6P   
 ?? Top$ 22??6`   $
??Left=?6p   $	??Top=?6?    K? ZIndex$ 3??6?   ?? 5      $??	Ödemeler??6   $ 60??6+   $ 27??6<   $??32??6L   
???????$
??Bold"?6k   $??Center=?6}   $??Center=?6?   $ 3??6?   $??Center=?6?   $	??Top=?6?   ?? 5      -   5         ??Name$ 	btn_close??5   ]   $??X??6    ?? Right$ 0??6%   $ 26??66   $??35??6F   $??40??6R      minibuttons#???   6?   $??12(?6?   $ 3??6?   $	 770??6?   ?? 5      -   5        	 ??Name$	 border_left_top??5   V   $??35??6   $	??800??6(   ???	#FF134187$ 1??6E   $ 10??6?   $ 26??6?   $??Center=?6?   $	??Top=?6?   A? 5      $??52??6   $??52??6&   $ 14??61   $ 1??6A   $??4??6R   ??5      
? 5      .??5      ? 
 ? Color$
 	#FF134187??6+    ? Offset$ 0.963Q?6=   ? 5      $
 White??6+   $ 0.983Q?69   ? 5      $
 	#FFF1F2F3??6+   $ 0.913Q?6=   5      5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ grd_loan??5      $??0q?6r   ???	#FF042263   
IsReadOnly$
 True??6?      	RowHeight$ 30Q?6?      CanUserAddRows$ False??6?      CanUserSortColumns$
 True??6?      HorizontalGridLinesBrush ?	#FF9B9B9B   VerticalGridLinesBrush ?	#FF9B9B9B   AutoGenerateColumns$ false??67    DataGridStyle1#???  6S  $ 63??6|  $	??796??6?  $??Center=?6?  $	??424??6?  $	??Top=?6?  $ 14??6?  ??6-   ?? ??6E   Z? ??6\   Z?    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly$
 True??6J      Header$ Id??6\      MinWidth$	 100Q?6h   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   ??  ?? Path$ id?   ElementStyle 5      ?? 5   "    ?? 
TargetType" ??6(   .?5   &   ??  ?? Property ? ?? ?? Value$
 Left=?6L   ?? 5    &    ? ??$ Center=?6J   ?? 5!   &    ?@??Padding$ 5q?6@   5"   #   5$        5%      $
 True??6U   $ Ödeme Tarihi??6g   $	 100Q?6}    6-   ?? $ payments_date? 5&      ?? 5'   "   " ??6(   .?5(   &   ??  ? ??$
 Left=?6L   ?? 5)   &    ? ??$ Center=?6J   ?? 5*   &    ?@??Padding$ 5q?6@   5+   #   5-        5.      $
 True??6N   $ Ödeme Tutarı??6`   $	 100Q?6v    6-   ?? $ amount? 5/      ?? 50   "   " ??6(   .?51   &   ??  ? ??$
 Left=?6L   ?? 52   &    ? ??$ Center=?6J   ?? 53   &    ?@??Padding$ 5q?6@   54   #   56        57      $
 True??6N   $ Ayrıntılar??6`   $	 100Q?6t    6-   ?? $ detail? 58      ?? 59   "   " ??6(   .?5:   &   ??  ? ??$
 Left=?6L   ?? 5;   &    ? ??$ Center=?6J   ?? 5<   &    ?@??Padding$ 5q?6@   5=   #   5?        5@      $
 True??6R   $ Ödeme Durumu??6d   $	 100Q?6z    6-   ?? $ 
is_it_paid? 5A      ?? 5B   "   " ??6(   .?5C   &   ??  ? ??$
 Left=?6L   ?? 5D   &    ? ??$ Center=?6J   ?? 5E   &    ?@??Padding$ 5q?6@   5F   #   5H        5I      $
 True??6O   $ Kredi Id??6a   $	 100Q?6s    6-   ?? $ loan_id? 5J      ?? 5K   "   " ??6(   .?5L   &   ??  ? ??$
 Left=?6L   ?? 5M   &    ? ??$ Center=?6J   ?? 5N   &    ?@??Padding$ 5q?6@   5O   #   5Q      5S      5T      5U      ?? 5V   
   
???????$??10,32,10,10q?6+   $	 -99??6@   $??1??6S   $??1,1,1,1q?6`   
???   ?6{   5W      5X      