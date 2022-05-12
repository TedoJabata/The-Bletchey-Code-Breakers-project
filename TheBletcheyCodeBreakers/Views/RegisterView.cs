﻿using System;
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
    public partial class RegisterView : Form
    {
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
            var userCharCount = userChar.Length;
            if (txtRegisterUsername.Text == null || userCharCount > 10 || userCharCount < 3)
            {
                if (txtRegisterUsername.Text == null)
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
            else if (txtRegisterEmail.Text == null)
            {
                MessageBox.Show("Empty Email");
            }
            else if (txtRegisterPassword.Text == null)
            {
                MessageBox.Show("Empty Password");
            }
            else
            {
                Account acc = new Account();

                acc.Username = txtRegisterUsername.Text;
                acc.Password = txtRegisterPassword.Text;
                acc.Email = txtRegisterEmail.Text;

                registerController.AccountCreate(acc);
                MessageBox.Show("Registered successfully!");

                LoginView login = new LoginView();
                login.Show();
                this.Hide();
            }
            
        }
    }
}
