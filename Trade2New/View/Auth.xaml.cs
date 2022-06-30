using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace Trade2New.View
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        Trade2New_DBContext dBContext = new Trade2New_DBContext();
        public Auth()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var users = dBContext.Users.ToList();
            var roles = dBContext.Roles.ToList();

            if(txtLogin.Text == "")
            {
                MessageBox.Show("Не введен логин");
            }
            if (txtPassword.Password == "")
            {
                MessageBox.Show("Не введен пароль");
            }

            var user = users.FirstOrDefault(s => s.UserLogin == txtLogin.Text && s.UserPassword == txtPassword.Password);

            foreach(User u in users)
            {
                u.UserRoleNavigation = roles.FirstOrDefault(s => s.RoleId == user.UserRole);
            }

            if(user != null)
            {
                ProductsView products = new ProductsView(user);
                products.ShowDialog();
            }
        }

        private string text = "";

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();

            //Создадим изображение
            Bitmap result = new Bitmap(Width, Height);

            //Вычислим позицию текста
            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);

            //Добавим различные цвета

            //Укажем где рисовать
            Graphics g = Graphics.FromImage((System.Drawing.Image)result);

            //Пусть фон картинки будет серым
            g.Clear(System.Drawing.Color.Gray);

            //Сгенерируем текст
            text = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                text += ALF[rnd.Next(ALF.Length)];
            System.Drawing.Brush[] colors = { System.Drawing.Brushes.Black,
                    System.Drawing.Brushes.Red,
                     System.Drawing.Brushes.RoyalBlue,
                     System.Drawing.Brushes.Green };
            //Нарисуем сгенирируемый текст
            g.DrawString(text,
                         new Font("Arial", 15),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos)); 

            //Добавим немного помех
            /////Линии из углов
            g.DrawLine(Pens.Black,
                       new System.Drawing.Point(0, 0),
                       new System.Drawing.Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new System.Drawing.Point(0, Height - 1),
                       new System.Drawing.Point(Width - 1, 0));
            ////Белые точки
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, System.Drawing.Color.White);

            return result;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CreateCaptcha();
            
        }

        public string CaptchaValue { get; set; }

        public event System.EventHandler CaptchaRefreshed;

        private void CreateCaptcha()
        {
            string allowchar = string.Empty;
            allowchar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
            allowchar += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";
            allowchar += "1,2,3,4,5,6,7,8,9,0";
            char[] a = { ',' };
            string[] ar = allowchar.Split(a);
            string pwd = string.Empty;
            string temp = string.Empty;
            System.Random r = new System.Random();

            for (int i = 0; i < 6; i++)
            {
                temp = ar[(r.Next(0, ar.Length))];

                pwd += temp;
            }

            CaptchaText.Text = pwd;

            CaptchaValue = CaptchaText.Text;

            CaptchaRefreshed?.Invoke(this, System.EventArgs.Empty);
        }

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    string allowchar = " ";
        //    allowchar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";
        //    allowchar += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";
        //    allowchar += "1,2,3,4,5,6,7,8,9,0";
        //    char[] a = { ',' };
        //    string[] ar = allowchar.Split(a);
        //    string pwd = " ";
        //    string temp = " ";
        //    Random r = new Random();

        //    for (int i = 0; i < 6; i++)
        //    {
        //       temp = ar[(r.Next(0, ar.Length))];
        //       pwd += temp;
        //    }
        //    captchapic = pwd;
        //}
    }
}
