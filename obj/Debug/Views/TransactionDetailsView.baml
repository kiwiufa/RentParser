   M S B A M L   `   `   `  ����E  ARentParser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:RentParser.ViewsRentParser.Views  5   	   -    'RentParser.Views.TransactionDetailsView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:RentParser.Views     5   	     � Title$  TransactionDetailsView��5   	   $	��450��6(   $	��500��65   .��5	      � .+�5
   
   �� $��Particulars:��6   $
��Left=�6'   $��
27,317,0,0q�6B   $	��Top=�6V   $��93��6n   �� 5   
   $��Code:��6   $
��Left=�6    $��
27,276,0,0q�6;   $	��Top=�6O   $��93��6g   �� 5   
   $��
Reference:��6   $
��Left=�6%   $��
27,232,0,0q�6@   $	��Top=�6T   $��93��6l   �� 5   
   $��Type:��6   $
��Left=�6    $��
218,27,0,0q�6;   $	��Top=�6O   $��93��6g   �� 5   
   $��Account:��6   $
��Left=�6#   $��
27,201,0,0q�6>   $	��Top=�6R   $��93��6j   �� 5   
   $��Sender:��6   $
��Left=�6"   $��	29,58,0,0q�6=   $	��Top=�6P   $��93��6h   �� 5   
   $��Date:��6   $
��Left=�6    $��	29,27,0,0q�6;   $	��Top=�6N   $��93��6f   �� 5   
   $��Amount:��6   $
��Left=�6"   $��
27,159,0,0q�6=   $	��Top=�6Q   $��93��6i   �� 5   
   $��Processed Date:��6   $
��Left=�6*   $��
27,348,0,0q�6E   $	��Top=�6Y   $��93��6q    J� RenderTransformOrigin$ 0.431,1.699&�6|   �� 5   
   $��Payee:��6   $
��Left=�6!   $��	28,99,0,0q�6<   $	��Top=�6O   $��93��6g   �� 5   
   -   5         ��Name$ 
date_label��5      $
��Left=�6[   $��	90,27,0,0q�6v   $	��Top=�6�   $��93��6�   $��26��6�   ��6$   �� *TransactionEntry.Date+ �� Mode$ OneWay=�6�   �� 5   
   -   5        $ 
type_label��5      $�� ��6$   $
��Left=�6/   $��
280,27,0,0q�6J   $	��Top=�6^   $��93��6v   �� 5   
   -   5        $ payee_label��5      $
��Left=�6]   $��	90,99,0,0q�6x   $	��Top=�6�   $	��294��6�   $��26��6�   ��6%   �� *TransactionEntry.Payee+$ OneWay=�6�   �� 5   
   -   5        $ amount_label��5      $
��Left=�6_   $��108,159,0,0q�6z   $	��Top=�6�   $��93��6�   ��6&   �� *TransactionEntry.Amount+$ OneWay=�6�   �� 5   
   -   5        $ account_label��5      $
��Left=�6j   $��108,201,0,0q�6�   $	��Top=�6�   $	��276��6�   $��26��6�   ��6'   �� *#!TransactionEntry.ThisPartyAccount+$ OneWay=�6�   �� 5   
   -   5         ��Name$ sender_button��5      $
��Left=�6(   $��
122,58,0,0q�6C   $	��Top=�6W   $	��334��6o   $��26��6{   6�   5      5      