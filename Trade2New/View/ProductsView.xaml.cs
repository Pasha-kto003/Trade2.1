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
using Trade2New.db;
using Trade2New.ViewModel;

namespace Trade2New.View
{
    /// <summary>
    /// Логика взаимодействия для ProductsView.xaml
    /// </summary>
    public partial class ProductsView : Window
    {
        public ProductsView(User user)
        {
            InitializeComponent();
            DataContext = new ProductsViewModel(user);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
