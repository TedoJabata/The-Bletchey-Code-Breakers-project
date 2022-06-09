using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheBletcheyCodeBreakers.Controllers;
using TheBletcheyCodeBreakers.Model;

namespace TheBletcheyCodeBreakers.Views
{
    public partial class RegisterView : Form
    {
        RegisterController registerController = new RegisterController();

        public RegisterView()
        {
            InitializeComponent();
        }

        private void btnRegisterToHome_Click(object sender, EventArgs e)
        {
            HomeView home = new HomeView();
            home.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userChar = txtRegisterUsername.Text;
            string passChar = txtRegisterPassword.Text;

            int wonGames = 0;

            var userCharCount = userChar.Length;
            var passCharCount = passChar.Length;

            if (txtRegisterUsername.Text == "" || userCharCount > 10 || userCharCount < 3)
            {
                if (txtRegisterUsername.Text == "")
                {
                    MessageBox.Show("Empty Username");
                }
                else if(userCharCount > 10)
                {
                    MessageBox.Show("Please make your username less than 10 letters");
                }
                else if (userCharCount < 3)
                {
                    MessageBox.Show("Please make your username more than 3 letters");
                }
            }
            else
            {
                if (txtRegisterEmail.Text == "")
                {
                    MessageBox.Show("Empty Email");
                }
                else
                {
                    if (txtRegisterPassword.Text == "" || passCharCount < 3)
                    {
                        if (txtRegisterPassword.Text == "")
                        {
                            MessageBox.Show("Empty Password");
                        }
                        else if (passCharCount < 3)
                        {
                            MessageBox.Show("Password must be 3 or more characters");
                        }
                    }
                    else
                    {
                        Account acc = new Account();
                        Game gm = new Game();

                        acc.Username = txtRegisterUsername.Text;
                        acc.Password = txtRegisterPassword.Text;
                        acc.Email = txtRegisterEmail.Text;

                        gm.GamesPlayed = 0;
                        int lastUserId = registerController.AccountCreate(acc);
                        registerController.AccountGCreate(gm, lastUserId);

                        MessageBox.Show("Registered successfully!");

                        LoginView login = new LoginView();
                        login.Show();
                        this.Hide();
                    }
                }
            }

            
            
        }
    }
}
