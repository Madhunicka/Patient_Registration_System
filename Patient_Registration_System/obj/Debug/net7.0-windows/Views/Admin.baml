   M S B A M L   `   `   `  ����V  RPatient_Registration_System, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Patient_Registration_System.Views!Patient_Registration_System.Views  5   	   -    'Patient_Registration_System.Views.Admin   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:Patient_Registration_System.Views     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	     � Title$  Admin��5	   	   $	��500��6   $	��800��6$    � WindowStartupLocation$ CenterScreen=�60   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $
��2.5* �6   .+�5   
   �� ��5      �� 5       �� 
StartPoint$	 0 0&�6&    �� EndPoint$	 1 1&�67   .��5      �  � Color$ DarkBlue��6#    � Offset$ 0Q�64   � 5      $ DarkSlateBlue��6#   $ 1Q�69   5      ._�5      � .+�5      �� .+�5!      �  � Points# �    -1��� ;X z ��
����=H�$��Center=�6O   
 �� Top$ 80��6l   $	��Top=�6|   � 5"      # �    -1 -1 Zb z ���
����=H�$��Center=�6L   	 �� Left$	 50��6i   $	 376��6z   $	��Top=�6�   � 5#      # �    -1 �� �� z ���
����=H�$��200 250q�6N   � 5$      # �    -1������@x}��� 
����=H�$��250 0q�6M   5(      5+      5.      �� 51   
   $��1��6   ��54      �� 55      $	 1 0&�6&   $	 0 1&�67   .��56      � $ 	#FF6495ED��6#   $	 0.4Q�65   � 57      $ PaleTurquoise��6#   $ 1Q�69   58      ._�5;      �� .+�5<      �� $��Login as Admin��6      	TitleText#��[  62   
����  �$��10 25q�5=   2   �� 5A      $��User Name :��6     
NormalText#��[ 6/   $
��Left=�6S   $��70 10 10 20q�6n   �� 5C      
���   �$��2q�6-   
 �� CornerRadius$
 5��5D      $
��70 7q�6*   ._�5F      �  5I      �� 5J      $
��auto �6/   �� 5K      $��* �6/   .+�5O      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ Account=�60   
���   �$��20��5Q   0   $��2q�6<   �� 5R      -   5         ��Name$ textUsername��5R   "   $��1��68    J� Opacity$	 0.7Q�6H     textHint#��[ 5T   $   $��2q�6F   5W      5X      �� 5Y      $��
Password :��6   #��[ 6.   $
��Left=�6R   $��70 10 10 20q�6m   �� 5[      
���   �$��2q�6-   $
 5��5\      $
��70 7q�6*   ._�5]      �  5^      �� 5_      $
��auto �6/   �� 5`      $
��325* �6/   �� 5a      $	��87* �6/   .+�5e        $ Login=�60   
���   �$��20��5g   0   $��Center=�6<   $��Center=�6Y   G� 5h      -   5         G�Name$ txtPassword��5h   &   $��1��6;   $	 0.7Q�6L   $��2,2,2,2q�5i   $   $��2��65    G� PasswordChar$ *��6I   $��14(�6Z   5l      5m      �� 5t      -   5        $��btn_submit1��5t      $��Submit��6,     CircleButton1#��[ 6=   $
��Bold"�5u   .   �� 5w      -   5         ��Name$ btn_submit1_Copy��5w      $��Sign Up��63   $	��-10q�6E   #��[ 5x      
���   �6T   5z      5|      �� 5}   
   $��0��6   .+�5~      �� -   5         ��Name$ myImage1��5~      $��0q�6&   $	��217��61   $	��476��6=   $#��/Images/girl-work-img-opt.png��6J   $��Center=�6q   5      �� 5�   
   $��0��6   .+�5�      �� -   5          CircleButton2#��[ 5�      $
��Back��6@   $
��Left=�6O   $��Center=�6l   5�      5�      5�      5�      