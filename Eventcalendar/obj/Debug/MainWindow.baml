   M S B A M L   `   `   `  ����H  DEventcalendar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:EventcalendarEventcalendar  5   	       Eventcalendar.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Eventcalendar     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   &   System.Windows.Controls.Calendar  -   5          Name$ calendar��5      $
��Left=�6&   $��10,0,0,0q�6A   $��Center=�6S   $��2��6n   $	��154��6�   $��2��6�   $	��180��6�   $��6��6�   �� 5   
   -   5         ��Name$ t1��5      $��6��6    $��2��60   $
��Left=�6D   $��	46,10,0,0q�6_   $
��Wrap=�6r   $��TextBox��6�   $	��Top=�6�   $	��108��6�   $��20��6�   $��2��6�   �� 5   
   -   5        $��6��5      $��Button��6!   $��
80,43,80,0q�62   $	��Top=�6F   $��2��6s   $��2��6�    � 5   
   -   5          �Name$ Page1��5        � NavigationUIVisibility$ Hidden=�6   $��6��6?   $��
10,10,0,10q�6S   $��5��6g    � 5   
   -   5        $ Page2��5      $ Hidden=�6   $��7��6?   $��	0,0,95,10q�6S   $��5��6f   �� 5    
   -   5         ��Name$	 nap��5       $��6��6   $��2��6/   $
��Left=�6C   $��	64,10,0,0q�6^   $��3��6q    �� TextWrapping$
 Wrap=�6~   $��TextBox��6�   $	��Top=�6�   $	��120��6�   �� 5!   
   -   5        $	 vav��5!      $��6��6   $
��Left=�6/   $��	64,44,0,0q�6J   $��3��6]   $
 Wrap=�6j   $��TextBox��6~   $	��Top=�6�   $	��120��6�   $��2��6�   5"      5#      