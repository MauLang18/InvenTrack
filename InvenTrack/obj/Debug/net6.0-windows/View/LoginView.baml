   M S B A M L   `   `   `  ����E  AInvenTrack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:InvenTrack.ViewInvenTrack.View  5   	   ;"clr-namespace:InvenTrack.ViewModelInvenTrack.ViewModel  5   	   E'clr-namespace:InvenTrack.CustomControlsInvenTrack.CustomControls  5   	       InvenTrack.View.LoginView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:InvenTrack.View     5   	   8	viewModel"clr-namespace:InvenTrack.ViewModel     5   	   Bcustomcontrols'clr-namespace:InvenTrack.CustomControls     5   	   -   5          � Title$  	LoginView��5
   	   $	��550��5   	   $	��800��5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency$
 True��5   	    � DataContext 5      )   #InvenTrack.ViewModel.LoginViewModel  5   
    � 	Resources 5         BooleanToVisibility��%   &	        �� 5   
   6'   5      y�5      �� 5   
    �� Path$ IsViewVisible�6    �� Mode$ TwoWay=�5      	 �� 	Converter#	 [  5      .��5      �� 
 �� CornerRadius$
 12��6   ��5   
   �� 5        �� ImageSource$ /Images/back-image.jpg��6   ._�5"   
   �� $
 10��6   $��1q�5#       J� Opacity$
 0.95Q�5$      ��5%      �� 5&       �� 
StartPoint$	 0,0&�6&    �� EndPoint$	 1,1&�5'   &   .��5(      �   winBorderColor1 � Color# [ 6#    � Offset$ 0Q�5)   #   � 5*        winBorderColor2# [ 6#   $
 0.75Q�5+   #   � 5,        winBorderColor3# [ 6#   $ 1Q�5-   #   5.      ��50      �� 51      $	 0,1&�6&   $	 1,0&�52   &   .��53      �   primaryBackColor1# [ 6#   $ 0Q�54   #   � 55        primaryBackColor2# [ 6#   $
 0.75Q�56   #   57      ._�59      �  � RowDefinitions 5:      �� 5;      $��30 �6$   �� 5<      .+�5>      �  � ColumnDefinitions 5?      �� 5@      $	��743 �6+   �� 5A      $��25 �6+   �� 5B      $��25 �6+   �� 5C      $��5 �6+   .+�5E      �� $��LOGIN��6    
�������$��10(�5G       $��
Montserrat)�5H       $��0��5I       $��Center=�5J       $��10,0,0,0q�5K       �� 5L      -   5         ��Name$ btnMinimize��5L      $��0q�5M      $��-��5N      
�������$��16(�5P      $��
Montserrat)�5Q       � Cursor$
 Hand��5R      $��1��5S      ��5U      �� 5V       �� 
TargetType" ��6$   .�5W   "   ��  �� Property � �� �� Value �#28aeed5X   )    �� Triggers 5Y   "   P� 5Z   &    P� Property �@J�IsMouseOver P� Value$
 True��5[   .   . �5\   *   ��  � �� �#278bef5]   1   5^   '   5`      ��5b      �� 5c       �� 
TargetType" ��6.   .R�5d   "   �� $��18��6)   $��18��5e   )   $
 9��5f   )   #��z��5g   )   ._�5h   &   �� $��Center=�67   $��Center=�5i   7   5j   #   5k      5m      �� 5n      -   5        $ btnClose��5n      $��0q�5o      $��X��5p      
�������$��16(�5r      $��
Montserrat)�5s      $
 Hand��5t      $��2��5u      ��5w      �� 5x      " ��6$   .�5y   "   ��  � �� �#da34ae5z   )    5{   "   P� 5|   &    �@J�IsMouseOver$
 True��5}   .   . �5~   *   ��  � �� �#c62dae5   1   5�   '   5�      ��5�      �� 5�      " ��6.   .R�5�   "   �� $��18��6)   $��18��5�   )   $
 9��5�   )   #��z��5�   )   ._�5�   &   �� $��Center=�67   $��Center=�5�   7   5�   #   5�      5�      5�      �� 5�      $	��250��6   $��2��5�       �� Orientation$ Vertical=�5�      $��0,35,0,0q�5�      .+�5�      �� $��/Images/inventory.png��6   $	��100��5�      $	��100��5�      �� 5�      $��
InvenTrack��6    
�������$��25(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��Center=�5�       �� 5�      $��Username��6    
�������$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��0,35,0,0q�5�       �� 5�      -   5         ��Name$ txtUser��5�      $��13(�5�      $��Medium"�5�      $��
Montserrat)�5�      
������� �� 
CaretBrush
 �����
�������$��0,0,0,1q�5�      $��28��5�      $��Center=�5�      $��0,5,0,0q�5�      $��20,0,0,0q�5�       �� CharacterCasing$ Lower=�5�      ��5�      �� *
Username+$ TwoWay=�  �� UpdateSourceTrigger$  PropertyChanged=�.��5�   6   ��5�      �� 5�      $ /Images/user.png��6)   ! j� Stretch$
! None=�5�   )   " j� 
AlignmentX$
" Left=�5�   )   .��5�   .   5�      �� 5�      $��Password��6    
�������$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��0,35,0,0q�5�       0   *InvenTrack.CustomControls.BindablePassword  5�      $��28��5�   6   $��0,5,0,0q�5�   6   #   Password# 5�   6   �� *
Password+$ TwoWay=�$  PropertyChanged=�5�      �� 5�      ���#d7596d$��12(�5�       $��Medium"�5�       $��
Montserrat)�5�       $��0,10,0,0q�5�       $
��Wrap=�5�       ��5�       �� *ErrorMessage+5�       �� 5�      -   5        $ btnLogin��5�      $��0q�5�      $��LOGIN��5�      
�������$��16(�5�      $��
Montserrat)�5�      $
 Hand��5�      $��2��5�      $��0,50,0,0q�5�      ��5�      �� *LoginCommand+��5�      �� 5�      " ��6$   .�5�   "   ��  � �� �#462ad85�   )    5�   "   P� 5�   &    �@J�IsMouseOver$
 True��5�   .   . �5�   *   ��  � �� �#28aeed5�   1   5�   '   5�      ��5�      �� 5�      " ��6.   .R�5�   "   �� $	��150��6)   $��40��5�   )   $
 20��5�   )   #��z��5�   )   ._�5�   &   �� $��Center=�67   $��Center=�5�   7   5�   #   5�      5�      5�      5�      5�      5�      5�      