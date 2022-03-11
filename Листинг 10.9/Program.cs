using static System.Console;
//creating a new class
class Alpha
{
    //creating a variable field
    public int alpha;
    //creating a public method
    public void set()
    {
        //assigning the fields value
        alpha = 10;
        //display the field
        WriteLine("Alpha (без аргументи): {0}", alpha);
    }
    //creating a public virtual method
    public virtual void set(int n)
    {
        //assigning the fields value to the arguments
        alpha = n;
        //display the field
        WriteLine("Alpha (един аргумент): {0}", alpha);
    }
}
//creating a new class that inherits from Alpha
class Bravo : Alpha
{
    //creating a variable field
    public int bravo;
    //creating an overloaded public method
    public override void set(int n)
    {
        //assigning the alpha fields value to the arguments
        alpha = n;
        //assigning the bravo fields value to the alpha fields
        bravo = alpha;
        //dispalying the fields
        WriteLine("Bravo (един аргумент): {0} и {1}", alpha, bravo);
    }
    //creating a public method
    public void set(int m, int n)
    {
        //assigning the alpha fields value to the first argument
        alpha = m;
        //assigning the bravo fields value to the second argument
        bravo = n;
        //display the fields
        WriteLine("Bravo (два аргументa): {0} и {1}", alpha, bravo);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a new class object
        Alpha A = new Alpha();
        //using the method set from class Alpha
        A.set();
        //using the method set(with one argument) from class Alpha
        A.set(20);
        WriteLine();

        //creating a new class object
        Bravo B = new Bravo();
        //using the method set from class Bravo
        B.set();
        //using the method set(with one argument) from class Bravo
        B.set(30);
        //using the method set(with two arguments) from class Bravo
        B.set(40, 50);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}