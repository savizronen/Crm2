public class SwordsWarrior : Warrior
{
    public override void animate()
    {
        System.Console.WriteLine("SwordsWarrior is moving");
    }

    public override void GoToTrain()
    {
        System.Console.WriteLine("SwordsWarrior is training");
    }


    public override void SomeMethod()
    {
        System.Console.WriteLine("inside SomeMethod SwordsWarrior");
    }

    public override void DoAnotherThing()
    {
        base.DoAnotherThing();
    }
}