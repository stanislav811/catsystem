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
    public partial class LoginView : Form
    {
        MainController mainController=new MainController();
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = mainController.GetAllUsers();
        }
    }
}
