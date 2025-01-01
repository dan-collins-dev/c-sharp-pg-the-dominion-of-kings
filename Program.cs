namespace TheDominionOfKings;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("How many provinces do you have: ");
        int numOfProvinces = Convert.ToInt32(Console.ReadLine());

        Console.Write("How many duchies do you have: ");
        int numOfDuchies = Convert.ToInt32(Console.ReadLine());

        Console.Write("How many estates do you have: ");
        int numOfEstates = Convert.ToInt32(Console.ReadLine());

        int totalPoints = (numOfProvinces * 6) + (numOfDuchies * 3) + (numOfEstates * 1);

        Console.WriteLine($"Your point total is: {totalPoints}");
    }
}
