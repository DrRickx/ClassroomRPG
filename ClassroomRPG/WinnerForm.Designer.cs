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
            SuspendLayout();
            // 
            // WinnerLabel
            // 
            WinnerLabel.AutoSize = true;
            WinnerLabel.Font = new Font("Segoe UI", 40.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WinnerLabel.Location = new Point(87, 52);
            WinnerLabel.Name = "WinnerLabel";
            WinnerLabel.Size = new Size(621, 89);
            WinnerLabel.TabIndex = 0;
            WinnerLabel.Text = "!!!Congratulations!!!";
            // 
            // LabelWinnerMessage
            // 
            LabelWinnerMessage.AutoSize = true;
            LabelWinnerMessage.Location = new Point(243, 212);
            LabelWinnerMessage.Name = "label1";
            LabelWinnerMessage.Size = new Size(50, 20);
            LabelWinnerMessage.TabIndex = 1;
            LabelWinnerMessage.Text = "label1";
            // 
            // WinnerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}