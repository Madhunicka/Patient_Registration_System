   M S B A M L   `   `   `  ����V  RPatient_Registration_System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Patient_Registration_System.Views!Patient_Registration_System.Views  5   	   3    -Patient_Registration_System.Views.StaffSignUp   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:Patient_Registration_System.Views     5   	     � Title$  StaffSignUp��5   	   $	��450��6   $
��1000��6*    � WindowStartupLocation$ CenterScreen=�67    � DataContext 5	      5   /Patient_Registration_System.Views.StaffSignUpVM  5
   
    � 	Resources 5         DataGridBackgroundBrush j� TileMode !� Visual J� Opacity �� Left
 �� Top��%�  &	        !� 5   
   $
 Tile=�66    5      �� 5      
����=H�$	��200��64   $	��200��6@   .+�5      A� $	 0.5Q�6   $��40��6,   $��40��67   
����  �$ 0��6S   $ 0��6c   A� 5      $	 0.5Q�6   $��25��6,   $��25��67   
����  �$ 30��6S   $ 40��6d   A� 5      $	 0.4Q�6   $��15��6,   $��15��67   
����  �$ 60��6S   $ 60��6d   A� 5      $	 0.5Q�6   $��12��6,   $��12��67   
����  �$ 83��6S   $ 64��6d   A� 5      $	 0.5Q�6   $��10��6,   $��10��67   
����  �$	 100��6S   $ 62��6e   A� 5      $	 0.5Q�6   $��40��6,   $��40��67   
����  �$	 100��6S   $	 157��6e   A� 5      $	 0.5Q�6   $��25��6,   $��25��67   
����  �$	 130��6S   $	 130��6e   A� 5      $	 0.5Q�6   $��15��6,   $��15��67   
����  �$	 160��6S   $	 120��6e   A� 5      $	 0.5Q�6   $��12��6,   $��12��67   
����  �$	 180��6S   $	 120��6e   5!      5#      5$      .��5%      � 	 � ColumnDefinitions	 5&   
   �� 5'      $��1* �6   �� 5(      $
��1.6* �6   .+�5+   
   �� $��2��6   $��	0,0,430,0q�6%   ��5,      �� 5-      
 �� 
StartPoint$	
 0 0&�6&    �� EndPoint$	 1 1&�67   .��5.      �  � Color$ DarkBlue��6#    � Offset$ 0Q�64   � 5/      $ DarkSlateBlue��6#   $ 1Q�69   51      ._�53      � .+�55      �� .+�58      �  � Points# �    -1��� ;X z ��
����=H�$��Center=�6O   $ 80��6l   $	��Top=�6|   � 59      # �    -1 -1 Zb z ���
����=H�$��50 400q�6L   � 5:      # �    -1 �� �� z ���
����=H�$��200 250q�6N   � 5;      # �    -1������@x}��� 
����=H�$��250 0q�6M   5?      5B      5C      &   System.Windows.Controls.DataGrid  5D   
   -   5        $��1��5D      #��[  6#      AutoGenerateColumns$ False��6�   $��37,0,0,0q�6�   ��6Z   �� *	Passwords+ �� SelectedItem 6|   �� *SelectedPerson+   Columns 5E      0  *System.Windows.Controls.DataGridTextColumn  5F      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5G      $ 
Staff Name��6%   $ * 6W    69   �� *	StaffName+6W      	CellStyle 5K      �� 5L       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6   .�5M      ��  �� Property � �� �� Value �#AFEEEE63   5N      5P      �� 5R   
   .+�5S      ��  �� Orientation$ 
Horizontal=�6   $��50��62   .+�5T      �� $�� Staff ID : ��6   ���#AFEEEE$��16(�6F    �� Padding$ 15q�6T   $	��149��6b   �� 5U      $	 0.8Q�6   $��16(�6(   $	��10 q�66   $��5q�6C   $	��200��6O   $��30��6o   ��6[   �� *Id+6o   5V      �� 5Z      $ 
Horizontal=�6   $��50��62   .+�5[      �� $��Staff Name :��6   ���#AFEEEE$��16(�6E   $ 15q�6S   $	��150��6a   �� 5\      $	 0.8Q�6   $��16(�6(   $��30��66   $��10q�6B   $��5q�6N   $	��202��6Z   ��6f   �� *	StaffName+5]      �� 5b      $ 
Horizontal=�6   $��50��62   .+�5c      �� $��User Name   : ��6   ���#AFEEEE$��16(�6G   $ 15q�6U   $	��148��6c   �� 5d      $	 0.8Q�6   $��30��6(   $��16(�64   $��10q�6B   $��5q�6N   $	��203��6Z   ��6f   �� *
UserName+5e      �� 5h      $ 
Horizontal=�6   $��50��62   .+�5i      �� $��Password : ��6   ���#AFEEEE$��16(�6D   $ 15q�6R   $	��148��6`   �� 5j      $	 0.8Q�6   $��30��6(   $��16(�64   $��10q�6B   $��5q�6N   $	��203��6Z   ��6f   �� *	Passwrd+5k      �� 5q      $ 
Horizontal=�6   $��10q�62   .+�5r      �  � RowDefinitions 5s      �� 5t      $��1* �6(   �� 5u      $��1* �6(   5w      �� 5x      $��0��6   $	��400��6*   .+�5y      �� -   5        $	��150��5y      $��40��6)   $��16)�65   $��5q�6E   $��10q�6Q   
����ح�
����  �$��Center=�6�   $
��Add ��5z      ��6    �� *InsertPersonCommand+6H   �� 5|      $N��HInsert a strong password with capital letter,simple letters and symbols ��6    $��40��6p   $	��430��6|   
�������6�   5�      5�      �� 5�      $ 
Horizontal=�6   $��50��62   5�      5�      5�      5�      