   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections     WpfApp1.MainWindow   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:WpfApp1     Bcol2clr-namespace:System.Collections;assembly=mscorlib       � Title$  
MainWindow��$	��450��$	��810��.���  � RowDefinitions �� $
��0.3* ��� �� $
��0.3* � � ColumnDefinitions �� $
��0.2* ��� �� $
��0.3* �.+��� $��3��.+��� $	��106��$��73��.���� $
��Wrap=�$��16(�$"F2 Оплата наличными�� $	��106��$��73��.���� $
��Wrap=�$��16(�'%F4 Удалить посл.товар�� $	��106��$��73��.���� $��Center=�$��Center=�$
��Wrap=�$��16(�$'��!F6 Скидка за дефект���� $	��106��$��73��.���� $
��Wrap=�$��16(�" F9 Замена карточки�� $	��106��$��73��.����  �� TextWrapping$
 Wrap=�$��16(�.��F10 Отмена чека�� $	��106��$��73��.���� $
��Wrap=�$��16(�F12 Выход�� $��1��
����+��$��2q�._���  �� Orientation$ 
Horizontal=�$��1��.+��� $	��120��$��30��$��Bottom=��� $!��Читайте баркод��$	��400��$��62��$��18(�$��-120,20,0,12q�
��� � ��� $��Чек №17633��$��30��$��18(�
����  �$��Right=�$	��Top=��� $
��0:00��$��30��$��18(�
����  �$��
-180,0,0,0q�$��Bottom=�$��45���� $��15��$��18(�
����  �$��	-57,0,0,0q�$��Bottom=�$��80���� $��2��
����+��$��0,2,2,2q�._��� $ Vertical=�$��2��.+��� $��К оплате��$��50��$��20(�$��0,5,0,0q��� $��1540.00��
����  �$��Bottom=�$��Right=�$��19(��� $��1��$��1��
����+��$��2,0,2,2q�._�&   System.Windows.Controls.DataGrid  -     Name$ 	shoesGrid��$��80��   AutoGenerateColumns$
 True��$	��Top=��� $��1��$��1��
����+��$��2,0,2,2q�._��� $��40��$��Bottom=�$ 
Horizontal=�.+��� $��Center=�$��2 строк��$	��300��$��16(�
����+��$��0,2,2,0q��� $��Center=�$��2��$��16(�
����+��$��0,2,2,0q��� $��Center=�$
��1658��$��80��$��Right=�
���  ��$��16(�
����+��$��0,2,2,0q��� $��Center=�$
��1540��$	��139��$��Right=�$��16(�
����+��$��0,2,2,0q��� $��1��$��3��
����+��$��2,2,2,2q�._��� $ 
Horizontal=�.+�  -   $ storageCard��$��60��$	��350��$
 True��$��Bottom=�  -   $ additionalCard��$��60��$	��190��$
 True��$��Bottom=��� $ 
Horizontal=�$��25��$	��Top=�.+��� $+��%Накопительная карта��$��
-537,0,0,0q�$	��350��$
��Left=��� $��Доп карта��$��
-195,0,0,0q�