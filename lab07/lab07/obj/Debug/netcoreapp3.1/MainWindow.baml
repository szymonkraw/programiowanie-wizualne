   M S B A M L   `   `   `  ����@  <lab07, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:lab07lab07  5   	       lab07.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:lab07     5   	     � Title$  
MainWindow��5   	   $	��470��6   $
��1206��6)   .��5	      � .+�5
   
   �� -   5        $��wypozycz��5
      $��	Wypożycz��6!   $��Center=�64   $��0,54,0,0q�6Q   $	��Top=�6c   $��63��6{   $	��114��6�   6�   �� 5   
   -   5        $��oddaj��5      $��Oddaj��6   $��Center=�6.   $��	0,235,0,0q�6K   $	��Top=�6^   $��63��6v   $	��114��6�   6�   �� 5   
   -   5        $��
dodaj_czyt��5      $��Dodaj czytelnika��6$   $
��Left=�6?   $��146,342,0,0q�6Z   $	��Top=�6o   $��63��6�   $	��114��6�   6�   �� 5   
   -   5        $��dodaj_ks��5      $��Dodaj książkę��6!   $
��Left=�69   $��857,342,0,0q�6T   $	��Top=�6i   $��63��6�   $	��114��6�   6�   �� 5   
   -   5         ��Name$ lista_użyt��5      $��0,0,700,150q�6'    �� View 5      �� 5      .P�5      �� -   5        Imie��$
��Imie��5   3    �� Width$	 100��6A    �� DisplayMemberBinding 6M   �� *Imie+�� 5      -   5        Nazwisko��$��Nazwisko��5   7   $	 150��6I    6U   �� *
Nazwisko+�� 5      -   5        ID��$��ID��5   1   $ 40��6=    6H   �� *ID+5      5      �� 5   
   -	   5        $ lista_książ��5      $��700,0,0,150q�6(    5      �� 5      .P�5      �� -
   5        	Tytul��$��Tytul��5   4   $	 100��6C    6O   �� *Tytul+5      �� 5      -   5        	Autor��$��Autor��5   4   $	 150��6C    6O   �� *Autor+�� 5      -   5        ID1��$��ID��5   2   $ 40��6>    6I   �� *ID1+�� 5      -   5        wypozyczenia��$$��wypozyczenia (ID użytkownika)��5   ;   $	 200��6b    6n   �� *
wypozycz+5       5!      5%      �� 5&   
   -   5        $��dodaj��5&      $��dodaj��6   $
��Left=�6/   $��313,356,0,0q�6J   $	��Top=�6_   $��49��6w   $��56��6�   6�   �� 5'   
   -   5         ��Name$ 
dodaj_Copy��5'      $��dodaj��6&   $
��Left=�66   $��1023,356,0,0q�6Q   $	��Top=�6g   $��49��6   $��56��6�   6�   �� 5(   
   -   5        $��wyjdz��5(      $��Wyjdź��6   $
��Left=�6.   $��490,342,0,0q�6I   $	��Top=�6^   $��58��6v   $	��251��6�   6�   5)      5*      