   M S B A M L   `   `   `  ����F  BZooScenario, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ZooScenarioZooScenario  5   	       ZooScenario.AnimalWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:ZooScenario     5   	   -   5          � Title$  AnimalWindow��5   	   $	��450��6   $	��800��6+    � WindowStartupLocation$ CenterScreen=�67   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��100 �6   �� 5      $��4 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��4 �6   �� 5      $��30 �6   �� 5      $��4 �6   �� 5      $��30 �6   �� 5      $��4 �6   �� 5      $��30 �6   �� 5      $��4 �6   �� 5      $��30 �6   �� 5      $��4 �6   �� 5      $��30 �6   .+�5   
   �� $��1��6   $��0��6   $
��Name��6-   $��Right=�6<   �� 5   
   -   5         ��Name$ nameTextBox��5   /   $��1��6   $��2��6   6D   �� 5   
   $��3��6   $��0��6   $��Gender��6-   $��Right=�6>   �� 5   
   -   5         ��Name$ genderComboBox��5   0   $��3��6   $��4��6    6H   �� 5   
   $��5��6   $��0��6   $	��Age��6-   $��Right=�6;   �� 5    
   -   5        $ 
ageTextBox��5    /   $��5��6   $��6��6   6C   �� 5!   
   $��7��6   $��0��6   $��Weight��6-   $��Right=�6>   �� 5"   
   -   5        $ weightTextBox��5"   /   $��7��6   $��8��6   6F   �� 5#   
   -   5         ��Name$ pregnancyStatusLabel��5#      $��9��6.   $��0��6;   $��No��6K   $��Right=�6X   �� 5$   
   -   5         ��Name$ makePregnantButton��5$   L   $��9��6   $��10��6   $��makePregnantButton��6/   6h   �� 5%   
   -   5        $ okButton��5%      $��OK��6#   $��2��60   $��Right=�6@   $��24��6\   $��0,0,606.6,-73q�6h   $��9��6   $��Bottom=�6�   $��75��6�    �� 	IsDefault . 6�   �� 5&   
   -	   5        $ cancelButton��5&      $��Cancel��6'   $��2��68   $��Right=�6H   $��24��6d   $��0,0,493.6,-73q�6p   $��9��6�   $��Bottom=�6�   $��75��6�   	 �� IsCancel	 . 6�   5'      5)      