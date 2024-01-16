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
    public partial class RegisterView : Form
    {
        MainController mainController = new MainController();
        public RegisterView()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainView m = new MainView();
            m.Show();
            Hide();
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void btnRegView_Click(object sender, EventArgs e)
        {
            var username= txtUserName.Text;
            var password=txtPassword.Text;
            if (username==null||password==null)
            {
                MessageBox.Show("username or password cannot be empty");
            }
            else
            {
                MessageBox.Show("Registration succsessfull");
                mainController.RegisterUser(username, password);
                MainView login = new MainView();
                login.Show();
                Hide();
            }
            
        }
    }
}
