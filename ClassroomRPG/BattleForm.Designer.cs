namespace ClassroomRPG
{
    partial class BattleForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            player1Label = new Label();
            Player2Label = new Label();
            Player1NameInput = new TextBox();
            Player2NameInput = new TextBox();
            Player1ClassLabel = new Label();
            Player2ClassLabel = new Label();
            Player1ClassList = new ComboBox();
            Player2ClassList = new ComboBox();
            StartButton = new Button();
            BattleLogScreen = new ListBox();
            Player1HealthLabel = new Label();
            Player2HealthLabel = new Label();
            Player1HealthValue = new Label();
            Player2HealthValue = new Label();
            btnAttack = new Button();
            SuspendLayout();
            // 
            // player1Label
            // 
            player1Label.AutoSize = true;
            player1Label.Location = new Point(12, 19);
            player1Label.Name = "player1Label";
            player1Label.Size = new Size(105, 20);
            player1Label.TabIndex = 0;
            player1Label.Text = "Player 1 name:";
            // 
            // Player2Label
            // 
            Player2Label.AutoSize = true;
            Player2Label.Location = new Point(269, 19);
            Player2Label.Name = "Player2Label";
            Player2Label.Size = new Size(105, 20);
            Player2Label.TabIndex = 1;
            Player2Label.Text = "Player 2 name:";
            // 
            // Player1NameInput
            // 
            Player1NameInput.Location = new Point(123, 16);
            Player1NameInput.Name = "Player1NameInput";
            Player1NameInput.Size = new Size(125, 27);
            Player1NameInput.TabIndex = 2;
            // 
            // Player2NameInput
            // 
            Player2NameInput.Location = new Point(380, 16);
            Player2NameInput.Name = "Player2NameInput";
            Player2NameInput.Size = new Size(125, 27);
            Player2NameInput.TabIndex = 3;
            // 
            // Player1ClassLabel
            // 
            Player1ClassLabel.AutoSize = true;
            Player1ClassLabel.Location = new Point(67, 50);
            Player1ClassLabel.Name = "Player1ClassLabel";
            Player1ClassLabel.Size = new Size(45, 20);
            Player1ClassLabel.TabIndex = 4;
            Player1ClassLabel.Text = "Class:";
            // 
            // Player2ClassLabel
            // 
            Player2ClassLabel.AutoSize = true;
            Player2ClassLabel.Location = new Point(329, 50);
            Player2ClassLabel.Name = "Player2ClassLabel";
            Player2ClassLabel.Size = new Size(45, 20);
            Player2ClassLabel.TabIndex = 5;
            Player2ClassLabel.Text = "Class:";
            // 
            // Player1ClassList
            // 
            Player1ClassList.FormattingEnabled = true;
            Player1ClassList.Location = new Point(123, 50);
            Player1ClassList.Name = "Player1ClassList";
            Player1ClassList.Size = new Size(125, 28);
            Player1ClassList.TabIndex = 6;
            // 
            // Player2ClassList
            // 
            Player2ClassList.FormattingEnabled = true;
            Player2ClassList.Location = new Point(380, 50);
            Player2ClassList.Name = "Player2ClassList";
            Player2ClassList.Size = new Size(125, 28);
            Player2ClassList.TabIndex = 7;
            // 
            // StartButton
            // 
            StartButton.Location = new Point(558, 19);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(94, 29);
            StartButton.TabIndex = 8;
            StartButton.Text = "Start Battle";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // BattleLogScreen
            // 
            BattleLogScreen.FormattingEnabled = true;
            BattleLogScreen.Location = new Point(12, 105);
            BattleLogScreen.Name = "BattleLogScreen";
            BattleLogScreen.Size = new Size(776, 184);
            BattleLogScreen.TabIndex = 9;
            // 
            // Player1HealthLabel
            // 
            Player1HealthLabel.AutoSize = true;
            Player1HealthLabel.Location = new Point(12, 344);
            Player1HealthLabel.Name = "Player1HealthLabel";
            Player1HealthLabel.Size = new Size(112, 20);
            Player1HealthLabel.TabIndex = 10;
            Player1HealthLabel.Text = "Player 1 Health:";
            // 
            // Player2HealthLabel
            // 
            Player2HealthLabel.AutoSize = true;
            Player2HealthLabel.Location = new Point(455, 344);
            Player2HealthLabel.Name = "Player2HealthLabel";
            Player2HealthLabel.Size = new Size(112, 20);
            Player2HealthLabel.TabIndex = 11;
            Player2HealthLabel.Text = "Player 2 Health:";
            // 
            // Player1HealthValue
            // 
            Player1HealthValue.AutoSize = true;
            Player1HealthValue.Location = new Point(130, 344);
            Player1HealthValue.Name = "Player1HealthValue";
            Player1HealthValue.Size = new Size(149, 20);
            Player1HealthValue.TabIndex = 12;
            Player1HealthValue.Text = "Player 1 Health Value";
            // 
            // Player2HealthValue
            // 
            Player2HealthValue.AutoSize = true;
            Player2HealthValue.Location = new Point(573, 344);
            Player2HealthValue.Name = "Player2HealthValue";
            Player2HealthValue.Size = new Size(149, 20);
            Player2HealthValue.TabIndex = 13;
            Player2HealthValue.Text = "Player 2 Health Value";
            // 
            // btnAttack
            // 
            btnAttack.Location = new Point(329, 295);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(94, 29);
            btnAttack.TabIndex = 14;
            btnAttack.Text = "ATTACK";
            btnAttack.UseVisualStyleBackColor = true;
            btnAttack.Click += btnAttack_Click;
            // 
            // BattleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAttack);
            Controls.Add(Player2HealthValue);
            Controls.Add(Player1HealthValue);
            Controls.Add(Player2HealthLabel);
            Controls.Add(Player1HealthLabel);
            Controls.Add(BattleLogScreen);
            Controls.Add(StartButton);
            Controls.Add(Player2ClassList);
            Controls.Add(Player1ClassList);
            Controls.Add(Player2ClassLabel);
            Controls.Add(Player1ClassLabel);
            Controls.Add(Player2NameInput);
            Controls.Add(Player1NameInput);
            Controls.Add(Player2Label);
            Controls.Add(player1Label);
            Name = "BattleForm";
            Text = "BattleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label player1Label;
        private Label Player2Label;
        private TextBox Player1NameInput;
        private TextBox Player2NameInput;
        private Label Player1ClassLabel;
        private Label Player2ClassLabel;
        private ComboBox Player1ClassList;
        private ComboBox Player2ClassList;
        private Button StartButton;
        private ListBox BattleLogScreen;
        private Label Player1HealthLabel;
        private Label Player2HealthLabel;
        private Label Player1HealthValue;
        private Label Player2HealthValue;
        private Button btnAttack;
    }
}
