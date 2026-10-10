using BlaisePascal.ExercisePlayer.Domain;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Insert the username of the player:");
            string name = Console.ReadLine();
            Player player1 = new Player(name);
            Console.WriteLine("Insert the experince to add to the player:");
            int experienceToAdd = int.Parse(Console.ReadLine());
            player1.AddExperience(experienceToAdd);
            Console.WriteLine("Insert the damage to take from the player:");
            int damageToTake = int.Parse(Console.ReadLine());
            player1.TakeDamage(damageToTake);
            Console.WriteLine("Insert the amount of healht to add to the player:");
            int healthToAdd = int.Parse(Console.ReadLine());
            player1.Heal(healthToAdd);
            Console.WriteLine("Insert the amount of gold to add to the player:");
            int goldToAdd = int.Parse(Console.ReadLine());
            player1.AddGOld(goldToAdd);


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