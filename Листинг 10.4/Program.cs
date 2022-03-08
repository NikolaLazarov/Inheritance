//one one actually uses destructors tho 😑
using static System.Console;
//creating a new class
class Alpha
{
    //creating a constructor
    public Alpha()
    {
        WriteLine("Коструктор на класа Alpha.");
    }
    //creating a destructor
    ~Alpha()
    {
        WriteLine("Деструктор на класа Alpha.");
    }
}
//creating a class that inherits
class Bravo : Alpha
{
    //creating a constructor that inherits 
    public Bravo() : base()
    {
        WriteLine("Коструктор на класа Bravo.");
    }
    //creating a destructor
    ~Bravo()
    {
        WriteLine("Деструктор на класа Bravo.");
    }
}
//creating a class that inherits
class Charlie : Bravo
{
    //creating a constructor that inherits 
    public Charlie() : base()
    {
        WriteLine("Коструктор на класа Charlie.");
    }
    //creating a destructor
    ~Charlie()
    {
        WriteLine("Деструктор на класа Charlie.");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        new Charlie();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}