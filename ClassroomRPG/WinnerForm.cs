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


            CenterLabel();

            this.Resize += (s, e) => CenterLabel();
            this.FormClosed += WinnerForm_FormClosed;
        }

        private void CenterLabel()
        {
            LabelWinnerMessage.Left = (this.ClientSize.Width - LabelWinnerMessage.Width) / 2;
            LabelWinnerMessage.Top = (this.ClientSize.Height - LabelWinnerMessage.Height) / 2;
        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void WinnerForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
            {
                Application.Exit(); // Exit app if closed with X
            }
        }

        private void WinnerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
