   M S B A M L   `   `   `  ����F  BZooScenario, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ZooScenarioZooScenario  5   	       ZooScenario.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:ZooScenario     5   	   -   5          �Name$  window��5   	    � Title$( "Object-Oriented Programming 2: Zoo��5   	   $��350.8��64   $	��440��6C    � WindowStartupLocation$ CenterScreen=�6O   .��5	      � $��10,0,3.6,-20q�6   .+�5
   
   �� -   5         ��Name$ admitGuestButton��5
      $��Admit Guest��6+   $
��Left=�6A   $��20��6\   $��	19,43,0,0q�6h   $	��Top=�6{   $��75��6�   6�   �� 5   
   -   5        $ feedAnimalButton��5      $��Feed Animal��6+   $
��Left=�6A   $��	19,81,0,0q�6\   $	��Top=�6o   $��75��6�   6�   �� 5   
   -   5         ��Name$ temperatureBorder��5      
���   �$��1q�6@   $��Right=�6T   $	��100��6p   $��
0,0,0,25.8q�6}   $��Bottom=�6�   $��20��6�   
���  ��6�   �� 5   
   -   5         ��Name$ increaseTemperature��5      $��+��64   $��Right=�6@   $��Bottom=�6\   $��23��6w   $��0,0,32,65.8q�6�   $��23��6�   6�   �� 5   
   -   5        $ decreaseTemperature��5      $��-��64   $��Right=�6@   $��0,0,32,37.8q�6\   $��Bottom=�6q   $��23��6�   $��23��6�    J� RenderTransformOrigin$ -1.165,-1.174&�6�   6�   �� 5   
   -   5         ��Name$ temperatureLabel��5      $
��Temp��6*   $��Right=�69   $��0,0,25,95.8q�6U   $��Bottom=�6j   �� 5   
   -   5         ��Name$ animalListBox��5      $
��Left=�6)   $	��260��6D   $��
108,43,0,0q�6Q   $	��Top=�6e   $	��100��6}   �� 5   
   $��Animals��6   $
��Left=�6"   $��
109,22,0,0q�6=   $	��Top=�6Q   $ -1.082,0.453&�6i   �� 5   
   -	   5        $ guestListBox��5      $
��Left=�6(   $	��260��6C   $��
247,43,0,0q�6P   $	��Top=�6d   $��96��6|   �� 5   
   $��Guests��6   $
��Left=�6!   $��
249,22,0,0q�6<   $	��Top=�6P   5      5      