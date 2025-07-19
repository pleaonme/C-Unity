using System;

class Program
{
    static void Main(string[] args)
    {

        Player player = new Player();
        GameOverMenu gameOverMenu = new GameOverMenu(player);
        player.Die(); 
        
    }

    public class Player
    {
        public event Action? OnDeath; // Event to notify when the player dies

        public void Die()
        {
            OnDeath?.Invoke(); // Trigger the death event
        }
    }

    public class GameOverMenu
    {
        public GameOverMenu(Player player) // Constructor that takes a Player instance
        {
            player.OnDeath += Player_OnDeath; // Subscribe to the player's death event
        }

        private void Player_OnDeath() // Event handler for player death
        {
            Console.WriteLine("Game Over! You have died.");
        }
    }
}
