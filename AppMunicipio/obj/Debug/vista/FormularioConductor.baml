   M S B A M L   `   `   `  ����G  CAppMunicipio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AppMunicipio.vistaAppMunicipio.vista  5   	   ,    &AppMunicipio.vista.FormularioConductor   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:AppMunicipio.vista     5   	     � Title$  FormularioConductor��5   	   $	��450��6%   $	��800��62   .��5	      �  � RowDefinitions 5
   
   �� 5      $��70 �6   �� 5      $��* �6   �� 5      $��60 �6   .+�5   
   � ���#353535$��0��6$   .+�5      �� -   5         ��Name$ btnCancelar��5      $��Cancelar��5      $��Center=�5      $
��Left=�5      $��10,0,0,0q�5      $��30��5      $��70��5      
���  ��
�������5   (   �� 5      -   5         ��Name$ lbTitulo��5      $��Titulo��6&   $��Center=�5      $��0,0,0,0q�5      $��Center=�5      $��Bell MT)�5      
�������$��24(�5      $
��Bold"�6"   �� 5       $��/images/logoSSP.png��6   $��Right=�5!      5"      � 5#   
   $��1��6    � ColumnDefinitions 5$      �� 5%      $��* �6#   �� 5&      $��* �6#    5(      �� 5)      $��40 �6    �� 5*      $��40 �6    �� 5+      $��40 �6    �� 5,      $��40 �6    �� 5-      $��40 �6    �� 5.      $��40 �6    .+�50      �� $��0��6   $��0��6$   $��Nombre: ��51      $��Right=�52      $��Center=�53      �� 55      -   5         ��Name$ tbNombre��55      $��1��56      $��0��6*   $
��Left=�57      $��Center=�58      $��23��59      $	��200��6&    �� TextWrapping$
 Wrap=�5:      �� 5;      $��0��6   $��1��6$   $��Apellido paterno: ��5<      $��Right=�5=      $��Center=�5>      �� 5@      -   5        $ tbApellidoPaterno��5@      $��1��5A      $��1��6*   $
��Left=�5B      $��Center=�5C      $��23��5D      $	��200��6&   $
 Wrap=�5E      �� 5G      $��0��6   $��2��6$   $��Apellido materno: ��5H      $��Right=�5I      $��Center=�5J      �� 5L      -   5        $ tbApellidoMaterno��5L      $��1��5M      $��2��6*   $
��Left=�5N      $��Center=�5O      $��23��5P      $	��200��6&   $
 Wrap=�5Q      �� 5S      $��0��6   $��3��6$   $��Fecha nacimiento: ��5T      $��Right=�5U      $��Center=�5V      (  "System.Windows.Controls.DatePicker  5W      -   5          Name$ dpFecha��5W      $��1��5X      $��3��6)   $
��Left=�5Y      $��Center=�5Z         SelectedDate$ 1/1/2003X�5[      �� 5]      $��0��6   $��4��6$   $��Núm. de licencia: ��5^      $��Right=�5_      $��Center=�5`      �� 5b      -   5        $ tbNumLicencia��5b      $��1��5c      $��4��6*   $
��Left=�5d      $��Center=�5e      $��23��5f      $	��200��6&   $
 Wrap=�5g      	 �� 	MaxLength$	 12��5h      �� 5j      $��0��6   $��5��6$   $��Teléfono: ��5k      $��Right=�5l      $��Center=�5m      �� 5o      -   5        $ 
tbTelefono��5o      $��1��5q      $��5��6&   $
��Left=�5r      $��Center=�5s      $��23��5t      $	��200��6"   $
 Wrap=�5u      $	 10��5v      5x      � 5y   
   $��2��6   .+�5z      �� -	   5        $ 
btnGuardar��5z      $��Guardar��5{      $��60��5|      $��30��5}      6!   5~      5�      5�      