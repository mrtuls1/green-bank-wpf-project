   M S B A M L   `   `   `  ????D  @GreenBank, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:GreenBank.View.CustomerGreenBank.View.Customer  5   	   0    *GreenBank.View.Customer.CustomerMainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:GreenBank.View.Customer     5   	   -   5          ? Title$  CustomerMainWindow??5      $	??600??6'   $	??900??64    ? 
ResizeMode$ NoResize=?6@    ? AllowsTransparency$
 True??6V    ? WindowStyle$
 None=?6p    ? WindowStartupLocation$ CenterScreen=?6?   ??6?   Z? .??5	      ? .+?5
   
   ? -   5         ?Name$ grd_MainGridWindow??5
      $??15q?6    J? Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q?6#      	Direction$	 265Q?63   	   Opacity$		 0.6Q?6C   
   RenderingBias$
 Performance=?6Q    ? RowDefinitions 5      ?? 5      $	??170 ?6    ?? 5       ? ColumnDefinitions 5      ?? 5      $	??220 ?6#   ?? 5      .+?5      ?? ???#256D85$??0??6*   $??0??6:   ._?5      ?  5      ?? 5      $??35 ?6(   ?? 5      .+?5      ?? $??0??6   ._?5      ]? $??Center=?6%   $??Center=?6B   .+?5       ?? $ ??/Images/materials/logo.png??6$   $??24??6H   $??24??6T   ?? 5!      $??	GREENBANK??6$   
???????$??Center=?6K   $??Center=?6h   5"      5#      ?? 5$      $??1??6   ??5%      ?? 5&       ?? 
TargetType" ??6$   .?5'   "   ??  ?? Property ? ?? ?? Value ?#256D856?    ?? Triggers 5(   "   P? 5)   &    P? Property ?@J?IsMouseOver P? Value$
 True??6E   . ?5*   *   ??  ? ?? ?	#FF5F96CF6G   5+   '   5-      ._?5/      ]? $??Center=?6%   $??Center=?6B   .+?50      ?? ??51   "   ?? 52   &   " ??6,   .?53   *   ??  ? ??$  /images/materials/bank.png??6C   ?? 54   *    ? ??$
 auto??6C   ?? 55   *    ? ??$	 100??6B    56   *   P? 57   .    ?@J?IsMouseOver$
 True??6M   . ?58   2   ??  ? ??$	 105??6J   59   /   5;   '   5=      5>      5?      5@      5A      ?? 5E      -   5         ??Name$ 
brdLeftTop??5E   G   ???#134187$??1??6*   $??0??6:   ._?5G      ?  5H      ?? 5I      $??35 ?6(   ?? 5J      .+?5L      ?? 
???????$??0??60   ._?5M      ]? $	??105??6$   $??Right=?60   .+?5N      ?? -   5         ??Name$ btn_minimize??5N   3   $??--??6%      minibuttons#???   6e   $??12(?6?   ?? 5O      -   5        $ btn_fullscreen??5O   2   $??||??6%   #???   6g   $??12(?6?   ?? 5P      -   5        $ 	btn_close??5P   2   $??X??6%   #???   6]   $??12(?6?   5Q      5R      ?? 5S      $??1??6   ???#256D85 5T        5U      $	 221Q?6/   $		 0.2Q?6?   ._?5W      ?  5X      ?? 5Y   "   ?? 5Z   "   $	??350 ?63   .+?5\      ?? $??0??6%   ._?5]   "   ?? $??Center=?6-   $??30,0,0,0q?6H   .+?5^   &   ]? 5`   '   ?? 5a   &    ?? Orientation$ 
Horizontal=?61   5b   '   5c   #   5d      ?? 5e      $??1??6%   ._?5f   "   ?? $	??120??6)    ?? CornerRadius$ 10,10,10,10??66   $??	65,8,32,7q?6Q   ._?5g   &   ?? $ 
Horizontal=?61   $??	0,0,-39,0q?6J   .+?5h   *   ?? $??/images/icons/user.png??60   $	??100??6P   6^   ?? 5i   *   $??Center=?65   $??20,0,0,0q?6P   .+?5j   .   ?? -   5         ??Name$ lbl_customer_name??5j   4   $??Müşteri Adı??6O   
???????$
??Bold"?6x   ?? 5k   .   -   5        $ lbl_customer_title??5k   4   $??	Müşteri??6P   
???  ??$
??Bold"?6s   5l   +   5m   '   5n   #   5o      5p      5q      5r      5s      ?? 5v      ???#256D85$??0??6*   $??1??6:   ._?5w      ?  5x      ?? 5y      ?? 5z      $	??150 ?6(   .+?5}      ?? $??0??6!   .+?5~      ?? -	   5        $ menu_button_credits??5~   S   $??50??6!     menubuttons#???  6-   .??5      ]? $	??220??6(   $??15,0,0,0q?64   .+?5?   "   ?? $'??!/images/materials/calculation.png??6(   $??32??6S   ?? 5?   "   $??Hesaplar??6(   
???????$??16(?6N   5?      5?      ?? 5?      -
   5        $ menu_button_payments??5?   S   $??50??6!   #???  6-   .??5?      ]? $	??220??6(   $??15,0,0,0q?64   .+?5?   "   ?? $*??$/images/materials/payment-method.png??6(   $??32??6V   ?? 5?   "   $??	Ödemeler??6(   
???????$??16(?6N   5?      5?      ?? 5?      -   5        $ menu_button_transactions??5?   S   $??50??6!   #???  6-   .??5?      ]? $	??220??6(   $??15,0,0,0q?64   .+?5?   "   ?? $#??/images/materials/lending.png??6(   $??32??6O   ?? 5?   "   $??
Hareketler??6(   
???????$??16(?6P   5?      5?      ?? 5?      -   5        $ menu_button_loans??5?   S   $??50??6!   #???  6-   .??5?      ]? $	??220??6(   $??15,0,0,0q?64   .+?5?   "   ?? $&?? /images/materials/debit-card.png??6(   $??32??6R   ?? 5?   "   $??Krediler??6(   
???????$??16(?6N   5?      5?      ?? 5?      $??50??6!   #???  6-   .??5?      ]? $	??220??6(   $??15,0,0,0q?64   .+?5?   "   ?? $!??/images/materials/gears.png??6(   $??32??6M   ?? 5?   "   $??Profil ve Ayarlar??6(   
???????$??16(?6W   5?      5?      ?? 5?      $??50??6!   #???  6-   .??5?      ]? $	??220??6(   $??15,0,0,0q?64   .+?5?   "   ?? $??/images/icons/read4.png??6(   $??32??6I   ?? 5?   "   $??Güvenli Çıkış??6(   
???????$??16(?6S   5?      5?      5?      ?? 5?      $??1??6!   .+?5?      ?? .+?5?      ??  ?? Left$ 35??6%   
 ?? Top$ 90??66   $ 10,10,10,10??6F   $
??Left=?6a   $	??Top=?6|   $	??150??6?   $??29??6?   ._?5?   "   ?? -   5        $ Version??5?   ?   $??1.0.0.1??6(   
???   ?$??Center=?6M   $??Center=?6o   6?   ??5?   "   ?? 5?   &   " ??6,   .?5?   *   ??  ? ??
 ?????6G    5?   *   P? 5?   .    ?@J?IsMouseOver$
 True??6M   . ?5?   2   ??  ? ??
 ?????6O   5?   /   5?   '   5?      5?      5?      5?      5?      ?? 5?      $??1??6   $??1??6%   
???????._?5?      ? -   5        $ Content_Icerik??5?      5?      5?      5?      5?      5?      