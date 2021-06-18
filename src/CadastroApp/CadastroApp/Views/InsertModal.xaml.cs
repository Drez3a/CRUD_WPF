using CadastroApp.Domain.Models;
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
    /// Interaction logic for InsertModal.xaml
    /// </summary>
    public partial class InsertModal : Window
    {
        PessoaRepository _pessoaRepository = new PessoaRepository();

        public InsertModal()
        {
            InitializeComponent();
        }

        private void InsertClick(object sender, RoutedEventArgs e)
        {
            Pessoa pessoa = new Pessoa()
            {
                IdPessoa = Guid.NewGuid().ToString(),
                Nome = nametextBox.Text,
                Genero = gendercomboBox.Text
            };

            _pessoaRepository.CreatePessoa(pessoa);

            MainWindow.MainGrid.ItemsSource = _pessoaRepository.GetAllPessoas().ToList();
            this.Hide();
        }
    }
}
