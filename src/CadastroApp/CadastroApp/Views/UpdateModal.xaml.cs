using CadastroApp.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CadastroApp.Views
{
    /// <summary>
    /// Interaction logic for UpdateModal.xaml
    /// </summary>
    public partial class UpdateModal : Window
    {
        PessoaRepository _pessoaRepository = new PessoaRepository();
        string Id;

        public UpdateModal(string id)
        {
            InitializeComponent();
            Id = id;
        }

        //private void UpdateClick(object sender, RoutedEventArgs e)
        //{
        //    //
        //}

    }
}
