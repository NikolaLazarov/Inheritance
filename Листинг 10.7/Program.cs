using static System.Console;
//creating a new class
class Alpha
{
    //creating a variable field
    public int alpha;
    //creating a virtual mehtod
    public virtual void show()
    {
        //displaying the field
        WriteLine("Клас Alpha: {0}", alpha);
    }
    //creating a constructor
    public Alpha(int alpha)
    {
        //assigning the fields value
        this.alpha = alpha;
    }
}
//creating a new class that inherits form Alpha
class Bravo : Alpha
{
    //creating a variable field
    public int bravo;
    //creating an overloaded method from Alpha
    public override void show()
    {
        //displaying the fields of the derivative class and the inherited class
        WriteLine("Клас bravo: {0} и {1}", alpha, bravo);
    }
    //creating a constructor and it using the constructor form the inherited class
    public Bravo(int a, int b) : base(a)
    {
        //assigning the fields value
        bravo = b;
    }
}
//creating a class that inherits form Bravo
class Charlie : Bravo
{
    //creating a variable field
    public int charlie;
    //creating an overloaded method form Bravo
    public override void show()
    {
        //displaying the field of the derivative class and the inherited classes
        WriteLine("Клас Charlie: {0}, {1} и {2}", alpha, bravo, charlie);
    }
    //creating a constructor and using the constructor form the inherited class
    public Charlie(int a, int b, int c) : base(a, b)
    {
        //assigning the fields value
        charlie = c;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a new class object
        Alpha objA = new Alpha(10);
        //using the method show form the class Alpha
        objA.show();
        WriteLine();

        //creating a new class object
        Bravo objB = new Bravo(20, 30);
        //assigning the object variables value
        objA = objB;
        //using the method show form the class Alpha
        objA.show();
        //using the method show form the class Bravo
        objB.show();
        WriteLine();

        //creating a new class object
        Charlie objC = new Charlie(40, 50, 60);
        //assigning the object variables value
        objA = objC;
        //assigning the object variables value
        objB = objC;
        //using the method show form the class Alpha
        objA.show();
        //using the method show form the class Bravo
        objB.show();
        //using the method show form the class Charlie
        objC.show();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}