   M S B A M L   `   `   `  ????F  BZadanie1WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Zadanie1WPFZadanie1WPF  5   	       Zadanie1WPF.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Zadanie1WPF     5   	   -   5        $??
thisWindow??5   7     ? Title$  Pełnoletność??6	   $	??400??6   $	??400??6+    ? WindowStyle$ SingleBorderWindow=?6I   .??5	      ?? $??20q?6   .+?5
   
   ?? $??
Podaj Imie??6   $??18(?5      $??
ExtraLight"?5      $??0 0 0 5q?5      $??OCR A Extended)?6%   ?? 5      -   5        $??TextBoxName??5      $??30??5      $??Center=?5      $??1 0 0 1q?5      ??5      ??  ?? ElementName$ 
thisWindow?? ?? Path$ 
PublicName?.??5   0    J? Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      .??5      5      ?? 5   
   $??
Podaj Wiek??6   $??18(?5      $??
ExtraLight"?5      $??0 15 0 5q?5      $??OCR A Extended)?6&   ?? 5    
   -   5        $??
TextBoxAge??5       
???????$??30??5#      $??Center=?5$      $??2,0,0,2q?5%      ??5!      ?? $ 
thisWindow??$ 	PublicAge?.??5%   ,    5&        5'      .??5(      5)      ?? 5-   
   -   5        $??SPRAWDŹ??5-      $??0 30 0 5q?5.      $??0q?5/      $??50??50      ???	#FF2E2E2E$??12(?52      $??
ExtraLight"?53      $	??160??6)   $??OCR A Extended)?65   ??54      ?? 55       ?? EndPoint$ 0.5,1&?6&    ?? 
StartPoint$ 0.5,0&?67   .??56      ?  ? Color$ 	#FFEFEEFF??6#   ? 57      $ Green??6#    ? Offset$ 1Q?61   58      5:      ?? 5<   
   -   5        $??SPRAWDŹ Z BINDOWANIEM??5<      $??0q?5=      $??50??5>      $??0 0 0 10q?5?      $??14(?5@      $??
ExtraLight"?5A      ???	#FF2E2E2E$	??195??5B   (   $??OCR A Extended)?64   ??5C      ?? 5D      $ 0.5,1&?6&   $ 0.5,0&?67   .??5E      ? $ Green??6#   ? 5F      $ 	#FFEFEEFF??6#   $ 1Q?65   5G      5I      ?? 5K   
   -   5        $??Alert??5K      ???	#FF7070706!   ?? 5M   
   -   5        $??result??5M      ???	#FF7070706"   5N      5T      