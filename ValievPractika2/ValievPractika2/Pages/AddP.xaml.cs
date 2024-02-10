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
    /// Логика взаимодействия для AddP.xaml
    /// </summary>
    public partial class AddP : Page
    {
        public Kino ContKino;
        Kino contextKino;
        public AddP(Kino kino)
        {
            InitializeComponent();
            contextKino = kino;
            DataContext = contextKino;
            CBGenre.ItemsSource = App.DB.Genre.ToList();
        }
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (contextKino.id == 0)
                    App.DB.Kino.Add(contextKino);

                App.DB.SaveChanges();
                NavigationService.GoBack();

            }
            catch
            {
                MessageBox.Show("Zapolnite vse polya");
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
