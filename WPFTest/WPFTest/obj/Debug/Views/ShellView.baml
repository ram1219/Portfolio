   M S B A M L   `   `   `  ����U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  5   	   B >WPFTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WPFTest.HelpersWPFTest.Helpers 5   	   !clr-namespace:WPFTestWPFTest 5	   	      WPFTest.Views.ShellView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5   	   >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5   	   +Commonsclr-namespace:WPFTest.Helpers  5   	   !localclr-namespace:WPFTest  5	   	     � Icon$  ../sensor.ico��5
   	    � Title$  Photo Register��6    � 
ResizeMode$ NoResize=�5   	   $	��750��5   	   $	��600��6   $��10q�6"   .��5      �  � RowDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   �� 5      $��* �6   �� 5      $
��1.5* �6   �� 5      $��4* �6   �� 5      $
��0.7* �6    � ColumnDefinitions 5   
   �� 5      $
��0.9* �6   �� 5      $��3* �6   �� 5      $
��1.7* �6   .+�5   
   o� $��1��6   $��0��6   $��3��6,   $��5q�6@      MahApps.Styles.Menu#��[  5      ���#F1F3F5���#E9ECEF$��1q�5   :   .@�5       m� $��_시뮬레이션��6   ���#F1F3F5$��Center=�5!      .@�5"      m� -   5         m�Name$ BtnStart��5"      $��_시작��6-    m� Icon 5#      �� 5$      $��/Resources/start.png��6    $��18��6>   5&      m� 5'      -   5        $ BtnStop��5'      $��_정지��6,    5(      �� 5)      $��/Resources/stop.png��6    $��15��6=   5+      �� 5,      5-      m� 5.      $��
_도움말��6   ���#F1F3F5$��Center=�5/      .@�50      m� -   5        $ BtnInfo��50      $��_정보��6,    51      �� 52      $��/Resources/search.png��6    $��15��6?   54      �� 55      56      57      � 59   
   $��2��6   $��0��6   $��2��6,    5:      �� 5;      $	��96* �6#   �� 5<      $
��150* �6#   �� 5=      $	��71* �6#   �� 5>      $	��97* �6#   .+�5@      �� $��0��6   $��연결시간 : ��6(   $��Right=�5A      $��Center=�60   $��19��6K   $
��0,12q�6W   $��69��6e   �� 5B      $��2��6   $��연결갯수 : ��6(   $��Center=�5C      $��Center=�61   $��19��6L   $��	0,12,1,12q�6X   $��70��6k   �� 5F      -   5         ��Name$ TxtSensorTime��5F      $��1��5G      $��0,5,5,5q�6&     MahApps.Styles.TextBox#��[ 5H      
������� �� 
IsReadOnly . 5I      �� 5K      -   5        $ TxtSensorCount��5K      $��3��5L      $��0,5,5,5q�6&   #��[ 5M      
������� . 5N      5O      �� 5P   
   $��3��6   $��0��6!   $��포토레지스터 : ��61   $��Right=�5Q      $	��Top=�60   $	��0,5q�6H   � 5T   
   $��3��6   $��1��6    5U      �� 5V      $��* �6    �� 5W      $
��0.5* �6    .+�5Z      � -   5        	 �Name$	 	PrgSensor��5Z      $��0��5[      $��0,0,5,0q�6'   
 � Minimum$
 0Q�68    � Maximum$
 1023Q�6D     MahApps.Styles.ProgressBar#��[ 5\      
�������6N   �� 5]      -   5         ��Name$ TxtPrgValue��5]      $��1��5^      $
��10,0q�6%   $��Center=�5_      ��5^   3   ��  �� ElementName$ 	PrgSensor�� �� Path$ Value�5_      5`      �� 5c   
   -   5        $ RtbLog��5c      $��4��5d      $��0��6   $��2��6/   $��20,9,5,5q�6C   
���iii�
������� .  �� TextWrapping$
 Wrap=�5f   7    �� AcceptsReturn . %  WPFTest.Helpers.TextBoxBehavior   AutoScrollToEnd . $��Visible=�5h      � 5j   
   $��2��6   $��2��6   $��3��6,    5k      �� 5l      $
��0.5* �6    �� 5m      $
��0.6* �6    �� 5n      $
��0.6* �6    �� 5o      $
��1.5* �6    .+�5r      �� -	   5         ��Name$ CboSerialPort��5r      $��0��5s      $��3q�6$    �� SelectedItem 5r   .   �� *Selectedcboitem+5s   $   �� 5v      -
   5         ��Name$ 
BtnConnect��5v      $��1��5w      $��3q�6"   $��Connect��6-    ' #MahApps.Styles.Button.Square.Accent#��[ 5x      �� 5{      -   5        $ BtnDisconnect��5{      $��2��5|      $��3q�6"   $��
Disconnect��6-   #��[ 5}      � 5�      $��3��6     MahApps.Brushes.Accent#��[ 6    $��3q�6U   .+�5�      �� $��25(�6=   $
��Bold"�6K   
�������$��Center=�5�      $��Center=�69   ��5�      �� *PrintPortNumber+5�   9   5�      5�      � 5�   
   $��5��6   $��0��6   $��3��6,   $��5q�6@   .+�5�      #   LiveCharts.Wpf.CartesianChart  -   5          Name$ 
PrintGraph��5�   !   &    LiveCharts.Wpf.Charts.Base.Chart   Zoom$ X=�5�   ?      Series 6!   �� *
PrintGraph+   AxisX 5�         LiveCharts.Wpf.Axis  -   5          Name$ X��5�         Title$
 Time��6*      MinValue$ 1Q�67      MaxValue$	 100Q�6D      AxisY 5�        -   5        $ Y��5�      $ Value��6*   $ 0Q�68   $
 1500Q�6E   5�      5�      �� 5�   
   $��6��6   $��0��6!   $��3��61   $��Center=�5�      $��Center=�6/   $F��@마우스 휠을 이용하여 확대, 축소가 가능합니다.��5�      
�������$��20(�5�   $   5�      5�      