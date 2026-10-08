using BlaisePascal.ExercisePlayer.Domain;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Player player1 = new Player("Fabio");
            player1.AddExperience(120);
            player1.TakeDamage(250);
            player1.Heal(50);
            player1.AddGOld(157);


            Console.WriteLine($"Player Name: {player1.Name}");
            Console.WriteLine($"Player Level: {player1.Level}");
            Console.WriteLine($"Player Experience: {player1.Experience}");
            Console.WriteLine($"Player Health: {player1.Health}");
            Console.WriteLine($"Player Max Health: {player1.MaxHealth}");
            Console.WriteLine($"Player Gold: {player1.Gold}");
            Console.WriteLine($"Player Is Alive: {player1.IsAlive}");

        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error message: {ex.Message}");
        }
    }
}