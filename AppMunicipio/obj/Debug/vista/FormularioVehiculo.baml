   M S B A M L   `   `   `  ����G  CAppMunicipio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:AppMunicipio.vistaAppMunicipio.vista  5   	   +    %AppMunicipio.vista.FormularioVehiculo   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:AppMunicipio.vista     5   	     � Title$  FormularioVehiculo��5   	   $	��470��6$   $	��800��61   .��5	      �  � RowDefinitions 5
   
   �� 5      $��60 �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   � ���#353535$��0��6$   .+�5      �� -   5         ��Name$ btnCancelar��5      $��Cancelar��5      $��Center=�5      $
��Left=�5      $��10,0,0,0q�5      $��30��5      $��70��5      
���  ��
�������5   (   �� 5      -   5         ��Name$ lbTitulo��5      $��Titulo��6&   $��Center=�5      $��0,0,0,0q�5      $��Center=�5      $��Bell MT)�5      
�������$��24(�5      $
��Bold"�6"   �� 5       $��/images/logoSSP.png��6   $��Right=�5!      5"      � 5#   
   $��1��6    � ColumnDefinitions 5$      �� 5%      $��* �6#   �� 5&      $��* �6#    5(      �� 5)      $��40 �6    �� 5*      $��40 �6    �� 5+      $��40 �6    �� 5,      $��40 �6    �� 5-      $��40 �6    �� 5.      $��40 �6    �� 5/      $��40 �6    �� 50      $��40 �6    .+�52      �� $��0��6   $��0��6$   $��
Conductor:��53      $��Right=�54      $��Center=�55      �� 56      -   5        $ lbConductor��56      $��1��57      $��0��6*   $
��Left=�58      $��Center=�59      $
��Auto��5:      $
��Auto��6(   �� 5<      $��0��6   $��1��6$   $��Marca:��5=      $��Right=�5>      $��Center=�5?      �� 5@      -   5         ��Name$ tbMarca��5@      $��1��5A      $��1��6*   $
��Left=�5B      $��Center=�5C      $��23��5D      $	��200��6&    �� TextWrapping$
 Wrap=�5E      �� 5G      $��0��6   $��2��6$   $��Modelo:��5H      $��Right=�5I      $��Center=�5J      �� 5K      -   5        $ tbModelo��5K      $��1��5L      $��2��6*   $
��Left=�5M      $��Center=�5N      $��23��5O      $	��200��6&   $
 Wrap=�5P      �� 5R      $��0��6   $��3��6$   $��Año:��5S      $��Right=�5T      $��Center=�5U      �� 5V      -   5        $ tbAnio��5V      $��1��5W      $��3��6*   $
��Left=�5X      $��Center=�5Y      $��23��5Z      $	��200��6&   $
 Wrap=�5[       �� 	MaxLength$ 4��5\      �� 5^      $��0��6   $��4��6$   $��Color:��5_      $��Right=�5`      $��Center=�5a      �� 5b      -   5        $ tbColor��5b      $��1��5c      $��4��6*   $
��Left=�5d      $��Center=�5e      $��23��5f      $	��200��6&   $
 Wrap=�5g      �� 5i      $��0��6   $��5��6$   $$��Nombre aseguradora (opcional):��5j      $��Right=�5k      $��Center=�5l      �� 5m      -   5        $ tbNombreAseguradora��5m      $��1��5n      $��5��6*   $
��Left=�5o      $��Center=�5p      $��23��5q      $	��200��6&   $
 Wrap=�5r      �� 5t      $��0��6   $��6��6$   $&�� No. poliza de seguro (opcional):��5u      $��Right=�5v      $��Center=�5w      �� 5x      -	   5        $ tbNumPolizaSeguro��5x      $��1��5y      $��6��6&   $
��Left=�5z      $��Center=�5{      $��23��5|      $	��200��6"   $
 Wrap=�5}      �� 5      $��0��6   $��7��6$   $��No. placas:��5�      $��Right=�5�      $��Center=�5�      �� 5�      -
   5        $ 
tbNumPlaca��5�      $��1��5�      $��7��6&   $
��Left=�5�      $��Center=�5�      $��23��5�      $	��200��6"   $
 Wrap=�5�      $ 7��5�      5�      � 5�   
   $��2��6   .+�5�      �� -   5        $ 
btnGuardar��5�      $��Guardar��5�      $��60��5�      $��20��5�      6!   5�      5�      5�      