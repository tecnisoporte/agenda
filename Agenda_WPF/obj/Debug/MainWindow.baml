   M S B A M L   `   `   `  ����E  AAgenda_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Agenda_WPF
Agenda_WPF  5   	       Agenda_WPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Agenda_WPF     5   	     � Title$  
MainWindow��5   	   $	��362��6   $	��754��6)   .��5	      � $��
0,0,-48,-6q�6    � ColumnDefinitions 5
   
   �� 5      $
��545* �6   �� 5      $
��247* �6   .+�5   
   �� -   5         ��Name$$ titulo_de_la_aplicacion_AGENDA��5      $��AGENDA DE CONTACTOS ��68   $
��Left=�6W   $��	271,7,0,0q�6r   $	��Top=�6�   $��16(�6�   $
��Bold"�6�   $��Cooper Black)�6�   �� 5   
   -   5        $��BUSCAR��5      $
��Left=�6"   $��
390,60,0,0q�6=   $	��Top=�6Q   $��75��6i   6t   �� 5   
   -   5        $��Aceptar��5      $
��Left=�6#   $��
57,295,0,0q�6>   $	��Top=�6R   $��75��6j    J� RenderTransformOrigin$ 0.6,-2&�6u   $��1��6�   �� 5   
   -   5         ��Name$ textBoxBuscar��5      $
��Left=�6)   $��23��6D   $��
255,60,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5   
   $7��1Puedes buscar introduciendo 
nombre de contacto:��6   $
��Left=�6T   $��	75,49,0,0q�6o   $	��Top=�6�   $ 0.5,0.5&�6�   $��51��6�   $	��175��6�   $
��Bold"�6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.166Q�6&   T� 5      5      5      �� 5   
   $��Lista de contactos��6   $
��Left=�6-   $��
60,115,0,0q�6H   $	��Top=�6\   $
��Bold"�6t   �� 5   
   $��Agregar Nuevo Vontacto��6   $
��Left=�61   $��
395,95,0,0q�6L   $	��Top=�6`   $
��Bold"�6x   �� 5   
   -   5        $ textBoxNombre��5      $
��Left=�6)   $��23��6D   $��400,145,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��135��6�   4  .System.Windows.Automation.AutomationProperties   HelpText$ Escribir tu nombre��6�   �� 5   
   -   5        $ textBoxApellido��5      $
��Left=�6+   $��23��6F   $��
15,145,0,0q�6R   $
 Wrap=�6f   $��	Apellidos��6z   $	��Top=�6�   $	��117��6�   $��1��6�   �� 5    
   -   5        $ texBoxTwitter��5       $
��Left=�6)   $��23��6D   $��540,255,0,0q�6P   $
 Wrap=�6e   $��Twitter��6y   $	��Top=�6�   $	��135��6�   $��2��6�   �� 5!   
   -   5        $ textBoxTelefonoTrabajo��5!      $��Right=�62   $��23��6N   $��0,202,116,0q�6Z   $
 Wrap=�6o   $��Trabajo��6�   $	��Top=�6�   $��75��6�   $��1��6�   �� 5"   
   -	   5        $ textBoxMovil��5"      $
��Left=�6(   $��23��6C   $��400,202,0,0q�6O   $
 Wrap=�6d   $��Movil��6x   $	��Top=�6�   $��85��6�   6�   �� 5#   
   -
   5        $ texBoxEmail��5#      $
��Left=�6'   $��23��6B   $��400,255,0,0q�6N   $
 Wrap=�6c   $��Email��6w   $	��Top=�6�   $	��120��6�   �� 5$   
   -   5        $ texBoxTelefonoCasa��5$      $
��Left=�6.   $��23��6I   $��510,202,0,0q�6U   $
 Wrap=�6j   $
��Casa��6~   $	��Top=�6�   $��75��6�   $��2��6�   �� 5%   
   $��Datos del contacto��6   $
��Left=�6-   $��395,124,0,0q�6H   $	��Top=�6]   �� 5&   
   $��Telefonos de Contacto��6   $
��Left=�60   $��395,180,0,0q�6K   $	��Top=�6`   �� 5'   
   $��Redes ��6   $
��Left=�6!   $��395,230,0,0q�6<   $	��Top=�6Q   $ -0.263,0.192&�6i   �� 5(   
   $��Editar��6   $
��Left=�6"   $��305,295,0,0q�6=   $	��Top=�6R   $��75��6j   &   System.Windows.Controls.DataGrid  5)   
   -   5          Name$ dataGrid��5)      $
��Left=�6%   $	��140��6@   $��
40,140,0,0q�6M   $	��Top=�6a   $	��340��6y   {�.  6�   5+      5,      