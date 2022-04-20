using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBletcheyCodeBreakers.Views
{
    public partial class HomeView : Form
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void btnWelcomeLogin_Click(object sender, EventArgs e)
        {
            LoginView login = new LoginView();
            login.Show();
            this.Hide();
        }

        private void btnWelcomeRegister_Click(object sender, EventArgs e)
        {
            RegisterView register = new RegisterView();
            register.Show();
            this.Hide();
        }
    }
}
