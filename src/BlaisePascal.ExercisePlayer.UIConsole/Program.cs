using BlaisePascal.ExercisePlayer.Domain;

public class Program
{
    public static void Main(string[] args)
    {
        Player player1 = new Player("Fabio");
        Console.WriteLine($"Player Name: {player1.Name}");
    }
}