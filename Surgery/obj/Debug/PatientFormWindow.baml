   M S B A M L   `   `   `  ����B  >Surgery, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:SurgerySurgery  5   	       Surgery.PatientFormWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Surgery     5   	     � Title$  PatientFormWindow��5   	   $��400.882��6#   $��293.277��64   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��24* �6   �� 5      $
��245* �6   .+�5   
   �� $��Patient name:��6   $
��Left=�6(   $��	10,41,0,0q�6C   $	��Top=�6V   $��1��6n   �� 5   
   $
��Left=�6   $��23��6.   $��
107,44,0,0q�6:    �� TextWrapping$
 Wrap=�6N   $	��Top=�6�   $	��166��6�   $��1��6�   ��6b   �� *Patient.Name+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��BirthPlace:��6   $
��Left=�6&   $��	10,90,0,0q�6A   $	��Top=�6T   $��1��6l   �� 5   
   $
��Left=�6   $��23��6-   $��
107,90,0,0q�69   $
 Wrap=�6M   $	��Top=�6�   $	��166��6�   $��1��6�   ��6a   �� *Patient.BirthPlace+$ PropertyChanged=�6�   �� 5   
   $��Date of birth:��6   $
��Left=�6)   $��
10,130,0,0q�6D   $	��Top=�6X   $��1��6p   (  "System.Windows.Controls.DatePicker  5   
   $
��Left=�6   $��107,132,0,0q�60   $��1��6E   $	��Top=�6R   $	��166��6j      Text 6v   �� *Patient.BirthDate+$ PropertyChanged=��� 5   
   $
��TAJ:��6   $
��Left=�6   $��
10,170,0,0q�6:   $	��Top=�6N   $��1��6f   �� 5   
   $
��Left=�6   $��23��6-   $��107,173,0,0q�69   $
 Wrap=�6N   $	��Top=�6�   $	��166��6�   $��1��6�   ��6b   �� *Patient.TAJ+$ PropertyChanged=�6�   �� 5   
   -   5        $��Mentés��5      $
��Left=�6"   $��107,233,0,0q�6=   $��1��6R   $	��Top=�6_   $��75��6w   6�   5      5      