   M S B A M L   `   `   `  ����E  AInvenTrack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:InvenTrack.ViewInvenTrack.View  5   	   ;"clr-namespace:InvenTrack.ViewModelInvenTrack.ViewModel  5   	       InvenTrack.View.MainView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:InvenTrack.View     5   	   8	viewModel"clr-namespace:InvenTrack.ViewModel     5   	   X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	     � Title$  MainView��5
   	   $	��700��6   $
��1300��6'    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   
������  � AllowsTransparency$
 True��5   	    � DataContext 5      (   "InvenTrack.ViewModel.MainViewModel  5   
    � 	Resources 5       �� DataType(   "InvenTrack.ViewModel.HomeViewModel   InvenTrack.View.HomeView*   $InvenTrack.ViewModel.BoletaViewModel    InvenTrack.View.BoletaView+   %InvenTrack.ViewModel.UsuarioViewModel!   InvenTrack.View.UsuarioView��%�   (��       5      *, +)(�� 2     5      *, +)(�� d     5      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      5      .��5      ��  �� CornerRadius$ 10��6   $��1q�5      ��5   
   �� 5        �� 
StartPoint$	 0,0&�6"   	 �� EndPoint$		 1,1&�5!   "   .��5"      �    winBorderColor1
 � Color#
 [  6    � Offset$ 0Q�5#      � 5$        winBorderColor2#
 [ 6   $
 0.75Q�5%      � 5&        winBorderColor3#
 [ 6   $ 1Q�5'      5(      ._�5*   
   �  � ColumnDefinitions 5+      �� 5,      $	��250 �6#   �� 5-      $��* �6#   .+�5/      �� $ 	10,0,0,10��6   $��0��50      ��51      �� 52      $	 0,0&�6*   $	 1,0.7&�53   *   .��54      �   secondaryBackColor1#
 [ 6'   $ 0Q�55   '   � 56        secondaryBackColor2#
 [ 6'   $ 1Q�57   '   58      ._�5:      �� .+�5;      ��  �� Orientation$ 
Horizontal=�6!   $��35��5<   !   $��
12,25,0,40q�5=   !   .+�5>      �� $��/Images/inventory.png��6    $��30��5?       �� 5@      $��
InvenTrack��6%     titleColor2#��[ 5A   %   $��20(�5B   %   $��
Montserrat)�5C   %   $��Medium"�5D   %   $��Center=�5E   %   $��10,0,0,0q�5F   %   5G      	� 5H        
menuButton#��[ 6"    
 color1
 � Tag# [ 5I   "    d� 	IsChecked$
 TrueY�5J   "   ��5K   "   �� *ShowHomeViewCommand+.��5L      �� $ 
Horizontal=�6%   .+�5M      !  FontAwesome.Sharp.IconImage  �	  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]] 	  Icon$
 List=�6+     menuButtonIcon#��[ 5N   +   �� 5O      $��
Inventario��6(    	 menuButtonText#��[	 5P   (   5Q      5R      	� 5S      #��[ 6"    

 color2# [
 5T   "   ��5U   "   �� *ShowBoletaViewCommand+.��5V      �� $ 
Horizontal=�6%   .+�5W        $ FileAlt=�6+   #��[ 5X   +   �� 5Y      $��Boleta��6(   #��[	 5Z   (   5[      5\      	� 5]      #��[ 6"    
 color3# [ 5^   "   ��5_   "   �� *ShowUsuarioViewCommand+.��5`      �� $ 
Horizontal=�6%   .+�5a        $
 User=�6+   #��[ 5b   +   �� 5c      $��Usuarios��6(   #��[	 5d   (   5e      5f      5g      5h      �� 5i      $ 	0,10,10,0��6   $��1��5j      ��5k      �� 5l      $	 1,1&�6*   $		 0,0&�5m   *   .��5n      �   primaryBackColor1#
 [ 6'   $ 0Q�5o   '   � 5p        primaryBackColor2#
 [ 6'   $ 1Q�5q   '   5r      ._�5t      �  � RowDefinitions 5u      �� 5v      $��25 �6(   �� 5w      $��35 �6(   �� 5x      $��* �6(   .+�5z      �� -   5         ��Name$ pnlControlBar��5z   !   $��0��5{   !   $ 
Horizontal=�5|   !   $��RightToLeft=�5}   !   
������ $��0,0,5,0q�5   !   .+�5�      �� -   5         ��Name$ btnClose��5�   !     controlButton#��[ 5�   !    
 color4# [ 5�   !   .��5�        $ Xmark=�6+     controlButtonIcon#��[ 5�   +   5�      �� 5�      -   5        $ btnMaximize��5�   !   #��[ 5�   !    
 color8# [ 5�   !   .��5�        $ Square=�6+   #��[ 5�   +   5�      �� 5�      -   5        $ btnMinimize��5�   !   #��[ 5�   !    
 color6# [ 5�   !   .��5�        $ WindowMinimize=�6+   $��12��5�   +   #��[ 5�   +   5�      5�      � 5�      $��1��6    5�      �� 5�      �� 5�      .+�5�      �� $��0��6%   $ 
Horizontal=�5�   %   $��Center=�5�   %   .+�5�        $��20��5�   +   $��20��5�   +    	  
Foreground# [ 5�   +   $��	35,0,10,0q�5�   +    5�   +   �� *Icons+5�   +   �� 5�      #��[ 5�   (   $��16(�5�   (   $��
Montserrat)�5�   (   $��Medium"�5�   (   $��Center=�5�   (   ��5�   (   �� *	Caption+5�   (   5�      �� 5�      $��1��6%   $ 
Horizontal=�5�   %   $��RightToLeft=�5�   %   $��Center=�5�   %   $��0,0,10,0q�5�   %   .+�5�      ��   iconlButton#��[ 6%   # [ 5�   %   .��5�   "     $
 Gear=�6/     iconButtonIcon#��[ 5�   /   5�      �� 5�        titleColor3#��[ 5�   (   $��12(�5�   (   $��
Montserrat)�5�   (   $��Center=�5�   (   ��5�   (   �� * CurrentUserAccount.DISPLAYNAME+5�   (   A� 5�      $��35��6&   $��35��5�   &   #��[
 5�   &   $��2��5�   &   $��	10,0,10,0q�5�   &   ��5�   "   �� 5�   &    �� ImageSource$ /Images/user.png��61   5�      5�      5�      �� 5�      $��2��5�   %   $��25q�5�   %   ��5�   %   �� *CurrentChildView+5�   %   5�      5�      5�      5�      5�      