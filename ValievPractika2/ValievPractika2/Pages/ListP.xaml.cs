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

namespace ValievPractika2.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListP.xaml
    /// </summary>
    public partial class ListP : Page
    {
        public ListP()
        {
            InitializeComponent();
            DgridView.ItemsSource = App.DB.Kino.ToList();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddP(new Kino()));
        }

        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            var selKino = DgridView.SelectedItem as Kino;
            if (selKino != null)
            {
                App.DB.Kino.Remove(selKino);
                App.DB.SaveChanges();
            }
            else MessageBox.Show("Ничего не выбрано");
            DgridView.ItemsSource = App.DB.Kino.ToList();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedKino = DgridView.SelectedItem as Kino;
            if (selectedKino == null)
            {
                MessageBox.Show("Ничегоне выбрано");
                return;
            }
            NavigationService.Navigate(new AddP(selectedKino));
        }

        private void DgridView_Loaded(object sender, RoutedEventArgs e)
        {
            DgridView.ItemsSource = App.DB.Kino.ToList();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
