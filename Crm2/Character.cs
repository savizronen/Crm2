public abstract class Character : IComparable
{
    string name;
    int level;

    public abstract void animate();

    public virtual void SomeMethod()
    {
        System.Console.WriteLine("inside SomeMethod Character");
    }

    private int DoSomething()
    {
        System.Console.WriteLine("inside DoSomething");
        return 10;
    }

    public virtual void DoAnotherThing()
    {
        int x = DoSomething();
        System.Console.WriteLine("inside DoAnotherThing Character");
    }

    public int CompareTo(object? obj)
    {
        if (obj == null)
        {
            return 1;
        }
        var thisWarriorPoints = ((Warrior)this).howManyPowerPoints;
        var otherWarriorPoints = ((Warrior)obj).howManyPowerPoints;
        if (this is NinjaWarrior)
        {
            thisWarriorPoints += 10;
        }
        if (obj is KongFuWarrior)
        {
            otherWarriorPoints += 5;
        }

        if (thisWarriorPoints > otherWarriorPoints)
            return 1;
        if (thisWarriorPoints < otherWarriorPoints)
            return -1;
        else
            return 0;
    }
}



   