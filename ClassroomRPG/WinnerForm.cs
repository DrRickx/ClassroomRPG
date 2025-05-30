using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassroomRPG
{
    public partial class WinnerForm : Form
    {
        public WinnerForm(string winnerName)
        {
            InitializeComponent();
            LabelWinnerMessage.Text = $"You win {winnerName}";
        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
