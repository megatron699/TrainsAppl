using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainsApp.DAL;
using TrainsAppl.Models;

namespace TrainsAppl.Views
{
    public partial class RegView : Form
    {
        private readonly TrainDBContext _context = new TrainDBContext();
        public RegView()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginBox.TextLength < 3 || LoginBox.TextLength > 10) throw new Exception("Логин должен быть от 3 до 10 символов");
                else
                if (_context.Users.FirstOrDefault(c => c.Username == LoginBox.Text) != null) throw new Exception("Пользователь с таким логином уже существует");
                else
                if (PassBox.TextLength < 6 || PassBox.TextLength > 10) throw new Exception("Пароль должен быть от 6 до 10 символов");
                else
                if (PassBox.Text != ConfirmBox.Text) throw new Exception("Пароли не совпадают");
                else
                {
                    UserDB newUser = new UserDB
                    {
                        Username = LoginBox.Text,
                        Password = PassBox.Text,
                        Role = checkRole.Checked
                    };
                    _context.Users.Add(newUser);
                    _context.SaveChanges();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
     
    }
}
