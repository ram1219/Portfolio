   M S B A M L   `   `   `  ����B  >WPFTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPFTest.ViewsWPFTest.Views  5   	       WPFTest.Views.InfoView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WPFTest.Views     5   	     � WindowStyle$
  None=�5   	    � WindowStartupLocation$ CenterOwner=�5	   	    � Title$
 Info��5
   	   $	��300��6   $	��500��6#   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��4* �6   �� 5      $
��1.5* �6    � ColumnDefinitions 5   
   �� 5      $
��0.7* �6   �� 5      $��* �6   �� 5      $
��0.5* �6   .+�5   
   �� $��0��6   $��0��6   $��6��6-   $��/Resources/images.png��6>   �� 5   
   -   5         ��Name$ AssemblyTitle��5      $��0��6+   $��1��68   $��5q�6I   $��제품 이름��5      $��13(�6!   
�������6/   �� 5    
   -   5        $ AssemblyVersion��5       $��1��6-   $��1��6:   $��5q�6K   $��버전��5!      $��13(�6   
�������6,   �� 5"   
   -   5        $ AssemblyCopyright��5"      $��2��6/   $��1��6<   $��5q�6M   $��	저작권��5#      $��13(�6   
�������6-   �� 5$   
   -   5        $ AssemblyCompany��5$      $��3��6-   $��1��6:   $��5q�6K   $��회사 이름��5%      $��13(�6!   
�������6/   �� 5'   
   -   5         ��Name$ AssemblyDescription��5'      $��4��6/   $��1��6<   $��2��6L   $��설명��5(      $��5q�6    �� TextWrapping$
 Wrap=�6'    �� 
IsReadOnly . $��Visible=�5)      �� 5+   
   -   5        	 ��Name$	 
BtnConfirm��5+      $��5��6%   $��3��62   $��확인��6B   $	��100��5,      $��Right=�6   $��5q�69    ,  (MahApps.Styles.Button.MetroSquare.Accent#��[  5-      
 �� IsCancel
 . 5.      50      51      