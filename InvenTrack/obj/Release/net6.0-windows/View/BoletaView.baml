   M S B A M L   `   `   `  ���� E  AInvenTrack, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:InvenTrack.ViewInvenTrack.View       InvenTrack.View.BoletaView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:InvenTrack.View     X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp    � 	Resources      BooleanToVisibilityConverter �� 
TargetType �� Property �� Value��%�   &	        '��      �� �� " ��.���  � ��
 ���� ��  � ��
 �   ���  � ��$ Medium"���  � ��$ 15(�.���� .���  � ColumnDefinitions �� �� ��  � RowDefinitions �� $��* ��� $��45 ��� $
��55.5 ��� $
��55.5 ��� $
��55.5 ��� $
��55.5 ��� $
��55.5 �.+��� $��0��$��3��$��0,0,0,20q�.+�&   System.Windows.Controls.DataGrid  -     Name$ 
dgdBoletas��   AutoGenerateColumns$ False��   CanUserAddRows$ False��$��Center=����� *
BoletaList+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ID��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *PK_TBL_INVE_BOLETA+  $ 	Ubicacion��$ *  �� *	UBICACION+  $ Departamento��$ *  �� *DEPARTAMENTO+  $ 
Asignado a��$ *  �� *
ASIGNADO+  $ Fecha��$ *  �� *FECHA+  $ Entregado por��$ *  �� *ENTREGADO_POR+  $ Recibido por��$ *  �� *RECIBIDO_POR+  $ Detalles��$ *  �� *DETALLE_MOVIMIENTO+4  .System.Windows.Controls.DataGridTemplateColumn  $ *    CellTemplate �� .R��� $��Editar������ *DataContext.PruebaCommand+ �� RelativeSource ��  �� AncestorType"  ����  �� Path$ .� �� *  $System.Windows.Controls.DataGridCell"  ���� " ��.���  � �� �#462ad8 �� Triggers P�  P� Property �@J�IsMouseOver P� Value$
 True��. ���  � �� �#28aeed  $ *  �� .R��� $��Eliminar������ *#!DataContext.EliminarBoletaCommand+ �� "  ���� $ .� �� "  ���� " ��.���  � �� �#462ad8 P�  �@J�IsMouseOver$
 True��. ���  � �� �#28aeed  $ *  �� .R��� $	��Ver������ *DataContext.Prueba3Command+ �� "  ���� $ .� �� "  ���� " ��.���  � �� �#462ad8 P�  �@J�IsMouseOver$
 True��. ���  � �� �#28aeed  =  7System.Windows.Controls.Primitives.DataGridColumnHeader  panelActiveColor  
panelColor��%�   '        7  '  g     7  �� "  .���  � ��8   ��  � ��
 �������  � ��$ Medium"���  � ��$ 14(��� "  .���  � ��8   ��  � ��
 �������  � ��$ Medium"���  � ��$ 15(�� -    �Name$ print��
�������$��0��$��3��$��0,0,0,20q�y��� *IsVisibleBoleta+ �� 	Converter# [   �� $	��120 ��� $	��400 ��� $	��200 �.+��� $��30q�$��0��.+��  �� �� .+��� $��0��.+��� $��
FORMULARIO��$��Center=�$��35(�$
��Bold"�
���   ��� $��Movimiento De Equipos��$��11(�$��Medium"�
���   ��� $��1��.+���  �� Orientation$ 
Horizontal=�.+��� $��	# BOLETA:��$��Center=�$��25(�$
��Bold"�
���   ��� $��25(�$��DemiBold"�
���   ����� *Id+�� $ 
Horizontal=�.+��� $��Ingreso al Inventario��$��15(�$��Medium"�
���   ��� $��10(�$��
2.5,5,15,0q�$��DemiBold"�!	  FontAwesome.Sharp.IconImage	  �
  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]] 
  Icon$ Square=�$��15���� $��Digitalizada��$��15(�$��Medium"�
���   ��� $��10(�$��
2.5,5,15,0q�$��DemiBold"�	  $ Square=�$��15���� $��1��$��Stretch=�$��20q�.+�� $��Stretch=� �� $��1* ��� $��1* �.+��� $��0��$��10q�.+��� $��DATOS GENERALES��$��20(�$��5q�$��Medium"��� $ 
Horizontal=�.+��� $��Ubicación:��$��12(�$��5q�$
��Bold"��� $��12(�$��5q�$��DemiBold"����� *	Ubicacion+�� $ 
Horizontal=�.+��� $��Dpto. / Área:��$��12(�$��5q�$
��Bold"��� $��12(�$��5q�$��DemiBold"����� *Departamento+�� $ 
Horizontal=�.+��� $��Equipo Asignado a:��$��12(�$��5q�$
��Bold"��� $��12(�$��5q�$��DemiBold"����� *
Asignado+�� $��1��$��10q�.+��� $��TIPO DE MOVIMIENTO��$��20(�$��5q�$��Medium"��� $ 
Horizontal=�.+��� $��Entrega:��$��12(�$��5q�$
��Bold"��� $��10(�$��5q�$��DemiBold"�	  $ Square=�$��20���� $ 
Horizontal=�.+��� $��Retiro:��$��12(�$��5q�$
��Bold"��� $��10(�$��5q�$��DemiBold"�	  $ Square=�$��20���� $ 
Horizontal=�.+��� $��Fecha:��$��12(�$��5q�$
��Bold"��� $��12(�$��5q�$��DemiBold"����� *FechaSeleccionada+� $��
10 30 10 0q� �� $��3* ��� $��1* ��� $��1* ��� $��1* �.+��� $��DESCIPCION DE EQUIPOS��$��0��$��15(�$
��Bold"��� 
���   �$��1��$	��5 2q� J� Opacity$	 0.5Q�  $ False��$ False������ *
EquipoList+$	 TwoWay=�$
 PropertyChanged=�   $ 
ID Sistema��$ *  �� *
ID_SISTEMA+  $ Tipo de equipo��$ *  �� *TIPO_EQUIPO+  $ Serie��$ *  �� *SERIE+  $ Modelo��$ *  �� *MODELO+  $ Activo��$ *  �� *ACTIVO+  $ Detalles��$ *  �� *
DETALLES+  $ *  �� .R��� $��Eliminar������ *" DataContext.RemoveDetalleCommand+ �� "  ���� $ .� �� "  y��� *IsVisibleDetalleEliminar+# [  ���� " ��.���  � �� �#462ad8 P�  �@J�IsMouseOver$
 True��. ���  � �� �#28aeed�� $��2��$
��20 0q�.+�� $��
10 20 10 0q� �� $��1* ��� $��1* ��� $��1* �.+��� $��DETALLES DEL MOVIMIENTO:��$��0��$��12(�$
��Bold"��� $��1��$��2��$��12(�$��DemiBold"�$
��Left=����� *
Detalles+�� 
���   �$��1��$��5q�$	 0.5Q�� $��10q� �� $��1* ��� $��1* ��� $��1* �.+��� $��0��.+��� $ 
Horizontal=�.+��� $��Entregado por:��$��10(�$��5q��� $��10(�$��5q�$��DemiBold"����� *EntregadoPor+�� $ 
Horizontal=�.+��� $��Firma:��$��10(�$��5q��� $�� ��$��10(�$��5q�$��DemiBold"��� $��2��.+��� $ 
Horizontal=�.+��� $��Recibido por:��$��10(�$��5q��� $��10(�$��5q�$��DemiBold"����� *RecibidoPor+�� $ 
Horizontal=�.+��� $��Firma:��$��10(�$��5q��� $�� ��$��10(�$��5q�$��DemiBold"��� 
���   �$��1��$��5q�$	 0.5Q��� $��1��$��2��.+��� $��BUSCAR BOLETA��
�������$��12(�$��Medium"�$��
Montserrat)��� -    ��Name$ 	txtBuscar��$��13(�$��Medium"�$��
Montserrat)�
������� �� 
CaretBrush
 �����
�������$��3q�$��28��$��Center=�$��20,0,0,0q� �� CharacterCasing$ Upper=����� *Buscar+$	 TwoWay=�$
 PropertyChanged=�.������  �� ImageSource$ /Images/magnifier.png�� j� Stretch$
 None=�  j� 
AlignmentX$
  Left=�.���� $��1��$��2��.+��� -   ! ��Name$! 	btnBuscar��$��0q�$��BUSCAR��
�������$��16(�$��
Montserrat)�" � Cursor$
" Hand��$��0,1,0,0q����� *BuscarBoletaCommand+���� " ��.���  � �� �#462ad8 P�  �@J�IsMouseOver$
 True��. ���  � �� �#28aeed���� # �� 
TargetType"# ��.R��� $	��150��$��40��$ �� CornerRadius$$ 20��#��z��._��� $��Center=�$��Center=��� $��2��$��0��.+��� $��DEPARTAMENTO��
�������$��12(�$��Medium"�$��
Montserrat)��� -   $ txtDepartamento��$��13(�$��Medium"�$��
Montserrat)�
�������
 �����
�������$��0,0,0,1q�$��28��$��Center=�$��0,10,0,0q�$��20,0,0,0q�$ Upper=����� *Departamento+$	 TwoWay=�$
 PropertyChanged=�.������ $ /Images/write.png��$
 None=�$
  Left=�.���� $��2��$��1��.+��� $��ASIGNADO��
�������$��12(�$��Medium"�$��
Montserrat)��� -   $ txtAsignado��$��13(�$��Medium"�$��
Montserrat)�
�������
 �����
�������$��0,0,0,1q�$��28��$��Center=�$��0,10,0,0q�$��20,0,0,0q�$ Upper=����� *
Asignado+$	 TwoWay=�$
 PropertyChanged=�.������ $ /Images/write.png��$
 None=�$
  Left=�.���� $��2��$��2��.+��� $��FECHA��
�������$��12(�$��Medium"�$��
Montserrat)�(  "System.Windows.Controls.DatePicker  -   %  Name$% txtFecha��$��13(�$��Medium"�$��
Montserrat)�
���   �
�������$��0,0,0,1q�$��28��$��Center=�$��0,10,0,0q�$��20,0,0,0q�&   SelectedDate& �� *FechaSeleccionada+�� $��3��$��0��.+��� $��	UBICACION��
�������$��12(�$��Medium"�$��
Montserrat)��� -   $ txtUbicacion��$��13(�$��Medium"�$��
Montserrat)�
�������
 �����
�������$��0,0,0,1q�$��28��$��Center=�$��0,10,0,0q�$��20,0,0,0q�$ Upper=����� *	Ubicacion+$	 TwoWay=�$
 PropertyChanged=�.������ $ /Images/write.png��$
 None=�$
  Left=�.���� $��3��$��1��.+��� $��ENTREGADO POR��
�������$��12(�$��Medium"�$��
Montserrat)��� -	   $ txtEntregadoPor��$��13(�$��Medium"�$��
Montserrat)�
�������
 �����
�������$��0,0,0,1q�$��28��$��Center=�$��0,10,0,0q�$��20,0,0,0q�$ Upper=����� *EntregadoPor+$	 TwoWay=�$
 PropertyChanged=�.������ $ /Images/write.png��$
 None=�$
  Left=�.���� $��3��$��2��.+��� $��RECIBIDO POR��
�������$��12(�$��Medium"�$��
Montserrat)��� -
   $ txtRecibidoPor��$��13(�$��Medium"�$��
Montserrat)�
�������
 �����
�������$��0,0,0,1q�$��28��$��Center=�$��0,10,0,0q�$��20,0,0,0q�$ Upper=����� *RecibidoPor+$	 TwoWay=�$
 PropertyChanged=�.������ $ /Images/write.png��$
 None=�$
  Left=�.���� $��4��$��3��.+��� $��DETALLES��
�������$��12(�$��Medium"�$��
Montserrat)��� -   $ txtDetalles��$��13(�$��Medium"�$��
Montserrat)�
�������
 �����
�������$��0,0,0,1q�$��28��$��Center=�$��0,10,0,0q�$��20,0,0,0q����� *
Detalles+$	 TwoWay=�$
 PropertyChanged=�.������ $ /Images/write.png��$
 None=�$
  Left=�.���� $��5��$��2��y��� *IsVisibleEquipos+# [  .+��� $��EQUIPOS��
�������$��12(�$��Medium"�$��
Montserrat)��� -   ' ��Name$' 
txtEquipos��$��13(�$��Medium"�$��
Montserrat)�
���   �
�������$��0,0,0,1q�$��28��$��Center=�$��0,10,0,0q�$��20,0,0,0q�( �� 
IsEditable$
( True��) �� IsTextSearchEnabled$
) True��* w� TextPath$* 
ID_SISTEMA������ *	Equipos++ �� SelectedItem+ �� *EquipoSeleccionado+���� .R��� $ 
Horizontal=�.+��� $��0,0,5,0q����� *
ID_SISTEMA+�� $��0,0,5,0q����� *TIPO_EQUIPO+�� ���� *SERIE+�� $��5��$��2��.+��� -   $! btnCrear��$��0q�$��CREAR��
�������$��16(�$��
Montserrat)�$
" Hand��$��0,5,0,0q����� *CrearBoletaCommand+y��� *IsVisibleCrear+# [  ���� " ��.���  � �� �#462ad8 P�  �@J�IsMouseOver$
 True��. ���  � �� �#28aeed���� "# ��.R��� $	��150��$��40��$$ 20��#��z��._��� $��Center=�$��Center=��� $��5��$��2��.+��� -   $! btnModificar��$��0q�$��	MODIFICAR��
�������$��16(�$��
Montserrat)�$
" Hand��$��0,5,0,0q����� *ModificarBoletaCommand+y��� *IsVisibleModificar+# [  ���� " ��.���  � �� �#462ad8 P�  �@J�IsMouseOver$
 True��. ���  � �� �#28aeed���� "# ��.R��� $	��150��$��40��$$ 20��#��z��._��� $��Center=�$��Center=��� $��5��$��2��.+��� -   $! 	btnCerrar��$��0q�$��CERRAR��
�������$��16(�$��
Montserrat)�$
" Hand��$��0,5,0,0q����� *CerrarBoletaCommand+y��� *IsVisibleCerrar+# [  ���� " ��.���  � �� �#462ad8 P�  �@J�IsMouseOver$
 True��. ���  � �� �#28aeed���� "# ��.R��� $	��150��$��40��$$ 20��#��z��._��� $��Center=�$��Center=��� $��5��$��2��y��� *IsVisibleAgregar+# [  .+��� -   $! 
btnAgregar��$��0q�$��AGREGAR��
�������$��16(�$��
Montserrat)�$
" Hand��$��0,5,0,0q����� *AgregarBoletaCommand+���� " ��.���  � �� �#462ad8 P�  �@J�IsMouseOver$
 True��. ���  � �� �#28aeed���� "# ��.R��� $	��150��$��40��$$ 20��#��z��._��� $��Center=�$��Center=��� $��6��$��1��$��Center=�$��Center=�.+��� -   $��Right=�$��10q�$	��Top=����� *CerrarBoletaCommand+.��	  $ Print=�$��20��