using CadastroApp.Domain.Models;
using CadastroApp.Infra.Data.Repositories;
using CadastroApp.Views;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CadastroApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PessoaRepository _pessoaRepository = new PessoaRepository();
        public static DataGrid MainGrid;

        public MainWindow()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            pessoaGrid.ItemsSource = _pessoaRepository.GetAllPessoas().ToList();
            MainGrid = pessoaGrid;
        }

        private void InsertClick(object sender, RoutedEventArgs e)
        {
            InsertModal insertModal = new InsertModal();
            insertModal.ShowDialog();
        }

        private void UpdateClick(object sender, RoutedEventArgs e)
        {
            string id = (pessoaGrid.SelectedItem as Pessoa).IdPessoa;
            UpdateModal updateModal = new UpdateModal(id);
            updateModal.ShowDialog();
        }
    }
}
