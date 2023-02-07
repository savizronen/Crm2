public class KongFuWarrior : Warrior
{
    public override void animate()
    {
        System.Console.WriteLine("KongFuWarrior is moving");
    }

    public override void GoToTrain()
    {
        System.Console.WriteLine("KongFuWarrior is training");
    }
}