   M S B A M L   `   `   `  ����  S_E_319!    S_E_319.MainBrowserListView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � .+�5	   
   &   System.Windows.Controls.DataGrid      SelectionMode$  Single=�6    �� AlternationCount$ 2��6*      RowHeaderWidth$ 0Q�6?      AutoGenerateColumns .     
IsReadOnly . ��5
      �� *Items+ � 	Resources 5      )  #System.Windows.Controls.DataGridRow �� 
TargetType �� Triggers P� Property	 P� Value
 �� Property �� Value #  DataGridColumnHeaderContextMenu �� RelativeSource �� AncestorType m� IsCheckable=  7System.Windows.Controls.Primitives.DataGridColumnHeader��%  '        &	  �     '  �    7   �� 5      "  6    5      P� 5       �@ AlternationIndex$	 0��6>   . �5      �� 
 � ��
 �����6;   5      P� 5       �@ AlternationIndex$	 1��6>   . �5      �� 
 � ��
 �����6;   5      5      �� 5      ��6F   �� *	Columns+ �� $ DataGridL���5      �� 5      .R�5      m�  . ��6'   �� *Header+6A   5      5!      �� 5"      "  6   .�5#      �� 
 �@�ContextMenu8   64   5$      5%         Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+  5,      $ Owner��6%    64   �� *Owner+  5-      $ Borrower��6%    67   �� *
Borrower+  5.      $ Category��6%    67   �� *
Category+51      52      53      