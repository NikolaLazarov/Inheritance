using static System.Console;
//creating a new class
class Base
{
    //creating a variable field
    public int code;
    //creating a public method
    public void show()
    {
        WriteLine("Клас Base: " + code);
    }
    //creating a constructor
    public Base(int n)
    {
        //assigning the value of the field 
        code = n;
    }
}
//creating a new class that inherits
class myClass : Base
{
    //creating a new variable field
    new public int code;
    //creating a new public method
    new public void show()
    {
        //using the method show of the inherited class
        base.show();
        WriteLine("Клас myClass: " + code);
    }
    //creating a public method
    public void set(int n)
    {
        //assigning the value of the field of the inherited class
        base.code = n;
    }
    //creating a constructor
    public myClass(int m, int n) : base(m)
    {
        //assigning the value of the variable field
        code = n;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a new class object
        myClass obj = new myClass(100, 200);

        //using the method show
        obj.show();
        WriteLine();

        //using the method set
        obj.set(300);
        //assigning the fields value
        obj.code = 400;
        //using the method show
        obj.show();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}