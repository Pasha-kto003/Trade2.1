using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trade2New.Core;
using Trade2New.db;

namespace Trade2New.ViewModel
{
    public class ProductsViewModel : BaseViewModel
    {
        Trade2New_DBContext dBContext = new Trade2New_DBContext();
        private List<Product> products { get; set; }
        public List<Product> Products
        {
            get => products; 
            set
            {
                products = value;
                SignalChanged();
            }
        }

        private List<Manufacturer> manufacturers { get; set; }
        public List<Manufacturer> Manufacturers
        {
            get => manufacturers;
            set
            {
                manufacturers = value;
                SignalChanged();
            }
        }

        private List<User> users { get; set; }
        public List<User> Users
        {
            get => users;
            set
            {
                users = value;
                SignalChanged();
            }
        }

        private List<Role> roles { get; set; }
        public List<Role> Roles
        {
            get => roles;
            set
            {
                roles = value;
                SignalChanged();
            }
        }

        private string searchText { get; set; }
        public string SearchText
        {
            get => searchText;
            set
            {
                searchText = value;
                Search();
            }
        }

        private List<string> searchType { get; set; }
        public List<string> SearchType
        {
            get => searchType;
            set
            {
                searchType = value;
                Search();
            }
        }

        public string UserRole { get; set; }

        private string selectedSearchType { get; set; }
        public string SelectedSearchType
        {
            get => selectedSearchType;
            set
            {
                selectedSearchType = value;
                Search();
            }
        }

        public string SearchCountRows { get; set; }

        public List<Product> searchResult { get; set; }

        public ProductsViewModel(User user)
        {
            Products = dBContext.Products.ToList();
            Users = dBContext.Users.ToList();
            Manufacturers = dBContext.Manufacturers.ToList();
            foreach(User u in Users)
            {
                u.UserRoleNavigation = Roles.FirstOrDefault(s => s.RoleId == u.UserRole);
            }
            UserRole = user.UserRoleNavigation.RoleName;
            foreach(Product product in Products)
            {
                product.Manufacturer = Manufacturers.FirstOrDefault(s => s.Id == product.ManufacturerId);
            }

            searchResult = dBContext.Products.ToList();
            InitPagination();
        }

        public void InitPagination()
        {
            SearchCountRows = $"Найдено записей: {searchResult.Count} из {dBContext.Products.Count()}";
        }

        public void Search()
        {

        }
    }
}
