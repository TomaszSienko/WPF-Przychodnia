   M S B A M L   `   `   `  ���� M  IPrzychodnia_App_v1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Przychodnia_App_v1Przychodnia_App_v1  /    )Przychodnia_App_v1.Windows.Patient_Window   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:Przychodnia_App_v1     -     � WindowStyle$
  None=� � 
ResizeMode$ NoResize=�
������  � AllowsTransparency$
 True�� � WindowStartupLocation$ CenterScreen=� � Title$ Patient_Window��$	��488��$	��805�� J� Opacity$
 0.99Q�.����  �� CornerRadius$ 50��$
 0.98Q�$��
0,10,-21,0q����	#FFB4C2E6._�� $��
10,0,10,10q�.+��� $��Imie:��$
��Left=�$��26��$��
204,86,0,0q�$	��Top=�$��47��
��������� $��	Nazwisko:��$
��Left=�$��26��$��204,112,0,0q�$	��Top=�$��62��
��������� $��PESEL:��$
��Left=�$��26��$��204,138,0,0q�$	��Top=�$��47��
��������� $��Numer Telefonu:��$
��Left=�$��26��$��204,164,0,0q�$	��Top=�$��94��
��������� $��E-mail:��$
��Left=�$��26��$��204,190,0,0q�$	��Top=�$��47��
��������� $��Miasto:��$
��Left=�$��26��$��204,216,0,0q�$	��Top=�$��47��
��������� $��Ulica:��$
��Left=�$��26��$��204,242,0,0q�$	��Top=�$��47��
��������� $��Kod pocztowy:��$
��Left=�$��26��$��204,268,0,0q�$	��Top=�$��94��
��������� $��Nr Mieszkania:��$
��Left=�$��26��$��204,294,0,0q�$	��Top=�$��84��
��������� -    ��Name$ Listapacjentow��$
��Left=�$	��322��$��	10,77,0,0q�$	��Top=�$	��165���� $
��Left=�$	��492��$��	193,0,0,0q�
�������$��Center=�$��6�����	#FFFBFBFB�� $
��Left=�$	��492��$��	487,0,0,0q�
�������$��Center=�$��6�����	#FFFBFBFB�� -    ��Name$ B_Window_Close��$��X��$
��Left=�$��19��$��
764,10,0,0q�$	��Top=�$��21�����	#FFF38F8F
����������	#FFE29B9B�� -   	 ��Name$	 Imie_box��$
��Left=�$��26��$��
301,86,0,0q�$	��Top=�$	��181��
����������	#FF1C0C53�� -   $	 Nazwisko_box��$
��Left=�$��26��$��301,112,0,0q�$	��Top=�$	��181��
����������	#FF1C0C53�� -   $	 	PESEL_box��$
��Left=�$��26��$��301,138,0,0q�$	��Top=�$	��181��
����������	#FF1C0C53�� -   $	 	Nrtel_box��$
��Left=�$��26��$��301,164,0,0q�$	��Top=�$	��181��
����������	#FF1C0C53�� -   $	 	email_box��$
��Left=�$��26��$��301,190,0,0q�$	��Top=�$	��181��
����������	#FF1C0C53�� -	   $	 
miasto_box��$
��Left=�$��26��$��301,216,0,0q�$	��Top=�$	��181��
����������	#FF1C0C53�� -
   $	 	ulica_box��$
��Left=�$��26��$��301,242,0,0q�$	��Top=�$	��181��
����������	#FF1C0C53�� -   $	 kod_box��$
��Left=�$��26��$��301,268,0,0q�$	��Top=�$	��181��
����������	#FF1C0C53�� -   $	 nrmieszkania_box��$
��Left=�$��26��$��301,294,0,0q�$	��Top=�$	��181��
����������	#FF1C0C53�� $
��Left=�$��0��$��	562,0,0,0q�
�������$��Center=�$	��234�����	#FFFBFBFB�� $��
Informacje��$
��Left=�$��31��$��
199,30,0,0q�$	��Top=�$	��288�����	#FF6E46CB
�������$
��Bold"�$��Center=�$��Center=��� $��Wizyty��$
��Left=�$��31��$��
493,30,0,0q�$	��Top=�$	��288�����	#FF6E46CB
�������$
��Bold"�$��Center=�$��Center=��� $��Wybór pacjenta��$
��Left=�$��31��$��	-1,30,0,0q�$	��Top=�$	��194�����	#FF6E46CB
�������$
��Bold"�$��Center=�$��Center=��� $��Ilość Wizyt:��$
��Left=�$��26��$��
496,86,0,0q�$	��Top=�$��72��
��������� $��Ostatnia wizyta:��$
��Left=�$��26��$��496,112,0,0q�$	��Top=�$��93��
��������� $��Lista wizyt:
��$
��Left=�$��26��$��498,158,0,0q�$	��Top=�$��70��
��������� -   $	 Ilosc_Wizty_box��$
��Left=�$��26��$��
594,86,0,0q�$	��Top=�$	��180��
����������	#FF1C0C53�� -   $	 Ostatnia_wizyta_box��$
��Left=�$��26��$��594,112,0,0q�$	��Top=�$	��180��
����������	#FF1C0C53�� $��Wykonane
Badania :��$
��Left=�$��43��$��497,221,0,0q�$	��Top=�$��70��
��������� $
��Left=�$	��108��$��594,199,0,0q�$	��Top=�$	��180���� -   $ Lista_Wizyt_list��$
��Left=�$��39��$��594,151,0,0q�$	��Top=�$	��180��