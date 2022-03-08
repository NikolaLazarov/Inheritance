using static System.Console;
//creating a new class
class Alpha
{
    //creating a new class variable field
    public int code;
    //creating a constructor
    public Alpha(int n)
    {
        //assigning the fields value to the arguments value
        code = n;
        //display the field
        WriteLine("Alpha (един аргумент): {0}", code);
    }
    //creating a constructor
    public Alpha()
    {
        //assigning the fields value
        code = 123;
        //displaying the field
        WriteLine("Alpha (без аргумент): {0}", code);
    }
}
class Bravo : Alpha
{
    //creating a new class variable field
    public char symb;
    //creating a constructor that inherits from an Alpha constructor
    public Bravo(int n, char s) : base(n)
    {
        //displaying the fields values
        WriteLine("Bravo (два аргумента): {0} и \'{1}\'", code, symb);
    }
    //creating a constructor that inherits from an Alpha constructor
    public Bravo(int n) : base(n)
    {
        //assigning the fields value
        symb = 'A';
        //displaying the fields values
        WriteLine("Bravo (int - аргумент): {0} и \'{1}\'", code, symb);
    }
    //creating a constructor that inherits from an Alpha constructor
    public Bravo(char s) : base(123)
    {
        //assigning the fields value to the arguments value
        symb = s;
        //displaying the fields values
        WriteLine("Bravo (char - аргумент): {0} и \'{1}\'", code, symb);
    }
    //creating a constructor that inherits from an Alpha constructor
    public Bravo() : base()
    {
        //assigning the fields value
        symb = 'O';
        //displaying the fields values
        WriteLine("Bravo (без аргументи): {0} и \'{1}\'", code, symb);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a new class object
        Alpha A1 = new Alpha();
        WriteLine();

        //creating a new class object
        Alpha A2 = new Alpha(100);
        WriteLine();

        //creating a new class object
        Bravo B1 = new Bravo(200, 'B');
        WriteLine();

        //creating a new class object
        Bravo B2 = new Bravo(300);
        WriteLine();

        //creating a new class object
        Bravo B3 = new Bravo('C');
        WriteLine();

        //creating a new class object
        Bravo B4 = new Bravo();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}