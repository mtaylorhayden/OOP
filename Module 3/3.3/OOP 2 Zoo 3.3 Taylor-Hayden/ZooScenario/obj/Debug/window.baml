   M S B A M L   `   `   `  ����F  BZooScenario, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ZooScenarioZooScenario  5   	       ZooScenario.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:ZooScenario     5   	   -   5          �Name$  window��5   	    � Title$( "Object-Oriented Programming 2: Zoo��5   	   $��350.8��64   $��549.6��6C    � WindowStartupLocation$ CenterScreen=�6Q   .��5	      � $��10,0,3.4,-20.2q�6    � ColumnDefinitions 5
   
   �� 5      $
��407* �6   �� 5      $	��78* �6   .+�5   
   �� -   5         ��Name$ admitGuestButton��5      $��Admit Guest��6+   $
��Left=�6A   $��20��6\   $��1,43,0,0q�6h   $	��Top=�6z   $��92��6�   6�   �� 5   
   -   5        $ feedAnimalButton��5      $��Feed Animal��6+   $
��Left=�6A   $��1,80,0,0q�6\   $	��Top=�6n   $��92��6�   6�   �� 5   
   -   5         ��Name$ temperatureBorder��5      
���   �$��1q�6@   $��Right=�6T   $	��100��6p   $��0,0,0,26q�6}   $��Bottom=�6�   $��20��6�   
���  ��$��1��6�   �� 5   
   -   5         ��Name$ increaseTemperature��5      $��+��64   $��Right=�6@   $��Bottom=�6\   $��23��6w   $��	0,0,32,66q�6�   $��23��6�   $��1��6�   �� 5   
   -   5        $ decreaseTemperature��5      $��-��64   $��Right=�6@   $��	0,0,32,38q�6\   $��Bottom=�6o   $��23��6�   $��23��6�    J� RenderTransformOrigin$ -1.165,-1.174&�6�   $��1��6�   �� 5   
   -   5         ��Name$ temperatureLabel��5      $
��Temp��6*   $��Right=�69   $��	0,0,25,96q�6U   $��Bottom=�6h   $��1��6�   �� 5   
   -   5        	 ��Name$	 animalListBox��5      $
��Left=�6)   $	��130��6D   $��
108,43,0,0q�6Q   $	��Top=�6e   $	��169��6}   6�   �� 5   
   $��Animals��6   $
��Left=�6"   $��
157,18,0,0q�6=   $	��Top=�6Q   $ -1.082,0.453&�6i   �� 5   
   -	   5        $	 guestListBox��5      $
��Left=�6(   $	��130��6C   $��
329,43,0,0q�6P   $	��Top=�6d   $	��176��6|   $��2��6�   �� 5   
   $��Guests��6   $
��Left=�6!   $��
380,17,0,0q�6<   $	��Top=�6P   $ 1.647,0.758&�6h   �� 5   
   -
   5        $ removeAnimalButton��5      $��Remove Animal��6-   $
��Left=�6E   $��147,253,0,0q�6`   $	��Top=�6u   $��99��6�   6�   �� 5   
   -   5        $ removeGuestButton��5      $��Remove Guest��6,   $
��Left=�6C   $��329,222,0,0q�6^   $	��Top=�6s   $��94��6�   $ -0.031,0.611&�6�   6�   �� 5   
   -   5        
 ��Name$
 animalTypeComboBox��5      $
��Left=�6/   $��146,189,0,0q�6J   $	��Top=�6_   $	��100��6w   �� 5   
   -   5        $ addAnimalButton��5      $��
Add Animal��6*   $
��Left=�6?   $��147,219,0,0q�6Z   $	��Top=�6o   $��99��6�   6�   �� 5   
   -   5        $ addGuestButton��5      $��	Add Guest��6)   $
��Left=�6=   $��329,190,0,0q�6X   $	��Top=�6m   $��96��6�   6�   �� 5   
   -   5        $ showCageButton��5   %   $��	Show Cage��6   $
��Left=�6=   $��20��6X   $��329,253,0,0q�6d   $	��Top=�6y   $��94��6�   6�   �� 5   
   -   5        $ adoptAnimalButton��5      $��Adopt Animal��6,   $
��Left=�6C   $��	1,115,0,0q�6^   $	��Top=�6q   $��92��6�   6�   �� 5   
   -   5        $ unadpotAnimalButton��5      $��Unadpot Animal��6.   $
��Left=�6G   $��	0,153,0,0q�6b   $	��Top=�6u   $��93��6�   6�   �� 5    
   -   5        $
 changeBehaviorComboBox��5       $
��Left=�63   $��20��6N   $��
-6,282,0,0q�6Z   $	��Top=�6n   $��99��6�   �� 5!   
   -   5        $ changeBehaviorButton��5!      $��Change Behavior��6/   $
��Left=�6I   $��20��6d   $��147,282,0,0q�6p   $	��Top=�6�   $	��100��6�   6�   �� 5"   
   -   5        $ birthAnimalButton��5"      $��Birth Animal��6,   $
��Left=�6C   $��	1,190,0,0q�6^   $	��Top=�6q   $��92��6�   $��21��6�   6�   5$      5%      