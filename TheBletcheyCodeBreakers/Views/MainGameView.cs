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
    public partial class MainGameView : Form
    {
        List<HistoryModel> list = new List<HistoryModel>();
        MainGameController controller = new MainGameController();

        string username = "";

        public static int playedGames = 0;

        bool inGame = false;
        bool gameWon = false;

        public MainGameView(string user)
        {
            username = user;
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            inGame = true;
            lblWin.Text = "";
            if (gameWon == true)
            {
                lblWin.Text = "";
                gameWon = false;
            }
            btnPlay.Text = "Restart";
            string[] nums = controller.GenerateNewNums();
            historyTable.DataSource = null;
            list.Clear();
            lblWins.Text = controller.PlayedGames();
        }

        private void btnTry_Click(object sender, EventArgs e)
        {
            if (inGame)
            {
                HistoryModel history = new HistoryModel();

                history.Number_1 = num1.Text;
                history.Number_2 = num2.Text;
                history.Number_3 = num3.Text;
                history.Number_4 = num4.Text;
                
                bool is1Numeric = int.TryParse(num1.Text, out _);
                bool is2Numeric = int.TryParse(num2.Text, out _);
                bool is3Numeric = int.TryParse(num3.Text, out _);
                bool is4Numeric = int.TryParse(num4.Text, out _);

                if (num1.Text == num2.Text || num1.Text == num3.Text || num1.Text == num4.Text || num2.Text == num3.Text || num2.Text == num4.Text || num3.Text == num4.Text)
                {
                    lblWin.Text = "diff nums pls";
                }
                else if (is1Numeric == false || is2Numeric == false || is3Numeric == false || is4Numeric == false)
                {
                    lblWin.Text = "only nums pls";
                }
                else
                {
                    lblWin.Text = "";
                    list.Add(history);
                    historyTable.DataSource = null;
                    historyTable.DataSource = list;
                    string[] bnc = controller.UpdateLabels(num1.Text, num2.Text, num3.Text, num4.Text);
                    lblBulls.Text = $"Bulls: {bnc[0]}";
                    lblCows.Text = $"Cows: {bnc[1]}";

                    if (bnc[0] == "4")
                    {
                        lblWin.Text = "You Win!";
                        inGame = false;
                        gameWon = true;
                    }
                }
            }
            else
            {
                lblWin.Text = "Start the game dude"; ;
            }
        }

        private void MainGameView_Load(object sender, EventArgs e)
        {
            lblLoggedUser.Text = $"Hello {username}";
            lblWin.Text = "You haven't played any games yet";
        }
    }
}