   M S B A M L   `   `   `  ���� E  AWeatherApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WeatherApp
WeatherApp      WeatherApp.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:WeatherApp       � Title$  
WeatherApp��$	��500��$	��900�� � Icon$ weatherapp.ico�� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=����#181735 � 	Resources    ComboBoxToggleButton �� 
TargetType � ColumnDefinitions ��Name �� CornerRadius	 F�Name  ComboBoxTextBox
 �� 
TargetType �� Property �� Value �� 	ClickMode d� 	IsChecked �� Path �� Mode �� RelativeSource J� IsHitTestVisible �� SelectionBoxItem �� SelectionBoxItemTemplate ��Name �� 
IsReadOnly �� 
IsReadOnly �� IsDropDownOpen � AllowsTransparency J� SnapsToDevicePixels � ActualWidth �� MaxDropDownHeight K� IsItemsHost-  'System.Windows.Input.KeyboardNavigation   DirectionalNavigation �� Triggers  P� Property! P� Value" �� 
TargetName# P� 
SourceName$ �� Triggers% �� Padding��%;  &	        &	 A    '�� x    7   7  '�� �    �� " d�.R��  �� �� $��20 �.+��� $ Border��$��2��$ 8�����	#FF3F3F3F���	#FF97A0A5$��1q��� $��0��$ 8��$��1q����	#FF3F3F3F���	#FF97A0A5$��0,0,1,0q�F� $	 Arrow��$��1��
�������$��Center=�$��Center=�=����        �    �� � 	= ��[ � z �� � z     � 	=  	= 	�� " ��.R��� $ PART_ContentHost��|�.  #��z���� "
 ��.���  �@J�SnapsToDevicePixels . ��  �@�OverridesDefaultStyle . ��  � ��$
 Auto=���  � ��$
 Auto=���  � �� . ��  � ��$	 120����  � ��$ 20����  � ��
 �������  � �� �� " ��.R�� .+�d� $��ToggleButton��8��  $��2��|�.  $ Press=� �� $ IsDropDownOpen�$ TwoWay=� �� *TemplatedParent+�� $��ContentSite�� .  #��z #��z #��z��$��3,3,23,3q�$��Center=�$
��Left=��� $ PART_EditableTextBox��8�� $
��Left=�$��Center=�$��3,3,23,3q�|�. ���	#FF3F3F3F
��� � �$y�Hidden=�# z ��Z� � $��Popup��$��Bottom=�#��z  . |�.  $��Slide=�.��� $��DropDown�� . #��z #��z .+��� $ DropDownBorder�����	#FF3F3F3F$��1q����#888888�� $��4,6,4,6q� . .����  . $ 	Contained=� P�   �@��HasItems! .  . ��� $" DropDownBorder�� � ��$ 95��P�   � {�! .  . ���  � �� �#888888P�   �@��
IsGrouping! . . ���  � �� .  P� $# Popup��  �@�AllowsTransparency! . . ��� $" DropDownBorder�� �@��CornerRadius$ 0���� $" DropDownBorder�� � ��$ 0,2,0,0q�P�   �@��
IsEditable! . . ���  � �� .  �� $" PART_EditableTextBox�� � y�$ Visible=��� $" ContentSite�� � y�$ Hidden=�$ �� "
 ��.���  �@J�SnapsToDevicePixels . ��  � ��
 �������  �@�OverridesDefaultStyle . ��  � �� �� " ��.R��� $��Border��$% 2q� . ._���  P�   �@��IsHighlighted! . . ��� $" Border�� � �� �	#FF4F4F4FP�   � {�! .  . ���  � �� �#888888.��� & � RowDefinitions& �� $��25 ��� $
��Auto ��� �� $	��125 �.+�� -   $��0��
�������$��1�� �� �� �� �� �� �� �� �� �� .+��� -   $��Close��
�������$��12(�$��Medium"�$��0,0,10,0q�$��8��$��2������ "
 ��.���  � �� �#FE6584��  �@�Cursor$
 Hand��$ P�   �@J�IsMouseOver! . . ���  � �� �#FF4C70���� " ��.R��� $��75��$��18��$ 6��#��z��._��� $��Center=�$��Center=�� $��1�� �� $
��Auto ��� $
��Auto �.+��� -   ' ��Name$' comboBoxArea��( �� SelectedIndex$( 0��) �� SelectedValuePath$	) Key��* �� DisplayMemberPath$* Value��$
��Left=�$	��Top=�$	��150��$��30��$��0��$��40,15,10,10q����� *Area+�� -   + ��Name$+ ShowArea��$��表示��$��Center=�$��Center=�$��50��$��30��$��1��$��2��$��
0,15,10,10q�
����������� "
 ��.���  � �� �	#FF3F3F3F��  �@�Cursor$
 Hand��$ P�   �@J�IsMouseOver! . . ���  � �� �	#FFCDCDCD���� " ��.R��� $ 8��#��z�����	#FF97A0A5$��1q�._��� $��Center=�$��Center=�� $��2�� �� $��2* ��� .+�� $��0��& �� $	��14* ��� $	��45* �.+��� -   , ��Name$, DTtextblock��$��0��$��0��$��35(�
�������$��Center=�$��Center=��� -   - ��Name$- WeatherImageImage��$	��250��$��1���� $��1��$��Center=�.+��� -   $, TemperatureBlock��
�������$��25(�$��10q��� -   $, PrecipitationBlock��
�������$��25(�$��10q��� -	   $, WindSpeedBlock��
�������$��25(�$��10q��� -
   $, WindDirectionBlock��
�������$��25(�$��10q��� -   . ��Name$. WeatherListView��$��3����.  $
��Auto=�$
��Auto=�/ �� SelectionMode$/ Single=�
����������� "
 ��.���  � �� �#181735���� .R��� $	��Top=�.+��� $��25��$��80��$��0,-40,0,-35q�._��� $��25(�
�������$��Center=�$��Center=����� *DT+0 �� StringFormat$0 HH:mm���� $	��75 ��$��80��$��
0,10,0,-15q����� 1 �� 	UriSource1 �� *	Weather+���� .R�$� 2 $� Orientation$2 
Horizontal=�