   M S B A M L   `   `   `  ����G  CDomZdravlja1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DomZdravlja1DomZdravlja1  5   	       DomZdravlja1.WindowUnos   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:DomZdravlja1     5   	     � Title$  
WindowUnos��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $��Sifra��6   $
��Left=�6    $��	56,20,0,0q�6;   $	��Top=�6N   �� 5   
   $	��Ime��6   $
��Left=�6   $��	56,63,0,0q�69   $	��Top=�6L   $��37��6d   $��56��6p   �� 5   
   $��Prezime��6   $
��Left=�6"   $��
50,105,0,0q�6=   $	��Top=�6Q   �� 5   
   $��Firma��6   $
��Left=�6    $��
56,147,0,0q�6;   $	��Top=�6O   �� 5   
   $��Paket��6   $
��Left=�6    $��
54,191,0,0q�6;   $	��Top=�6O   �� 5   
   $��Popust��6   $
��Left=�6!   $��
50,236,0,0q�6<   $	��Top=�6P   �� 5   
   -   5        $��tbSifra��5   >    �� TextWrapping$
 Wrap=�6   $��157,20,491,372q�6&   6>   �� 5   
   -   5        $��tbIme��5   &   $
 Wrap=�6   $��157,67,480,316q�63   �� 5   
   -   5        $��	tbPrezime��5   &   $
 Wrap=�6   $��157,105,491,290q�67   �� 5   
   -   5        $��cbFirma��5      $
��Left=�6"   $��157,151,0,0q�6=   $	��Top=�6R   $	��120��6j    �� SelectedIndex$ 0��6v   ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� ��6$   �� *Naziv+�� 5      $	�� - ��6$   �� 5      $��Italic$�6=   ��6$   �� *	Sediste+6=   5      5      5      �� 5   
   -   5        $��cbPaket��5      $
��Left=�6"   $��157,195,0,0q�6=   $	��Top=�6R   $	��120��6j   ��5      �� ��5       �� 5!      .R�5"      �� $ 
Horizontal=�6!   .+�5#      �� ��6$   �� *Naziv+5$      5%      5'      �� 5(   
   -   5        $��sliderPopust��5(      $
��Left=�6%   $��157,244,0,0q�6@   $	��Top=�6U   $	��120��6m    � Minimum$ 1Q�5)       � Maximum$ 50Q�6    �� TickFrequency$ 1Q�6*    � SmallChange$ 5Q�6<    �� IsSnapToTickEnabled . 6L   �� 5*   
   -   5        $��
btnPotvrdi��5*      $��Potvrdi��6#   $
��Left=�65   $��
50,308,0,0q�6P   $	��Top=�6d   $��37��6|   $��93��6�   6�   �� 5+   
   -   5        $��Odustani��5+      $
��Left=�6$   $��227,308,0,0q�6?   $	��Top=�6T   $��37��6l   $��82��6x   6�   �� 5,   
   -	   5        $��tbSliderValue��5,   V   $
��Left=�6   $��307,249,0,0q�6-   $
 Wrap=�6B   $	��Top=�6k   $	��120��6�   ��5-      �� 	 �� ElementName$	 sliderPopust��
 �� Path$
 Value� �� StringFormat$ 0�� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� 5.   
   -
   5        $��tbCena��5.   V   $
��Left=�6   $��542,135,0,0q�6-   $
 Wrap=�6B   $	��Top=�5/      $	��120��6*   ��66   �� $	 cbPaket��$
 SelectedValue.Cena�$ OneWay=��� 50   
   $
��Cena��6   $
��Left=�6   $��489,131,0,0q�6:   $	��Top=�6O   52      53      