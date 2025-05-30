namespace ClassroomRPG
{
    partial class WinnerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            WinnerLabel = new Label();
            LabelWinnerMessage = new Label();
            btnResetGame = new Button();
            SuspendLayout();
            // 
            // WinnerLabel
            // 
            WinnerLabel.AutoSize = true;
            WinnerLabel.FlatStyle = FlatStyle.System;
            WinnerLabel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WinnerLabel.Location = new Point(121, 79);
            WinnerLabel.Name = "WinnerLabel";
            WinnerLabel.Size = new Size(559, 81);
            WinnerLabel.TabIndex = 0;
            WinnerLabel.Text = "!!!Congratulations!!!";
            // 
            // LabelWinnerMessage
            // 
            LabelWinnerMessage.AccessibleRole = AccessibleRole.None;
            LabelWinnerMessage.AutoSize = true;
            LabelWinnerMessage.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelWinnerMessage.Location = new Point(147, 198);
            LabelWinnerMessage.Name = "LabelWinnerMessage";
            LabelWinnerMessage.Size = new Size(511, 81);
            LabelWinnerMessage.TabIndex = 1;
            LabelWinnerMessage.Text = "You win {winner}";
            LabelWinnerMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnResetGame
            // 
            btnResetGame.Location = new Point(339, 309);
            btnResetGame.Name = "btnResetGame";
            btnResetGame.Size = new Size(122, 29);
            btnResetGame.TabIndex = 2;
            btnResetGame.Text = "PLAY AGAIN";
            btnResetGame.UseVisualStyleBackColor = true;
            btnResetGame.Click += btnResetGame_Click;
            // 
            // WinnerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnResetGame);
            Controls.Add(LabelWinnerMessage);
            Controls.Add(WinnerLabel);
            Name = "WinnerForm";
            Text = "WinnerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WinnerLabel;
        private Label LabelWinnerMessage;
        private Button btnResetGame;
    }
}