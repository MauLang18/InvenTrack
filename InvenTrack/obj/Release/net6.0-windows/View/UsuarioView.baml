   M S B A M L   `   `   `  ���� E  AInvenTrack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:InvenTrack.ViewInvenTrack.View  ;"clr-namespace:InvenTrack.ViewModelInvenTrack.ViewModel  !    InvenTrack.View.UsuarioView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:InvenTrack.View     8	viewModel"clr-namespace:InvenTrack.ViewModel     X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp    � 	Resources      BooleanToVisibilityConverter �� 
TargetType �� Property �� Value��%�   &	        '��      �� �� " ��.���  � ��
 ���� ��  � ��
 �   ���  � ��$ Medium"���  � ��$ 15(�.���  � ColumnDefinitions �� �� ��  � RowDefinitions �� $
��55.5 ��� $
��55.5 ��� .+��� $��0��$��0��.+��� $��USUARIO��
�������$��12(�$��Medium"�$��
Montserrat)��� -    ��Name$ 
txtUsuario��$��13(�$��Medium"�$��
Montserrat)�
������� �� 
CaretBrush
 �����
�������$��0,0,0,1q�$��28��$��Center=�$��0,10,0,0q�$��20,0,0,0q� �� CharacterCasing$ Lower=����� *	Usuario+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=�.������  �� ImageSource$ /Images/write.png�� j� Stretch$
 None=� j� 
AlignmentX$
 Left=�.���� $��0��$��1��.+��� $��NOMBRE��
�������$��12(�$��Medium"�$��
Montserrat)��� -   $ 	txtNombre��$��13(�$��Medium"�$��
Montserrat)�
�������
 �����
�������$��0,0,0,1q�$��28��$��Center=�$��0,10,0,0q�$��20,0,0,0q�$ Upper=����� *Nombre+$	 TwoWay=�$
 PropertyChanged=�.������ $ /Images/write.png��$
 None=�$
 Left=�.���� $��0��$��2��.+��� $��
APELLIDO 1��
�������$��12(�$��Medium"�$��
Montserrat)��� -   $ txtApellido1��$��13(�$��Medium"�$��
Montserrat)�
�������
 �����
�������$��0,0,0,1q�$��28��$��Center=�$��0,10,0,0q�$��20,0,0,0q�$ Upper=����� *	Apellido1+$	 TwoWay=�$
 PropertyChanged=�.������ $ /Images/write.png��$
 None=�$
 Left=�.���� $��1��$��0��.+��� $��	APELLIDO2��
�������$��12(�$��Medium"�$��
Montserrat)��� -   $ txtApellido2��$��13(�$��Medium"�$��
Montserrat)�
�������
 �����
�������$��0,0,0,1q�$��28��$��Center=�$��0,10,0,0q�$��20,0,0,0q�$ Upper=����� *	Apellido2+$	 TwoWay=�$
 PropertyChanged=�.������ $ /Images/write.png��$
 None=�$
 Left=�.���� $��1��$��1��.+��� $��CONTRASEÑA��
�������$��12(�$��Medium"�$��
Montserrat)��� -   $ txtContrasena��$��13(�$��Medium"�$��
Montserrat)�
�������
 �����
�������$��0,0,0,1q�$��28��$��Center=�$��0,10,0,0q�$��20,0,0,0q�$ Normal=����� *
Contrasena+$	 TwoWay=�$
 PropertyChanged=�.������ $ /Images/write.png��$
 None=�$
 Left=�.���� $��1��$��2��$��	0,2.5,0,0q�.+��� -    ��Name$ 	btnEditar��$��0q�$��EDITAR��
�������$��16(�$��
Montserrat)� � Cursor$
 Hand��$��0,5,0,0q����� *ModificarUsuarioCommand+y��� *IsVisibleEditar+ �� 	Converter# [  ���� " ��.���  � �� �#462ad8 �� Triggers P�  P� Property �@J�IsMouseOver P� Value$
 True��. ���  � �� �#28aeed����  �� 
TargetType" ��.R��� $	��150��$��40�� �� CornerRadius$ 20��#��z��._��� $��Center=�$��Center=��� $��1��$��2��$��	0,2.5,0,0q�.+��� -   $ 
btnGuardar��$��0q�$��GUARDAR��
�������$��16(�$��
Montserrat)�$
 Hand��$��0,5,0,0q����� *AgregarUsuarioCommand+y��� *IsVisibleGuardar+# [  ���� " ��.���  � �� �#462ad8 P�  �@J�IsMouseOver$
 True��. ���  � �� �#28aeed���� " ��.R��� $	��150��$��40��$ 20��#��z��._��� $��Center=�$��Center=��� $��4��$��3��$��0,10,0,0q�.+�&   System.Windows.Controls.DataGrid     AutoGenerateColumns$ False��   CanUserAddRows$ False������ *UsuarioList+$	 TwoWay=�$
 PropertyChanged=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ID��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *PK_TBL_INVE_USUARIO+  $ Usuario��$ *  �� *	USUARIO+  $ Nombre��$ *  �� *NOMBRE+  $ 
Apellido 1��$ *  �� *	APELLIDO1+  $ 
Apellido 2��$ *  �� *	APELLIDO2+4  .System.Windows.Controls.DataGridTemplateColumn  $ *    CellTemplate �� .R��� $��Editar������ *DataContext.PruebaCommand+ �� RelativeSource ��  �� AncestorType"  ����  �� Path$ .� �� *  $System.Windows.Controls.DataGridCell"  ���� " ��.���  � �� �#462ad8 P�  �@J�IsMouseOver$
 True��. ���  � �� �#28aeed  $ *  �� .R��� $��Eliminar������ *$"DataContext.EliminarUsuarioCommand+ �� "  ���� $ .� �� "  ���� " ��.���  � �� �#462ad8 P�  �@J�IsMouseOver$
 True��. ���  � �� �#28aeed  =  7System.Windows.Controls.Primitives.DataGridColumnHeader  panelActiveColor  
panelColor��%�   '        7  '  g     7  �� "  .���  � ��8   ��  � ��
 �������  � ��$ Medium"���  � ��$ 14(��� "  .���  � ��8   ��  � ��
 �������  � ��$ Medium"���  � ��$ 15(�