   M S B A M L   `   `   `  ����V  RPatient_Registration_System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Patient_Registration_System.Views!Patient_Registration_System.Views  5   	   -    'Patient_Registration_System.Views.Staff   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:Patient_Registration_System.Views     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	     � Title$  Staff��5	   	   $	��500��6   $	��800��6$    � WindowStartupLocation$ CenterScreen=�60   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $
��2.5* �6   .+�5   
   �� ��5      �� 5       �� 
StartPoint$	 0 0&�6&    �� EndPoint$	 1 1&�67   .��5      �  � Color$ DarkBlue��6#    � Offset$ 0Q�64   � 5      $ DarkSlateBlue��6#   $ 1Q�69   5      ._�5      � .+�5      �� .+�5       �  � Points# �    -1��� ;X z ��
����=H�$��Center=�6O   
 �� Top$ 80��6l   $	��Top=�6|   � 5!      # �    -1 -1 Zb z ���
����=H�$��50 400q�6L   � 5"      # �    -1 �� �� z ���
����=H�$��200 250q�6N   � 5#      # �    -1������@x}��� 
����=H�$��250 0q�6M   5'      5*      5+      �� 5.   
   $��1��6   $	��480��6!   $	��Top=�6.   ��5/      �� 50      $	 1 0&�6&   $	 0 1&�67   .��51      � $ 	#FF6495ED��6#   $	 0.4Q�65   � 52      $ PaleTurquoise��6#   $ 1Q�69   53      ._�56      �� .+�57      �� $��Login as Staff��6      	TitleText#��[  62   
����  �$��10 25q�58   2   �� 5<      $��User Name :��6     
NormalText#��[ 6/   $
��Left=�6S   $��70 10 10 20q�6n   �� 5>      
���   �$��2q�6-   	 �� CornerRadius$	 5��5?      $
��70 7q�6*   ._�5A      �  5D      �� 5E      $
��auto �6/   �� 5F      $��* �6/   .+�5J      .  (MahApps.Metro.IconPacks.PackIconMaterial  
   Kind$
 Account=�60   
���   �$��20��5L   0   $��2q�6<   �� 5M      -   5         ��Name$ textUsername��5M   0    J� Opacity$	 0.8Q�6"   $��1��6F     textHint#��[ 5O   $   $��2q�6F   5R      5S      �� 5T      $��
Password :��6   #��[ 6.   $
��Left=�6R   $��70 10 10 20q�6m   �� 5V      
���   �$��2q�6-   $	 5��5W      $
��70 7q�6*   ._�5X      �  5Y      �� 5Z      $
��auto �6/   �� 5[      $
��325* �6/   �� 5\      $	��87* �6/   .+�5`        $
 Login=�60   
���   �$��20��5b   0   $��Center=�6<   $��Center=�6Y   G� 5c      -   5         G�Name$ txtPassword��5c   4   $	 0.8Q�6&   $��1��6I   $��2,2,2,2q�5d   $   $��2��65    G� PasswordChar$ *��6I   $��14(�6Z   5g      5h      �� 5i      $��Center=�6   $��Bottom=�6:   .+�5j      �� -   5        $��btn_submit1��5j      $��Submit��60     CircleButton1#��[ 5k   .   �� 5l      -   5         ��Name$ btn_submit1_Copy��5l      $��Sign Up��67   $	��-10q�6I   #��[ 5m   /   
����ح�6V   5p      5s      5v      �� 5x   
   $��0��6   .+�5y      �� -   5         ��Name$ myImage1��5y      $	��290��6&   $	��466��62   $7��1/Images/man-working-from-home-2722364-2261173.png��6?   $��Center=�6z   5z      �� 5}   
   $��0��6   .+�5      �� -   5          CircleButton2#��[ 5      $	 0.5Q�6<   $��20q�6J   $��70��6V   ���	#FF6495ED$
��Back��6x   $
��Left=�6�   $
��Bold"�6�   
���   �$��Center=�6�   $��5q�6�   5�      5�      5�      5�      