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
        MainGameController controller = new MainGameController();
        public MainGameView()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.Text = "Restart";
            string[] nums = controller.GenerateNewNums();
        }

        private void btnTry_Click(object sender, EventArgs e)
        {
            History history = new History();

            history.Num_1 = num1.Text;
            history.Num_2 = num2.Text;
            history.Num_3 = num3.Text;
            history.Num_4 = num4.Text;

            controller.HistoryCreate(history);
            historyTable.DataSource = controller.GetAll();
            historyTable.ClearSelection();
        }

        private void MainGameView_Load(object sender, EventArgs e)
        {
            historyTable.DataSource = controller.GetAll();
        }
    }
}
