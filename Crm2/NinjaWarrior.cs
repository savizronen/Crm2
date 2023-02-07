public class NinjaWarrior : Warrior
{

    public override void animate()
    {
        System.Console.WriteLine("NinjaWarrior is moving");
    }

    public override void GoToTrain()
    {
        System.Console.WriteLine(howManyPowerPoints);
        base.MyMethod();
        System.Console.WriteLine("NinjaWarrior is training");
    }

}