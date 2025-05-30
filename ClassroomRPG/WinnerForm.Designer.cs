﻿namespace ClassroomRPG
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
            WinnerLabel.BackColor = Color.White;
            WinnerLabel.FlatStyle = FlatStyle.System;
            WinnerLabel.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WinnerLabel.Location = new Point(99, 33);
            WinnerLabel.Name = "WinnerLabel";
            WinnerLabel.Size = new Size(601, 74);
            WinnerLabel.TabIndex = 0;
            WinnerLabel.Text = "!!!Congratulations!!!";
            WinnerLabel.TextAlign = ContentAlignment.TopCenter;
            WinnerLabel.Click += WinnerLabel_Click;
            // 
            // LabelWinnerMessage
            // 
            LabelWinnerMessage.AccessibleRole = AccessibleRole.None;
            LabelWinnerMessage.AutoSize = true;
            LabelWinnerMessage.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelWinnerMessage.Location = new Point(126, 141);
            LabelWinnerMessage.Name = "LabelWinnerMessage";
            LabelWinnerMessage.Size = new Size(504, 70);
            LabelWinnerMessage.TabIndex = 1;
            LabelWinnerMessage.Text = "You win {winner}";
            LabelWinnerMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnResetGame
            // 
            btnResetGame.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResetGame.Location = new Point(296, 295);
            btnResetGame.Name = "btnResetGame";
            btnResetGame.Padding = new Padding(5);
            btnResetGame.Size = new Size(170, 56);
            btnResetGame.TabIndex = 2;
            btnResetGame.Text = "PLAY AGAIN";
            btnResetGame.UseVisualStyleBackColor = true;
            btnResetGame.Click += btnResetGame_Click;
            // 
            // WinnerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(800, 370);
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