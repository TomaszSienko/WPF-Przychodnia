   M S B A M L   `   `   `  ����M  IPrzychodnia_App_v1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Przychodnia_App_v1.WindowsPrzychodnia_App_v1.Windows  5   	   -    'Przychodnia_App_v1.Windows.Login_Window   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Przychodnia_App_v1.Windows     5   	   -   5          � WindowStyle$
  None=�5   	    � 
ResizeMode$ NoResize=�5
   	   
������  � AllowsTransparency$
 True��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ 	Logowanie��5   	   $	��482��6   $	��802��6(    J� Opacity$
 0.96Q�64   .��5      ��  �� CornerRadius$ 50��6   $
 0.98Q�6   $��318,167,226,70q�6.   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      � 	 � Color$	 	#FFB4B7C2��6   
 � Offset$
 0.608Q�61   � 5      $	 	#FF6C7CBD��6   $
 1Q�61   5      ._�5   
   � $��
266,0,10,0q�6   .+�5      �� -   5         ��Name$ B_Window_Minimize��5      $��-��60   $
��Left=�6<   $��19��6W   $��
-93,17,0,0q�6c   $	��Top=�6w   $��21��6�   ���	#FF24AEB9���	#FF9CEAE4
������� J� RenderTransformOrigin$ -1.942,1.001&�6�   �� 5      -   5        $ B_Window_Close��5      $��X��6-   $
��Left=�69   $��19��6T   $��
-67,17,0,0q�6`   $	��Top=�6t   $��21��6�   ���	#FFF38F8F
����������	#FFE29B9B$ -2.521,1.994&�6�   �� 5      $��	Logowanie��6   $
��Left=�6(   $��33��6C   $	��Top=�6O   $	��116��6g   $��Franklin Gothic Book)�6s   $��20(�6�   $��
-198,9,0,0q�6�   ���	#FF5872DE6�   �� 5      -   5         ��Name$ B_LoginInput��5      $
��Left=�6,   $��27��6G   $��-220,83,0,0q�6S    �� TextWrapping$
 Wrap=�6h   $	��Top=�6|   $	��168��6�   ���	#FFF7F7F7$��Franklin Gothic Book)�6�   $��14(�6�   .��6�   ��5      �� 5      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5      � $	 Black��6'   � 5      $	 	#FF9B5DC8��6'   $
 1Q�69   5      .��5    &   5!      G� 5"      -   5         G�Name$ B_PasswordInput��5"      $
��Left=�63   $��27��6N   $��-220,146,0,0q�6Z   $	��Top=�6p   $	��168��6�   
�������$��Franklin Gothic Book)�6�   $��14(�6�   ��5#      �� 5$      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5%      � $	 Black��6'   � 5&      $	 	#FF9B5DC8��6'   $
 1Q�69   5'      5)      �� 5*      $��Wprowadź login:��6   $
��Left=�6.   $��31��6I   $��-194,58,0,0q�6U   $	��Top=�6j   $	��108��6�   $��14(�6�   $��Franklin Gothic Book)�6�   
�������6�   �� 5+      $��Wprowadź hasło:��6   $
��Left=�6.   $��26��6I   $��-190,120,0,0q�6U   $	��Top=�6k   $	��108��6�   $��14(�6�   
�������$��Franklin Gothic Book)�6�   �� 5,      -   5        $ B_TryLog��5,      $��
Zatwierdź��6'   $
��Left=�6;   $��23��6V   $��-220,192,0,0q�6b   $	��Top=�6x   $	��168��6�   
���������5-      �� 5.      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5/      � $	 	#FF3ABBA6��6'   $
 0.111Q�69   � 50      $	 	#FF4D0482��6'   $
 0.899Q�69   � 51      $	 	#FF51CEBA��6'   $
 0.114Q�69   52      54      56      57      58      