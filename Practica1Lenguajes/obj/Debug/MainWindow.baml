   M S B A M L   `   `   `  ����M  IPractica1Lenguajes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Practica1LenguajesPractica1Lenguajes  5   	   #    Practica1Lenguajes.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Practica1Lenguajes     5   	     � Title$  
MainWindow��5   	   $��299.405��6   $��677.381��6-   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5
      $
��Left=�6%   $��
416,44,0,0q�6@   $	��Top=�6T   $	��216��6l   $	��202��6y      MinColumnWidth$	 100Q�6�      MaxColumnWidth$	 200Q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Lexema��6i   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *nombreLexema+   ClipboardContentBinding 6F   Z� 6i     5      $ 
Componente��6g    6%   �� *
tipoLexema+ 6D   Z� 6g   5      �� 5   
   -   5         ��Name$ label��5      $��Ingrese el Texto��6   $
��Left=�6:   $��	49,17,0,0q�6U   $	��Top=�6h   �� 5   
   -   5        	 ��Name$	 button��5      $��Revisar��6!   $
��Left=�63   $��
49,153,0,0q�6N   $	��Top=�6b   $	��113��6z   
 J� RenderTransformOrigin$
 0.477,-0.414&�6�   $��37��6�   6�   �� 5   
   -   5         ��Name$ textBox��5      $	��100��6#   $��49,48,363.2,0q�60    �� TextWrapping$
 Wrap=�6G   $	��Top=�6[   5      5      