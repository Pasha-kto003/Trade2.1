using System;
using System.Collections.Generic;
using System.IO;
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
using Trade2New.db;

namespace Trade2New
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Trade2New_DBContext dBContext = new Trade2New_DBContext();
        public MainWindow()
        {
            InitializeComponent();

            //string path = @"C:\Users\79249\Downloads\09_1.1-2022_4\Вариант 4\Вариант 4\Сессия 1\Товар_import\Товар_import_Стройматериалы.csv";
            //var rows = File.ReadAllLines(path);
            //var products = dBContext.Products.ToList();
            //var categories = dBContext.Categories.ToList();
            //var manufacturers = dBContext.Manufacturers.ToList();
            //var suppliers = dBContext.Suppliers.ToList();
            //var statuses = dBContext.Statuses.ToList();

            //for(int i = 1; i < rows.Length; i++)
            //{
            //    var cols = rows[i].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            //    var category = categories.FirstOrDefault(s => s.Title == cols[7]);
            //    if(category == null)
            //    {
            //        category = new Category { Title = cols[7] };
            //        dBContext.Categories.Add(category);
            //        dBContext.SaveChanges();
            //    }

            //    var supplier = suppliers.FirstOrDefault(s => s.Title == cols[6]);

            //    if(supplier == null)
            //    {
            //        supplier = new Supplier { Title = cols[6] };
            //        dBContext.Suppliers.Add(supplier);
            //        dBContext.SaveChanges();
            //    }

            //    var manufacturer = manufacturers.FirstOrDefault(s => s.Title == cols[5]);
            //    if(manufacturer == null)
            //    {
            //        manufacturer = new Manufacturer { Title = cols[5] };
            //        dBContext.Manufacturers.Add(manufacturer);
            //        dBContext.SaveChanges();
            //    }

            //    dBContext.Products.Add(new Product
            //    {
            //        ProductArticleNumber = cols[0],
            //        ProductName = cols[1],
            //        Status = statuses.FirstOrDefault(s => s.Title == cols[2]),
            //        ProductCost = decimal.Parse(cols[3]),
            //        MaxDiscount = int.Parse(cols[4]),
            //        ManufacturerId = manufacturer.Id,
            //        SupplierId = supplier.Id,
            //        CategoryId = category.Id,
            //        ProductDiscountAmount = byte.Parse(cols[8]),
            //        ProductQuantityInStock = int.Parse(cols[9]),
            //        ProductDescription = cols[10],
            //        ProductPhoto = File.ReadAllBytes(@"C:\Users\79249\Downloads\09_1.1-2022_4\Вариант 4\Вариант 4\Сессия 1\Товар_import\" + cols[11])
            //    });

            //    dBContext.SaveChanges();
            //}

            //string path = @"C:\Users\79249\Downloads\09_1.1-2022_4\Вариант 4\Вариант 4\Сессия 1\user_import.csv";

            //var rows = File.ReadAllLines(path);
            //var users = dBContext.Users.ToList();
            //var roles = dBContext.Roles.ToList();

            //for(int i = 1; i < rows.Length; i++)
            //{
            //    var cols = rows[i].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            //    dBContext.Users.Add(new User
            //    {
            //        UserRoleNavigation = roles.FirstOrDefault(s=> s.RoleName == cols[0]),
            //        UserSurname = cols[1],
            //        UserName = cols[2],
            //        UserPatronymic = cols[3],
            //        UserLogin = cols[4],
            //        UserPassword = cols[5]
            //    });
            //}
            //dBContext.SaveChanges();
        }
    }
}
