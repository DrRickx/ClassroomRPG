namespace ClassroomRPG
{
    public partial class BattleForm : Form
    {
        private StudentHero? player1, player2;
        private bool isPlayer1Turn = true;

        private HealthBar player1HealthBar;
        private HealthBar player2HealthBar;

        //Reset Game Method
        private void ResetGame()
        {
            player1 = null;
            player2 = null;

            player1HealthBar.CurrentHealth = 0;
            player1HealthBar.MaxHealth = 100;
            player2HealthBar.CurrentHealth = 0;
            player2HealthBar.MaxHealth = 100;

            Player1Avatar.Image = null;
            Player2Avatar.Image = null;

            Player1NameInput.Text = "";
            Player2NameInput.Text = "";

            Player1ClassList.SelectedIndex = -1;
            Player2ClassList.SelectedIndex = -1;

            BattleLogScreen.Items.Clear();

            attackerName.Text = "What will you do?";

            StartButton.Enabled = true;
            StartButton.BackColor = SystemColors.Control;

            btnAttack.Enabled = false;

            isPlayer1Turn = true;
        }


        public BattleForm()
        {
            InitializeComponent();

            player1HealthBar = new HealthBar
            {
                Size = new Size(200, 25)
            };

            Player1InformationPanel.Controls.Add(player1HealthBar);

            player2HealthBar = new HealthBar
            {
                Size = new Size(200, 25)
            };

            Player2InformationPanel.Controls.Add(player2HealthBar);

            Player1ClassList.Items.AddRange(new string[] { "Fighter Nelson", "Paladin Alexander" });
            Player2ClassList.Items.AddRange(new string[] { "Fighter Nelson", "Paladin Alexander" });
            btnAttack.Enabled = false;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                string player1Name = Player1NameInput.Text.Trim();
                string? player1Class = Player1ClassList.SelectedItem?.ToString();

                string player2Name = Player2NameInput.Text.Trim();
                string? player2Class = Player2ClassList.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(player1Name) || string.IsNullOrEmpty(player2Name))
                {
                    throw new Exception("Both Players Name are required!");
                }

                if (string.IsNullOrEmpty(player1Class) || string.IsNullOrEmpty(player2Class))
                {
                    throw new Exception("Both Players must have a Class!");
                }

                player1 = createCharacter(player1Class, player1Name);
                player2 = createCharacter(player2Class, player2Name);

                Player1Avatar.Image = Image.FromFile(player1.SpritePath);

                Player2Avatar.Image = Image.FromFile(player2.SpritePath);

                attackerName.Text = $"What will you do, {player1Name}?";


                player1HealthBar.MaxHealth = player1.maxHealth;
                player1HealthBar.CurrentHealth = player1.health;

                player2HealthBar.MaxHealth = player2.maxHealth;
                player2HealthBar.CurrentHealth = player2.health;

                //Player1HealthBar.Maximum = player1.maxHealth;
                //Player1HealthBar.Value = player1.health;

                //Player2HealthBar.Maximum = player2.maxHealth;
                //Player2HealthBar.Value = player2.health;

                BattleLogScreen.Items.Clear();

                btnAttack.Enabled = true;
                isPlayer1Turn = true;

                StartButton.Enabled = false;
                StartButton.BackColor = Color.Gray;

                BattleLogScreen.Items.Add("Battle Started (Press attack to start offense!)");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private StudentHero createCharacter(string characterClass, string characterName)
        {
            return characterClass switch
            {
                "Fighter Nelson" => new Fighter(characterName),
                "Paladin Alexander" => new Paladin(characterName),
                _ => throw new Exception("Unknown character selected.")
            };
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (player1 == null || player2 == null) return;

            StudentHero attacker = isPlayer1Turn ? player1 : player2;
            StudentHero defender = isPlayer1Turn ? player2 : player1;

            attackerName.Text = $"What will you do, {defender.Name}?";

            int damage = attacker.Attack();
            defender.TakeDamage(damage);

            BattleLogScreen.Items.Add($"{attacker.Name} attacks {defender.Name} for {damage} damage!");

            player1HealthBar.CurrentHealth = player1.health;
            player2HealthBar.CurrentHealth = player2.health;

            //Player1HealthBar.Value = Math.Max(0, player1.health);
            //Player2HealthBar.Value = Math.Max(0, player2.health);

            BattleLogScreen.SelectedIndex = BattleLogScreen.Items.Count - 1;

            // Check for winner
            if (defender.health <= 0)
            {
                BattleLogScreen.Items.Add($"{attacker.Name} wins the battle!");
                BattleLogScreen.SelectedIndex = BattleLogScreen.Items.Count - 1;

                // Show WinnerForm using ShowDialog
                WinnerForm winForm = new WinnerForm(attacker.Name);

                if (winForm.ShowDialog() == DialogResult.OK)
                {
                    ResetGame();
                }


                btnAttack.Enabled = false;

                StartButton.Enabled = true;
                StartButton.BackColor = SystemColors.Control;

                return;
            }

            isPlayer1Turn = !isPlayer1Turn;
        }

        private void Player2Label_Click(object sender, EventArgs e)
        {

        }

        private void BattleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
