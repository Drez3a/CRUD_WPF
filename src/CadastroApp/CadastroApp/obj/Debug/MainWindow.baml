   M S B A M L   `   `   `  ����F  BCadastroApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CadastroAppCadastroApp  5   	       CadastroApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CadastroApp     5   	     � Title$  Cadastro de Pessoas��5   	   $	��600��6%   $	��800��62   .��5	      ]� .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
pessoaGrid��5
         AutoGenerateColumns .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6\      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
IdPessoa+  5      $
 Nome��6%    63   �� *Nome+  5      $ Gênero��6%    65   �� *Genero+4  .System.Windows.Controls.DataGridTemplateColumn  5         HeaderTemplate 5      �� 5      .R�5      �� $��Action��6(   5         CellTemplate 5      �� 5      .R�5      �� 	 �� Orientation$	 
Horizontal=�6)   .+�5   "   �� 
 ��Name$
 	insertBtn��6)   -   5        $��Inserir��5   <   6N   �� 5   "   $
 	updateBtn��6)   -   5        $��	Atualizar��5   <   6P   �� 5   "   $
 	deleteBtn��6)   -   5        $��Deletar��5   <   6N   5      5      5      5       5!      5"      