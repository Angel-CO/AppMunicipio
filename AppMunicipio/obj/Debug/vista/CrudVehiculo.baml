   M S B A M L   `   `   `  ����G  CAppMunicipio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AppMunicipio.vistaAppMunicipio.vista  5   	   %    AppMunicipio.vista.CrudVehiculo   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:AppMunicipio.vista     5   	     � Title$  CrudVehiculo��5   	   $	��450��6   $
��1100��6+   .��5	      �  � RowDefinitions 5
   
   �� 5      $��70 �6   �� 5      $��50 �6   �� 5      $��* �6   .+�5   
   � ���#353535$��0��6$   .+�5      �� -   5         ��Name$ btnCancelar��5      $��Cancelar��5      $��Center=�5      $
��Left=�5      $��10,0,0,0q�5      $��30��5      $��70��5      
���  ��
�������5   (   �� 5      $��Lista de vehiculos��6   $��Center=�5      $��0,0,0,0q�5      $��Center=�5      $��Bell MT)�5      
�������$��24(�5      $
��Bold"�6"   �� 5       $��/images/logoSSP.png��6   $��Right=�5!      5"      � 5#   
   $��1��6   .+�5$      ��  �� Orientation$ 
Horizontal=�5%      $��Center=�5&      $��Center=�5'      .+�5(      �� -   5        $ 
btnAgregar��5(      $��Agregar��5)      $��0,0,10,0q�5*      $��60��5+      6$   �� 5,      -   5        $ btnModificar��5,      $��	Modificar��5-      $��0,0,10,0q�5.      $��60��5/      {�.  50   +   �� 51      -   5        $ btnEliminar��51      $��Eliminar��52      $��60��53      {�.  54   +   55      56      �� 58   
   -   5         ��Name$ lvVehiculos��58      $��2��6(   $��10q�65   $��0��6A    �� View 59      �� 5:      .P�5;      �� $��Marca��6%    �� Width$	 100��64    �� DisplayMemberBinding 5<   %   �� *Marca+�� 5=      $��Modelo��6%   $	 150��65    5>   %   �� *Modelo+�� 5?      $
��Año��6%   $ 50��62    5@   %   �� *Anio+�� 5A      $��Color��6%   $	 120��64    5B   %   �� *Color+�� 5C      $��Placas��6%   $	 120��65    5D   %   �� *
NumPlaca+�� 5E      $��Aseguradora��6%   $	 150��6:    5F   %   �� *NombreAseguradora+�� 5G      $��
No. Poliza��6%   $	 150��69    5H   %   �� *NumPolizaSeguro+�� 5I      $��	Conductor��6%   $	 200��68    5J   %   �� *NombreConductor+5K      5M      5N      5P      