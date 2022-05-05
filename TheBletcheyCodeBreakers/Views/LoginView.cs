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
        GameController gameController = new GameController();

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
            string username = txtUsername.Text;
            string password = txtPass.Text;
            gameController.LogIn(username, password);





            MainGameView game = new MainGameView();
            game.Show();
            this.Hide();
        }
    }
}
