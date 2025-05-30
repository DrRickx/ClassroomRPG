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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleForm));
            StartButton = new Button();
            BattleLogScreen = new ListBox();
            btnAttack = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            attackerName = new Label();
            flowLayoutPanel5 = new FlowLayoutPanel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            Player2Avatar = new PictureBox();
            Player2InformationPanel = new FlowLayoutPanel();
            Player2Label = new Label();
            Player2NameInput = new TextBox();
            Player2ClassLabel = new Label();
            Player2ClassList = new ComboBox();
            Player2HealthLabel = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            Player1InformationPanel = new FlowLayoutPanel();
            player1Label = new Label();
            Player1NameInput = new TextBox();
            Player1ClassLabel = new Label();
            Player1ClassList = new ComboBox();
            Player1HealthLabel = new Label();
            Player1Avatar = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Player2Avatar).BeginInit();
            Player2InformationPanel.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            Player1InformationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Player1Avatar).BeginInit();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Font = new Font("Century Gothic", 9F);
            StartButton.Location = new Point(8, 8);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(94, 29);
            StartButton.TabIndex = 8;
            StartButton.Text = "Start Battle";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // BattleLogScreen
            // 
            BattleLogScreen.BorderStyle = BorderStyle.FixedSingle;
            BattleLogScreen.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BattleLogScreen.FormattingEnabled = true;
            BattleLogScreen.Location = new Point(8, 8);
            BattleLogScreen.Name = "BattleLogScreen";
            BattleLogScreen.Size = new Size(507, 102);
            BattleLogScreen.TabIndex = 9;
            // 
            // btnAttack
            // 
            btnAttack.Font = new Font("Century Gothic", 9F);
            btnAttack.Location = new Point(108, 8);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(94, 29);
            btnAttack.TabIndex = 14;
            btnAttack.Text = "ATTACK";
            btnAttack.UseVisualStyleBackColor = true;
            btnAttack.Click += btnAttack_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(BattleLogScreen);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 471);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(881, 119);
            flowLayoutPanel1.TabIndex = 21;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel4.Controls.Add(attackerName);
            flowLayoutPanel4.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(521, 8);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Padding = new Padding(10);
            flowLayoutPanel4.Size = new Size(333, 101);
            flowLayoutPanel4.TabIndex = 15;
            // 
            // attackerName
            // 
            attackerName.AutoSize = true;
            attackerName.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            attackerName.Location = new Point(13, 10);
            attackerName.Name = "attackerName";
            attackerName.Size = new Size(137, 18);
            attackerName.TabIndex = 0;
            attackerName.Text = "What will you do?";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel5.Controls.Add(StartButton);
            flowLayoutPanel5.Controls.Add(btnAttack);
            flowLayoutPanel5.Location = new Point(13, 31);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Padding = new Padding(5);
            flowLayoutPanel5.Size = new Size(224, 50);
            flowLayoutPanel5.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel3.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel3.Controls.Add(Player2Avatar);
            flowLayoutPanel3.Controls.Add(Player2InformationPanel);
            flowLayoutPanel3.Location = new Point(242, 246);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(10);
            flowLayoutPanel3.Size = new Size(613, 208);
            flowLayoutPanel3.TabIndex = 22;
            // 
            // Player2Avatar
            // 
            Player2Avatar.BorderStyle = BorderStyle.FixedSingle;
            Player2Avatar.Location = new Point(13, 13);
            Player2Avatar.Name = "Player2Avatar";
            Player2Avatar.Size = new Size(366, 180);
            Player2Avatar.TabIndex = 20;
            Player2Avatar.TabStop = false;
            // 
            // Player2InformationPanel
            // 
            Player2InformationPanel.AutoSize = true;
            Player2InformationPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Player2InformationPanel.BorderStyle = BorderStyle.FixedSingle;
            Player2InformationPanel.Controls.Add(Player2Label);
            Player2InformationPanel.Controls.Add(Player2NameInput);
            Player2InformationPanel.Controls.Add(Player2ClassLabel);
            Player2InformationPanel.Controls.Add(Player2ClassList);
            Player2InformationPanel.Controls.Add(Player2HealthLabel);
            Player2InformationPanel.FlowDirection = FlowDirection.TopDown;
            Player2InformationPanel.Location = new Point(385, 13);
            Player2InformationPanel.Name = "Player2InformationPanel";
            Player2InformationPanel.Padding = new Padding(10);
            Player2InformationPanel.Size = new Size(213, 143);
            Player2InformationPanel.TabIndex = 18;
            // 
            // Player2Label
            // 
            Player2Label.AutoSize = true;
            Player2Label.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Player2Label.Location = new Point(13, 10);
            Player2Label.Name = "Player2Label";
            Player2Label.Size = new Size(117, 18);
            Player2Label.TabIndex = 1;
            Player2Label.Text = "Player 2 name:";
            Player2Label.Click += Player2Label_Click;
            // 
            // Player2NameInput
            // 
            Player2NameInput.Location = new Point(13, 31);
            Player2NameInput.Name = "Player2NameInput";
            Player2NameInput.Size = new Size(125, 27);
            Player2NameInput.TabIndex = 3;
            // 
            // Player2ClassLabel
            // 
            Player2ClassLabel.AutoSize = true;
            Player2ClassLabel.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            Player2ClassLabel.Location = new Point(13, 61);
            Player2ClassLabel.Name = "Player2ClassLabel";
            Player2ClassLabel.Size = new Size(50, 18);
            Player2ClassLabel.TabIndex = 5;
            Player2ClassLabel.Text = "Class:";
            // 
            // Player2ClassList
            // 
            Player2ClassList.FormattingEnabled = true;
            Player2ClassList.Location = new Point(13, 82);
            Player2ClassList.Name = "Player2ClassList";
            Player2ClassList.Size = new Size(185, 28);
            Player2ClassList.TabIndex = 7;
            // 
            // Player2HealthLabel
            // 
            Player2HealthLabel.AutoSize = true;
            Player2HealthLabel.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            Player2HealthLabel.Location = new Point(13, 113);
            Player2HealthLabel.Name = "Player2HealthLabel";
            Player2HealthLabel.Size = new Size(59, 18);
            Player2HealthLabel.TabIndex = 11;
            Player2HealthLabel.Text = "Health:";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Controls.Add(Player1InformationPanel);
            flowLayoutPanel2.Controls.Add(Player1Avatar);
            flowLayoutPanel2.Location = new Point(9, 12);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(10);
            flowLayoutPanel2.Size = new Size(615, 207);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // Player1InformationPanel
            // 
            Player1InformationPanel.AutoSize = true;
            Player1InformationPanel.BorderStyle = BorderStyle.FixedSingle;
            Player1InformationPanel.Controls.Add(player1Label);
            Player1InformationPanel.Controls.Add(Player1NameInput);
            Player1InformationPanel.Controls.Add(Player1ClassLabel);
            Player1InformationPanel.Controls.Add(Player1ClassList);
            Player1InformationPanel.Controls.Add(Player1HealthLabel);
            Player1InformationPanel.FlowDirection = FlowDirection.TopDown;
            Player1InformationPanel.Location = new Point(13, 13);
            Player1InformationPanel.Name = "Player1InformationPanel";
            Player1InformationPanel.Padding = new Padding(10);
            Player1InformationPanel.Size = new Size(213, 143);
            Player1InformationPanel.TabIndex = 17;
            // 
            // player1Label
            // 
            player1Label.AutoSize = true;
            player1Label.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            player1Label.Location = new Point(13, 10);
            player1Label.Name = "player1Label";
            player1Label.Size = new Size(117, 18);
            player1Label.TabIndex = 0;
            player1Label.Text = "Player 1 name:";
            // 
            // Player1NameInput
            // 
            Player1NameInput.Location = new Point(13, 31);
            Player1NameInput.Name = "Player1NameInput";
            Player1NameInput.Size = new Size(125, 27);
            Player1NameInput.TabIndex = 2;
            // 
            // Player1ClassLabel
            // 
            Player1ClassLabel.AutoSize = true;
            Player1ClassLabel.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            Player1ClassLabel.Location = new Point(13, 61);
            Player1ClassLabel.Name = "Player1ClassLabel";
            Player1ClassLabel.Size = new Size(50, 18);
            Player1ClassLabel.TabIndex = 4;
            Player1ClassLabel.Text = "Class:";
            // 
            // Player1ClassList
            // 
            Player1ClassList.FormattingEnabled = true;
            Player1ClassList.Location = new Point(13, 82);
            Player1ClassList.Name = "Player1ClassList";
            Player1ClassList.Size = new Size(185, 28);
            Player1ClassList.TabIndex = 6;
            // 
            // Player1HealthLabel
            // 
            Player1HealthLabel.AutoSize = true;
            Player1HealthLabel.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            Player1HealthLabel.Location = new Point(13, 113);
            Player1HealthLabel.Name = "Player1HealthLabel";
            Player1HealthLabel.Size = new Size(59, 18);
            Player1HealthLabel.TabIndex = 10;
            Player1HealthLabel.Text = "Health:";
            // 
            // Player1Avatar
            // 
            Player1Avatar.BackgroundImageLayout = ImageLayout.Center;
            Player1Avatar.BorderStyle = BorderStyle.FixedSingle;
            Player1Avatar.Location = new Point(232, 13);
            Player1Avatar.Name = "Player1Avatar";
            Player1Avatar.Size = new Size(368, 179);
            Player1Avatar.TabIndex = 19;
            Player1Avatar.TabStop = false;
            // 
            // BattleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(881, 590);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "BattleForm";
            Text = "BattleForm";
            Load += BattleForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Player2Avatar).EndInit();
            Player2InformationPanel.ResumeLayout(false);
            Player2InformationPanel.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            Player1InformationPanel.ResumeLayout(false);
            Player1InformationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Player1Avatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button StartButton;
        private ListBox BattleLogScreen;
        private Button btnAttack;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label attackerName;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel Player2InformationPanel;
        private Label Player2Label;
        private TextBox Player2NameInput;
        private Label Player2ClassLabel;
        private ComboBox Player2ClassList;
        private Label Player2HealthLabel;
        private PictureBox Player2Avatar;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel Player1InformationPanel;
        private Label player1Label;
        private TextBox Player1NameInput;
        private Label Player1ClassLabel;
        private ComboBox Player1ClassList;
        private Label Player1HealthLabel;
        private PictureBox Player1Avatar;
    }
}
