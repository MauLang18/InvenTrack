   M S B A M L   `   `   `  ���� E  AInvenTrack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:InvenTrack.ViewInvenTrack.View  ;"clr-namespace:InvenTrack.ViewModelInvenTrack.ViewModel      InvenTrack.View.HomeView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .viewclr-namespace:InvenTrack.View     8	viewModel"clr-namespace:InvenTrack.ViewModel     X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp    � 	Resources      BooleanToVisibilityConverter �� 
TargetType �� Property �� Value��%�   &	        '��      �� �� " ��.���  � ��
 ���� ��  � ��
 �   ���  � ��$ Medium"���  � ��$ 15(�.���� .���  � ColumnDefinitions �� �� ��  � RowDefinitions �� $
��55.5 ��� $
��55.5 ��� $
��55.5 ��� $
��55.5 ��� $��45 ��� .+��� $��0��$��0��.+��� $��
ID SISTEMA��
�������$��12(�$��Medium"�$��
Montserrat)��� -    ��Name$ txtIdSistema��$��13(�$��Medium"�$��
Montserrat)�
������� �� 
CaretBrush
 �����
�������$��0,0,0,1q�$��28��$��Center=�$��0,10,0,0q�$��20,0,0,0q� �� CharacterCasing$ Upper=����� *	IdSistema+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=�.������  �� ImageSource$ /Images/write.png�� j� Stretch$
 None=� j� 
AlignmentX$
 Left=�.���� $��0��$��1��.+��� $��TIPO EQUIPO��
�������$��12(�$��Medium"�$��
Montserrat)��� -   $ txtTipoEquipo��$��13(�$��Medium"�$��
Montserrat)�
�������
 �����
�������$��0,0,0,1q�$��28��$��Center=�$��0,10,0,0q�$��20,0,0,0q�$ Upper=����� *
TipoEquipo+$	 TwoWay=�$
 PropertyChanged=�.������ $ /Images/write.png��$
 None=�$
 Left=�.���� $��0��$��2��.+��� $��MARCA��
�������$��12(�$��Medium"�$��
Montserrat)��� -   $ txtMarca��$��13(�$��Medium"�$��
Montserrat)�
�������
 �����
�������$��0,0,0,1q�$��28��$��Center=�$��0,10,0,0q�$��20,0,0,0q�$ Upper=����� *Marca+$	 TwoWay=�$
 PropertyChanged=�.������ $ /Images/write.png��$
 None=�$
 Left=�.���� $��1��$��0��.+��� $��SERIE��
�������$��12(�$��Medium"�$��
Montserrat)��� -   $ txtSerie��$��13(�$��Medium"�$��
Montserrat)�
�������
 �����
�������$��0,0,0,1q�$��28��$��Center=�$��0,10,0,0q�$��20,0,0,0q�$ Upper=����� *Serie+$	 TwoWay=�$
 PropertyChanged=�.������ $ /Images/write.png��$
 None=�$
 Left=�.���� $��1��$��1��.+��� $��MODELO��
�������$��12(�$��Medium"�$��
Montserrat)��� -   $ 	txtModelo��$��13(�$��Medium"�$��
Montserrat)�
�������
 �����
�������$��0,0,0,1q�$��28��$��Center=�$��0,10,0,0q�$��20,0,0,0q�$ Upper=����� *Modelo+$	 TwoWay=�$
 PropertyChanged=�.������ $ /Images/write.png��$
 None=�$
 Left=�.���� $��1��$��2��.+��� $��ESTADO��
�������$��12(�$��Medium"�$��
Montserrat)��� -    ��Name$ 	txtEstado�� �� DisplayMemberPath$ Nombre��$��13(�$��Medium"�$��
Montserrat)�
���   �
�������$��0,0,0,1q�$��28��$��Center=�$��0,10,0,0q�$��20,0,0,0q����� *	Estados+ �� SelectedItem �� *SelectedEstado+�� $��2��$��0��.+��� $��ACTIVO��
�������$��12(�$��Medium"�$��
Montserrat)��� -   $ 	txtActivo��$��13(�$��Medium"�$��
Montserrat)�
�������
 �����
�������$��0,0,0,1q�$��28��$��Center=�$��0,10,0,0q�$��20,0,0,0q�$ Upper=����� *Activo+$	 TwoWay=�$
 PropertyChanged=�.������ $ /Images/write.png��$
 None=�$
 Left=�.���� $��2��$��1��$��2��.+��� $��DETALLES��
�������$��12(�$��Medium"�$��
Montserrat)��� -   $ txtDetalles��$��13(�$��Medium"�$��
Montserrat)�
�������
 �����
�������$��0,0,0,1q�$��28��$��Center=�$��0,10,0,0q�$��20,0,0,0q����� *
Detalles+$	 TwoWay=�$
 PropertyChanged=�.������ $ /Images/write.png��$
 None=�$
 Left=�.���� $��3��$��2��.+��� -	    ��Name$ 	btnEditar��$��0q�$��EDITAR��
�������$��16(�$��
Montserrat)� � Cursor$
 Hand��$��0,5,0,0q����� *ModificarEquipoCommand+y��� *IsVisibleEditar+ �� 	Converter# [  ���� " ��.���  � �� �#462ad8 �� Triggers P�  P� Property �@J�IsMouseOver P� Value$
 True��. ���  � �� �#28aeed����  �� 
TargetType" ��.R��� $	��150��$��40�� �� CornerRadius$ 20��#��z��._��� $��Center=�$��Center=��� $��3��$��2��.+��� -
   $ 
btnGuardar��$��0q�$��GUARDAR��
�������$��16(�$��
Montserrat)�$
 Hand��$��0,5,0,0q����� *AgregarEquipoCommand+y��� *IsVisibleGuardar+# [  ���� " ��.���  � �� �#462ad8 P�  �@J�IsMouseOver$
 True��. ���  � �� �#28aeed���� " ��.R��� $	��150��$��40��$ 20��#��z��._��� $��Center=�$��Center=��� $��4��$��2��.+��� $��BUSCAR EQUIPO��
�������$��12(�$��Medium"�$��
Montserrat)��� -   $ 	txtBuscar��$��13(�$��Medium"�$��
Montserrat)�
�������
 �����
�������$��3q�$��28��$��Center=�$��20,0,0,0q�$ Upper=����� *Buscar+$	 TwoWay=�$
 PropertyChanged=�.������ $ /Images/magnifier.png��$
 None=�$
 Left=�.���� $��4��$��2��.+��� -   $ 	btnBuscar��$��0q�$��BUSCAR��
�������$��16(�$��
Montserrat)�$
 Hand��$��0,1,0,0q����� *BuscarEquipoCommand+���� " ��.���  � �� �#462ad8 P�  �@J�IsMouseOver$
 True��. ���  � �� �#28aeed���� " ��.R��� $	��150��$��40��$ 20��#��z��._��� $��Center=�$��Center=��� $��5��$��3��.+�&   System.Windows.Controls.DataGrid     AutoGenerateColumns$ False��   CanUserAddRows$ False������ *
EquipoList+$	 TwoWay=�$
 PropertyChanged=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ID��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *PK_TBL_INVE_EQUIPO+  $ 
ID Sistema��$ *  �� *
ID_SISTEMA+  $ Tipo de equipo��$ *  �� *TIPO_EQUIPO+  $ Marca��$ *  �� *MARCA+  $ Serie��$ *  �� *SERIE+  $ Modelo��$ *  �� *MODELO+  $ Estado��$ *  �� *ESTADO+  $ Activo��$ *  �� *ACTIVO+  $ Detalles��$ *  �� *
DETALLES+4  .System.Windows.Controls.DataGridTemplateColumn  $ *    CellTemplate �� .R��� $��Editar������ *DataContext.PruebaCommand+  �� RelativeSource  �� ! �� AncestorType"!  ���� " �� Path$" .�  �� *  $System.Windows.Controls.DataGridCell"!  ���� " ��.���  � �� �#462ad8 P�  �@J�IsMouseOver$
 True��. ���  � �� �#28aeed  $ *  �� .R��� $��Eliminar������ *#!DataContext.EliminarEquipoCommand+  �� "!  ���� $" .�  �� "!  ���� " ��.���  � �� �#462ad8 P�  �@J�IsMouseOver$
 True��. ���  � �� �#28aeed  =  7System.Windows.Controls.Primitives.DataGridColumnHeader  panelActiveColor  
panelColor��%�   '        7  '  g     7  �� "  .���  � ��8   ��  � ��
 �������  � ��$ Medium"���  � ��$ 14(��� "  .���  � ��8   ��  � ��
 �������  � ��$ Medium"���  � ��$ 15(�