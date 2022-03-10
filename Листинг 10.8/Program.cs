using static System.Console;
//creating a new class
class Alpha
{
    //creating a public method
    public void hello()
    {
        WriteLine("Method hello form class Alpha.");
    }
    //creating a virtual method
    public virtual void hi()
    {
        WriteLine("Method hi form class Alpha.");
    }
    //creating a public method
    public void show()
    {
        //using the method hello
        hello();
        //using the method hi
        hi();
        WriteLine();
    }
}
//creating a class that inherits form Alpha
class Bravo : Alpha
{
    //replacing the method hello()
    new public void hello()
    {
        WriteLine("Method hello form class Bravo.");
    }
    //overloading the hi method
    public override void hi()
    {
        WriteLine("Method hi form class Bravo.");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a new class object
        Alpha A = new Alpha();
        WriteLine("A.show(): ");
        //using the method show from Alpha
        A.show();

        //creating a new class object
        Bravo B = new Bravo();
        WriteLine("B.hello(): ");
        //using the method hello from Bravo
        B.hello();
        WriteLine("B.hi(): ");
        //using the method hello from Bravo
        B.hi();
        WriteLine("B.show(): ");
        //using the method show from Bravo
        B.show();

        //assigning the object variable(A)s value 
        A = B;
        WriteLine("A.hello(): ");
        //using the method hello from Alpha
        A.hello();
        WriteLine("A.hi(): ");
        //using the method hi from Alpha
        A.hi();
        WriteLine("A.show: ");
        //using the method show from Alpha
        A.show();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}