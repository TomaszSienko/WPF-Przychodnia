   M S B A M L   `   `   `  ���� M  IPrzychodnia_App_v1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Przychodnia_App_v1.WindowsPrzychodnia_App_v1.Windows      Przychodnia_App_v1.Win2   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     :local(clr-namespace:Przychodnia_App_v1.Windows     -     � WindowStyle$
  None=� � 
ResizeMode$ NoResize=�
������  � AllowsTransparency$
 True�� � WindowStartupLocation$ CenterScreen=� � Title$ 	Dashboard��$	��482��$	��802�� J� Opacity$
 0.98Q�.����  �� CornerRadius$ 50��$ 0.99999Q�����  �� ImageSource$ /Windows/Outside2.png��._�� .+��� $
��Left=�$��44��$��	379,2,0,0q�$	��Top=�$��50��$��
/Icon5.png�� J� RenderTransformOrigin$	 1,0&��� -   	 ��Name$	 B_Window_Minimize��$��-��$
��Left=�$��19��$��
734,14,0,0q�$	��Top=�$��21�����	#FF24AEB9���	#FF9CEAE4
��������� -   $	 B_Window_Close��$��X��$
��Left=�$��19��$��
758,14,0,0q�$	��Top=�$��21�����	#FFF38F8F
����������	#FFE29B9B�� -   $	 B_Powrot��$��Wyloguj��$
��Left=�$��19��$	��Top=�$��57��$��Franklin Gothic Book)����	#FFFCFCFC$��
672,14,0,0q�
 � 	Resources
  �� 
TargetType �� Property �� Value��%:   '��       �� " ��.���  �@��CornerRadius$ 10������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FFABADB4��� $ 	#FF6C7CBD�� � Offset$ 1Q�� $ 	#FF9EA3B5��$ 0.278Q��� $ 40��$��1q�$��Center=�$	��423��$��0,49,0,0q�$	��Top=�$	��754������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFABADB4��� $ 	#FF6C7CBD��$ 1Q�� $ 	#FF9EA3B5��$ 0.278Q�._�� -    �Name$ 	Main_Grid��$
��Left=�$	��373��$��
180,33,0,0q�$	��Top=�$	��553�����	#FFB9C1E8.+�&   System.Windows.Controls.Calendar  -     Name$ Calendar��$
��Left=�$	��150��$��	374,0,0,0q�$	��Top=�$	��169���� -    ��Name$ Dzisiejsze_wizyty��$
��Left=�$	��306��$��	16,47,0,0q�$	��Top=�$	��344�����	#FF7695E8
�������&   System.Windows.Controls.DataGrid  -     Name$
 Baza��$
��Left=�$	��169��$��
24,265,0,0q�$	��Top=�$	��170�����	#FFB4C2E6o� $��Center=�$��18��$��0,60,0,0q�$	��Top=�$	��708��.@�m� $��	Dodawanie��.@�m� -	   $��Dodaj Pacjenta��m� -
   $��Nowa Wizyta��m� $��	Wyświetl��.@�m� -   $��Pacjent��m� -   $��Lekarz��m� $��Edytuj��.@�m� -   $��Pacjenta��m� $��Lekarza��m� $��Konta��.@�m� -   $��Utwórz konto��m� $��Zmien haslo���� -   $	 B_Powrot_Copy1��$��Adresy��$
��Left=�$��16��$	��Top=�$��59��$��Franklin Gothic Book)����	#FFFBFBFB$��
35,140,0,0q�
 ��%9   '��       �� " ��.���  �@��CornerRadius$ 0������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFABADB4��� $ 	#FF6C7CBD��$ 1Q�� $ 	#FF9EA3B5��$ 0.278Q��� $
��Left=�$��7��$��
24,128,0,0q�
�������$	��Top=�$	��170�����	#FFFBFBFB�� -   $	 Pacjenci��$��Pacjenci��$
��Left=�$��16��$	��Top=�$��59��$��Franklin Gothic Book)����	#FFFBFBFB$��119,140,0,0q�
 ��%9   '��       �� " ��.���  �@��CornerRadius$ 0������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFABADB4��� $ 	#FF6C7CBD��$ 1Q�� $ 	#FF9EA3B5��$ 0.278Q��� -   $	 B_Dzisiejsze_wizyty��$��Dzisiejsze wizyty��$
��Left=�$��18��$	��Top=�$	��134��$��Franklin Gothic Book)����	#FFFBFBFB$��595,241,0,0q�$��10(�
 ��%:   '��       �� " ��.���  �@��CornerRadius$ 10������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFABADB4��� $ 	#FF6C7CBD��$ 1Q�� $ 	#FF9EA3B5��$ 0.278Q��� $
��Left=�$��6��$��
24,254,0,0q�
�������$	��Top=�$	��170�����	#FFFBFBFB�� $
��Left=�$	��394��$��
194,78,0,0q�
�������$	��Top=�$��6�����	#FFFBFBFB�� -    ��Name$ Wizyty_Label��$��Dzisiejsze Wizyty��$
��Left=�$��31��$��
215,84,0,0q�$	��Top=�$	��352�����	#FF6E46CB
�������$
��Bold"�$��Center=�$��Center=�$ 0.475,1.739&��� -   $	 Moje_Wizyty��$��Moje Wizyty��$
��Left=�$��28��$	��Top=�$��82��$��Franklin Gothic Book)����	#FFFBFBFB$��
66,170,0,0q�
 ��%9   '��       �� " ��.���  �@��CornerRadius$ 0������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFABADB4��� $ 	#FF6C7CBD��$ 1Q�� $ 	#FF9EA3B5��$ 0.278Q��� -   $	 B_Edycja_wizyty��$��Edytuj wybraną wizyte��$
��Left=�$��18��$	��Top=�$	��134��$��Franklin Gothic Book)����	#FFFBFBFB$��595,332,0,0q�$��10(�
 ��%:   '��       �� " ��.���  �@��CornerRadius$ 10������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFABADB4��� $ 	#FF6C7CBD��$ 1Q�� $ 	#FF9EA3B5��$ 0.278Q��� -   $!	 B_wyswietl_wszystkie_wizyty��$�� Wszystkie wizyty��$
��Left=�$��18��$	��Top=�$	��134��$��Franklin Gothic Book)����	#FFFBFBFB$��595,266,0,0q�$��10(�
 ��%:   '��       �� " ��.���  �@��CornerRadius$ 10������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFABADB4��� $ 	#FF6C7CBD��$ 1Q�� $ 	#FF9EA3B5��$ 0.278Q��� -   $	 B_usun_wizyte��$��Usuń wybraną wizyte��$
��Left=�$��18��$	��Top=�$	��134��$��Franklin Gothic Book)����	#FFFBFBFB$��595,416,0,0q�$��10(�
 ��%:   '��       �� " ��.���  �@��CornerRadius$ 10������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFABADB4��� $ 	#FF6C7CBD��$ 1Q�� $ 	#FF9EA3B5��$ 0.278Q�