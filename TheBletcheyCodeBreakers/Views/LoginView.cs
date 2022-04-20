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
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnLoginToHome_Click(object sender, EventArgs e)
        {
            HomeView home = new HomeView();
            home.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainGameView game = new MainGameView();
            game.Show();
            this.Hide();
        }
    }
}
