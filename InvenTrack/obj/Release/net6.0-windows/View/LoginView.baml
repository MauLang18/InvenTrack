   M S B A M L   `   `   `  ���� E  AInvenTrack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:InvenTrack.ViewInvenTrack.View  ;"clr-namespace:InvenTrack.ViewModelInvenTrack.ViewModel  E'clr-namespace:InvenTrack.CustomControlsInvenTrack.CustomControls      InvenTrack.View.LoginView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:InvenTrack.View     8	viewModel"clr-namespace:InvenTrack.ViewModel     Bcustomcontrols'clr-namespace:InvenTrack.CustomControls     -     � Title$  	LoginView��$	��550��$	��800�� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�
������  � AllowsTransparency$
 True�� � DataContext )   #InvenTrack.ViewModel.LoginViewModel   � 	Resources    BooleanToVisibility��%   &	        �� y���  �� Path$ IsViewVisible� �� Mode$ TwoWay=�	 �� 	Converter#	 [  .���� 
 �� CornerRadius$
 12������  �� ImageSource$ /Images/back-image.jpg��._��� $
 10��$��1q� J� Opacity$
 0.95Q�����  �� 
StartPoint$	 0,0&� �� EndPoint$	 1,1&�.���   winBorderColor1 � Color# [  � Offset$ 0Q��   winBorderColor2# [ $
 0.75Q��   winBorderColor3# [ $ 1Q����� $	 0,1&�$	 1,0&�.���   primaryBackColor1# [ $ 0Q��   primaryBackColor2# [ $
 0.75Q�._��  � RowDefinitions �� $��30 ��� .+��  � ColumnDefinitions �� $	��743 ��� $��25 ��� $��25 ��� $��5 �.+��� $��LOGIN��
�������$��10(�$��
Montserrat)�$��0��$��Center=�$��10,0,0,0q��� -    ��Name$ btnMinimize��$��0q�$��-��
�������$��16(�$��
Montserrat)� � Cursor$
 Hand��$��1������  �� 
TargetType" ��.���  �� Property � �� �� Value �#28aeed �� Triggers P�  P� Property �@J�IsMouseOver P� Value$
 True��. ���  � �� �#278bef����  �� 
TargetType" ��.R��� $��18��$��18��$
 9��#��z��._��� $��Center=�$��Center=��� -   $ btnClose��$��0q�$��X��
�������$��16(�$��
Montserrat)�$
 Hand��$��2������ " ��.���  � �� �#da34ae P�  �@J�IsMouseOver$
 True��. ���  � �� �#c62dae���� " ��.R��� $��18��$��18��$
 9��#��z��._��� $��Center=�$��Center=��� $	��250��$��2�� �� Orientation$ Vertical=�$��0,35,0,0q�.+��� $��/Images/inventory.png��$	��100��$	��100���� $��
InvenTrack��
�������$��25(�$��Medium"�$��
Montserrat)�$��Center=��� $��Username��
�������$��12(�$��Medium"�$��
Montserrat)�$��0,35,0,0q��� -    ��Name$ txtUser��$��13(�$��Medium"�$��
Montserrat)�
������� �� 
CaretBrush
 �����
�������$��0,0,0,1q�$��28��$��Center=�$��0,5,0,0q�$��20,0,0,0q� �� CharacterCasing$ Lower=����� *
Username+$ TwoWay=�  �� UpdateSourceTrigger$  PropertyChanged=�.������ $ /Images/user.png��! j� Stretch$
! None=�" j� 
AlignmentX$
" Left=�.���� $��Password��
�������$��12(�$��Medium"�$��
Montserrat)�$��0,35,0,0q�0   *InvenTrack.CustomControls.BindablePassword  $��28��$��0,5,0,0q�#   Password# �� *
Password+$ TwoWay=�$  PropertyChanged=��� ���#d7596d$��12(�$��Medium"�$��
Montserrat)�$��0,10,0,0q�$
��Wrap=����� *ErrorMessage+�� -   $ btnLogin��$��0q�$��LOGIN��
�������$��16(�$��
Montserrat)�$
 Hand��$��2��$��0,50,0,0q����� *LoginCommand+���� " ��.���  � �� �#462ad8 P�  �@J�IsMouseOver$
 True��. ���  � �� �#28aeed���� " ��.R��� $	��150��$��40��$
 20��#��z��._��� $��Center=�$��Center=�