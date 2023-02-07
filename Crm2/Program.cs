List<Warrior> warriors = new List<Warrior>
        { // 20 25 25 10
            new NinjaWarrior { howManyPowerPoints = 10 },
            new KongFuWarrior { howManyPowerPoints = 20 },
            new NinjaWarrior { howManyPowerPoints = 15 },
            new KongFuWarrior { howManyPowerPoints = 5 }
        };

warriors.Sort();
Console.WriteLine("Sorted Warriors:");
foreach (var warrior in warriors)
{
    if (warrior is NinjaWarrior)
    {
        Console.WriteLine($"Ninja Warrior: {warrior.howManyPowerPoints + 10}");
    }
    else
    {
        Console.WriteLine($"Kong Fu Warrior: {warrior.howManyPowerPoints + 5}");
    }
}

Console.WriteLine("Enter an email address: ");
string email = Console.ReadLine();

try
{
    if (!email.Contains("@"))
    {
        throw new FormatException("Email address must contain the '@' symbol.");
    }

    Console.WriteLine("Email address is valid.");
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}



var wed = new WeddingDress(-5);

