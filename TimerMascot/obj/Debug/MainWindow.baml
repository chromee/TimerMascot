   M S B A M L   `   `   `  ����F  BTimerMascot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TimerMascotTimerMascot  5   	       TimerMascot.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:TimerMascot     5   	     � Title$  
MainWindow��5   	   $	��400��6   $	��700��6)    � AllowsTransparency .  � WindowStyle$
 None=�5	   	   
������  � 
ResizeMode$ NoResize=�5   	    � ContextMenu 5      �� 5   
   .@�5      m� -   5        $��終了��5      6#   5      .��5      � .+�5   
   �� $��れんちょん.png��6   $��352,50,-1,0q�6#   �� 5   
   $��吹き出し.png��6   $��-61,6,187,107q�6"   �� 5   
   -   5         ��Name$ FirstCanvas��5      $
��Left=�6&   $	��110��6A   $��	60,50,0,0q�6N   $	��Top=�6a   $	��340��6y   $y�Hidden=�6�   .+�5      �� -   5         ��Name$ label��5      $!��時間を入力するのん��6#   $
��Left=�67   $	��Top=�6R   $��APJapanesefont)�6j   $��24(�6�   $��37��6�   $	��193��6�   
 �� Top$ 21��6�    �� Left$ 16��6�   �� 5      -   5        	 ��Name$	 
timerInput��5      $
��Left=�6*   $��24��6E   
 �� TextWrapping$

 Wrap=�6Q   $	��Top=�6e   $��68��6}   $
��3600��6�   $��APJapanesefont)�6�   $��24(�6�   $	 214��6�   $ 25��6  ��6�   Z� 6  �� 5      -   5        $ label1��5      $	��秒��6$   $
��Left=�60   $	��Top=�6K   $��APJapanesefont)�6c   $��34��6   $��34��6�   $��24(�6�   $	 287��6�   $ 21��6�   �� 5      -   5         ��Name$ StartButton��5      $��すた～と��6*   $	��118��69   $��APJapanesefont)�6E   $��28(�6a   $��37��6o   $	 106��6{   $ 71��6�   6�   5      �� 5   
   -   5        $ CountCanvas��5      $
��Left=�6&   $	��110��6A   $��	60,50,0,0q�6N   $	��Top=�6a   $	��340��6y   .+�5      �� -   5        $ label2��5      $��残り��6$   $��APJapanesefont)�61   $��36(�6M   $ 20��6[   $ 21��6l   �� 5      -	   5        $ 
timerLabel��5      $ 97��6(   $ 20��69   $��APJapanesefont)�6I   $��38(�6e   $��92��6s   $��43��6~   $�� ��6�   �� 5       -
   5        $ label2_Copy��5       $��秒なのん��6)   $��APJapanesefont)�68   $��36(�6T   $	 189��6b   $ 22��6t   �� 5!      -   5        $ 
StopButton��5!      $��すとっぷ��6)   $��86��68   $ 58��6C   $ 72��6T   $��24(�6d   $��APJapanesefont)�6r   6�   �� 5"      -   5        $ ResetButton��5"      $��りせっと��6*   $��86��69   $	 179��6D   $ 72��6V   $��24(�6f   $��APJapanesefont)�6t   6�   5#      5$      5%      