namespace ClassroomRPG
{
    public partial class BattleForm : Form
    {
        private StudentHero? player1, player2;
        private bool isPlayer1Turn = true;

        public BattleForm()
        {
            InitializeComponent();
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

                Player1HealthValue.Text = $"Health: {player1.health}";
                Player2HealthValue.Text = $"Health: {player2.health}";
                BattleLogScreen.Items.Clear();

                btnAttack.Enabled = true;
                isPlayer1Turn = true;

                MessageBox.Show("Battle started! Click 'Attack' to take turns.", "Start", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

            int damage = attacker.Attack();
            defender.TakeDamage(damage);

            BattleLogScreen.Items.Add($"{attacker.Name} attacks {defender.Name} for {damage} damage!");

            Player1HealthValue.Text = $"Health: {player1.health}";
            Player2HealthValue.Text = $"Health: {player2.health}";

            BattleLogScreen.SelectedIndex = BattleLogScreen.Items.Count - 1;

            // Check for winner
            if (defender.health <= 0)
            {
                BattleLogScreen.Items.Add($"{attacker.Name} wins the battle!");
                BattleLogScreen.SelectedIndex = BattleLogScreen.Items.Count - 1;

                // Show WinnerForm using ShowDialog
                WinnerForm winForm = new WinnerForm(attacker.Name);
                winForm.ShowDialog();

                btnAttack.Enabled = false;

                return;
            }

            isPlayer1Turn = !isPlayer1Turn;
        }

    }
}
