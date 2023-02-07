public abstract class Warrior : Character
{
    public int howManyPowerPoints;
    public abstract void GoToTrain();

    // public override void SomeMethod()
    // {
    //     System.Console.WriteLine("inside SomeMethod Warrior");
    // }

    protected void MyMethod()
    {
    }

    public void MyMethod2()
    {
        MyMethod();
    }

}