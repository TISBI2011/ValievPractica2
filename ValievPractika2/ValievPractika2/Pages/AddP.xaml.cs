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
        public AddP(Kino selKino)
        {
            InitializeComponent();
            ContKino = selKino;
            this.DataContext = ContKino;
        }
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ContKino.id == 0)
            {
                App.DB.Kino.Add(ContKino);
            }
            App.DB.SaveChanges();
            NavigationService.Navigate(new ListP());
        }
    }
}
