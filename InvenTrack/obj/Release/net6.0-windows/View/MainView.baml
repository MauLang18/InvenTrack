   M S B A M L   `   `   `  ���� E  AInvenTrack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:InvenTrack.ViewInvenTrack.View  ;"clr-namespace:InvenTrack.ViewModelInvenTrack.ViewModel      InvenTrack.View.MainView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:InvenTrack.View     8	viewModel"clr-namespace:InvenTrack.ViewModel     X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp    � Title$  MainView��$	��700��$
��1300�� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=�
������  � AllowsTransparency$
 True�� � DataContext (   "InvenTrack.ViewModel.MainViewModel   � 	Resources  �� DataType(   "InvenTrack.ViewModel.HomeViewModel   InvenTrack.View.HomeView*   $InvenTrack.ViewModel.BoletaViewModel    InvenTrack.View.BoletaView+   %InvenTrack.ViewModel.UsuarioViewModel!   InvenTrack.View.UsuarioView��%f   (��       *, +)(��      *, +)(�� $     *, +)�� "  .R�  �� "  .R�  �� "  .R�  .����  �� CornerRadius$ 10��$��1q�����  �� 
StartPoint$	 0,0&�	 �� EndPoint$		 1,1&�.���    winBorderColor1
 � Color#
 [   � Offset$ 0Q��   winBorderColor2#
 [ $
 0.75Q��   winBorderColor3#
 [ $ 1Q�._��  � ColumnDefinitions �� $	��250 ��� $��* �.+��� $ 	10,0,0,10��$��0������ $	 0,0&�$	 1,0.7&�.���   secondaryBackColor1#
 [ $ 0Q��   secondaryBackColor2#
 [ $ 1Q�._��� .+���  �� Orientation$ 
Horizontal=�$��35��$��
12,25,0,40q�.+��� $��/Images/inventory.png��$��30���� $��
InvenTrack��  titleColor2#��[ $��20(�$��
Montserrat)�$��Medium"�$��Center=�$��10,0,0,0q�	�   
menuButton#��[  
 color1
 � Tag# [  d� 	IsChecked$
 TrueY����� *ShowHomeViewCommand+.���� $ 
Horizontal=�.+�!  FontAwesome.Sharp.IconImage  �	  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]] 	  Icon$
 List=�  menuButtonIcon#��[ �� $��
Inventario�� 	 menuButtonText#��[	 	� #��[  

 color2# [
 ���� *ShowBoletaViewCommand+.���� $ 
Horizontal=�.+�  $ FileAlt=�#��[ �� $��Boleta��#��[	 	� #��[  
 color3# [ ���� *ShowUsuarioViewCommand+.���� $ 
Horizontal=�.+�  $
 User=�#��[ �� $��Usuarios��#��[	 �� $ 	0,10,10,0��$��1������ $	 1,1&�$		 0,0&�.���   primaryBackColor1#
 [ $ 0Q��   primaryBackColor2#
 [ $ 1Q�._��  � RowDefinitions �� $��25 ��� $��35 ��� $��* �.+��� -    ��Name$ pnlControlBar��$��0��$ 
Horizontal=�$��RightToLeft=�
������ $��0,0,5,0q�.+��� -    ��Name$ btnClose��  controlButton#��[  
 color4# [ .��  $ Xmark=�  controlButtonIcon#��[ �� -   $ btnMaximize��#��[  
 color8# [ .��  $ Square=�#��[ �� -   $ btnMinimize��#��[  
 color6# [ .��  $ WindowMinimize=�$��12��#��[ � $��1�� �� �� .+��� $��0��$ 
Horizontal=�$��Center=�.+�  $��20��$��20�� 	  
Foreground# [ $��	35,0,10,0q� �� *Icons+�� #��[ $��16(�$��
Montserrat)�$��Medium"�$��Center=����� *	Caption+�� $��1��$ 
Horizontal=�$��RightToLeft=�$��Center=�$��0,0,10,0q�.+���   iconlButton#��[ # [ .��  $
 Gear=�  iconButtonIcon#��[ ��   titleColor3#��[ $��12(�$��
Montserrat)�$��Center=����� * CurrentUserAccount.DISPLAYNAME+A� $��35��$��35��#��[
 $��2��$��	10,0,10,0q�����  �� ImageSource$ /Images/user.png���� $��2��$��25q����� *CurrentChildView+