   M S B A M L   `   `   `  ����G  CAppMunicipio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AppMunicipio.vistaAppMunicipio.vista  5   	   *    $AppMunicipio.vista.HistorialReportes   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:AppMunicipio.vista     5   	     � Title$  HistorialReportes��5   	   $	��450��6#   $	��900��60   .��5	      �  � RowDefinitions 5
   
   �� 5      $��50 �6   �� 5      $��60 �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   � ���#353535$��0��6$   .+�5      �� -   5         ��Name$ btnCancelar��5      $��Cancelar��5      $��Center=�5      $
��Left=�5      $��10,0,0,0q�5      $��30��5      $��70��5      
���  ��
�������5   (   5      � 5   
   $��0��6   .+�5      �� $��Historial de reportes��6   
�������$��Center=�6G   $��0,10,0,0q�6b   $��Center=�6t   $��Bell MT)�6�   $��24(�6�   $
��Bold"�6�   �� 5      $��/images/logoSSP.png��6   $��Right=�61   5      �� 5   
   $��1��5        �� Orientation$ 
Horizontal=�5!      $��Center=�5"      $��Center=�5#      .+�5$      �� $��Center=�5%      $��Center=�5&      $��0,0,20,0q�5'      .+�5(      �� $��Estatus:��6   $��Bell MT)�5)      $��18(�6)   �� 5*      -   5         ��Name$ 	cbEstatus��5*      $	��120��5+      .@�5,      �� $��	Pendiente��6#   �� 5-      $��Dictaminado��6#   5.      5/      �� 50      $��Center=�51      $��Center=�52      $��0,0,20,0q�53      .+�54      �� $��Fecha:��6   $��Bell MT)�55      $��18(�6)   (  "System.Windows.Controls.DatePicker  56      -   5          Name$ dpFecha��56      57      �� 58      $��Center=�59      $��Center=�5:      $��0,0,20,0q�5;      .+�5<      �� $��Delegación:��6   $��Bell MT)�5=      $��18(�6)   �� 5>      -   5        $ cbDelegacion��5>      $	��180��61   5?      �� 5@      -   5        $ 
btnFiltrar��5@      $��Filtrar��5A      $��65��5B      $��20��5C      $��0,0,20,0q�5D      5E      �� 5F      -   5        $ btnMostrarTodo��5F      $��Mostrar todo��5G      $��80��5H      $��20��5I      $��	0,0,100,0q�5J      5K      �� 5L      -   5        $ btnLevantarReporte��5L      $��Levantar reporte��5M      $
��Auto��5N      $��20��5O      6!   5P      � 5R   
   $��2��6    � ColumnDefinitions 5S      �� 5T      $
��135* �6#   �� 5U      $
��311* �6#   .+�5W      �� -   5         ��Name$ 
lvReportes��5W      $��15q�6,   $��2��6e    �� View 5X      �� 5Y      .P�5Z      �� $��Folio��6)   	 �� Width$		 100��6c   
 �� DisplayMemberBinding
 68   �� *	IdReporte+6c   �� 5[      $��Fecha��6)   $		 100��6c   
 68   �� *	FechaHora+6c   �� 5\      $��Estatus��6)   $		 100��6c   
 6:   �� *	Estatus+6c   �� 5]      $��Delegación��6)   $		 300��6o   
 6=   �� *NombreDelegacion+6o   �� 5^      $��
Dirección��6)   $		 300��6p   
 6<   �� *DireccionSiniestro+6p   5_      5a      5b      �� 5d   
   $��3��6   $��Center=�5e      $��Center=�5f      $ 
Horizontal=�5g      .+�5h      �� -	   5        $ btnVerDetalles��5h      $��Ver detalles��5i      {�.  
�������
�������$��30��5m      $��80��5n      $��0,0,20,0q�5o      6'   5p      5q      5s      