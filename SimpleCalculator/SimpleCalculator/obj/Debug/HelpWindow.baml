   M S B A M L   `   `   `  ����K  GSimpleCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SimpleCalculatorSimpleCalculator  5   	   !    SimpleCalculator.HelpWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:SimpleCalculator     5   	     � Title$  Help Window��5   	   $	��450��5	   	   $	��800��5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	   .��5      � 
���   �.+�5   
   � 
����ح�$��10,10,9.6,10q�5       � ColumnDefinitions 5      �� 5      $��1* �5       � RowDefinitions 5      �� 5      $��1* �5      �� 5      $��3* �5      �� 5      $��1* �5      .+�5!      �� $��Center=�5"      $��Center=�5#      $��50(�5$       �� TextAlignment$ Center=�5%      $��0��5&      $��0��5'      
���   �
�������$��80��5*      $��	0,0,0.4,0q�5+      $	��774��5,      	Help Page5.      �� 50       �� Orientation$ Vertical=�51      $��0��52      $��1��53      $��Center=�54      .+�56      �� $ Center=�57      $��20(�58      $
��Bold"�59      
���   �$��52��5;      $	��698��5<      =;This is the help section for the Height/Weight Application.�� 5>      See instructions below.5@      �� 5B      $��75��6"    �� Bullet 5C      A� 5D      $��10��5E      $��10��5F      
���   �$��	20 50 0 0q�5H      5I      ._�5M      �� $��20(�5N      $��	30 50 0 0q�5O      $��Italic$�5P      
���   �53Input the Height or Weight into the provided fields5S      5U      �� 5W       5X      A� 5Y      $��10��5Z      $��10��5[      
���   �$��	20 10 0 0q�5]      5^      ._�5`      �� $��20(�5a      $��	30 10 0 0q�5b      $��Italic$�5c      
���   �SQSelect the appropriate radio button to convert the Height or Weight automatically5f      5g      �� 5i       5j      A� 5k      $��10��5l      $��10��5m      
���   �$��	20 10 0 0q�5o      5p      ._�5s      �� $��20(�5t      $��	30 10 0 0q�5u      $��Italic$�5v      
���   �:8To exit the application, simply click on the exit button5y      5z      5{      �� 5}      -   5        $��0��5~      $��2��5      $��Return��5�      $��32(�5�      $	��150��5�      $��60��5�      $��Right=�5�      $��0 0 15 0q�5�      
���   �
�������5�      5�      5�      5�      