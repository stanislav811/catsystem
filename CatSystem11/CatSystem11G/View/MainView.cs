using CatSystem11G.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatSystem11G.View
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        MainController mainController = new MainController();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUserName.Text;
            var password = txtPassword.Text;
            var isRegisterd = mainController.CheckIfRegistered(username, password);
            if (isRegisterd) 
            {
                LoginView l = new LoginView();
                l.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Wrong Username or Password!");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterView r = new RegisterView();
            r.Show();
            Hide();
        }
    }
}
