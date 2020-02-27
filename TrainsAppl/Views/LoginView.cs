using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainsAppl.DAL;


namespace TrainsAppl.Views
{
    public partial class LoginView : Form 
    {
        private readonly TrainDBContext _context = new TrainDBContext();
        public LoginView()
        {
            //_context.Users.First(c => c.Id == 1);
            InitializeComponent();
        }

        public MainView MainView
        {
            get => default;
            set
            {
            }
        }

        public RegView RegView
        {
            get => default;
            set
            {
            }
        }

        public Models.DB.UserDB UserDB
        {
            get => default;
            set
            {
            }
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegView regView = new RegView();
            regView.ShowDialog();
            this.Show();
            //regView.Close();
            //MainView mainView = new MainView();
            //mainView.ShowDialog();C:\Users\пк\source\repos\TrainsAppl\TrainsAppl\Views\LoginView.cs
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try 
            { 
                var userInDB = _context.Users.FirstOrDefault(user => user.Username == LoginBox.Text && user.Password == PassBox.Text);
                if (userInDB != null)
                {
                    this.Hide();
                    MainView mainView = new MainView(userInDB.Role);
                    mainView.ShowDialog();
                    this.Show();
                }
                else throw new Exception("Неверный логин и/или пароль");
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message,"Ошибка Аутентификации:");
            }
        }
    }
}
