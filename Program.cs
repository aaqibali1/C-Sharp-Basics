internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string aFriend = "Aaqib ali";
        Console.WriteLine($"Hello {aFriend} ");
        string firstFriend = "Aaqib Ali";
        string secondFriend = "Ayaz Ali";
        Console.WriteLine($" My Friends Are {firstFriend} and {secondFriend} ");

        Console.WriteLine($" The name {firstFriend} has {firstFriend.Length} letters ");

        Console.WriteLine($" The name {secondFriend} has {secondFriend.Length} letters ");
    }
}