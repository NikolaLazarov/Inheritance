using static System.Console;
//creating a new class
class Base
{
    //creating a new variable field
    public int code;
    //creating a public method
    public void show()
    {
        WriteLine("Поле code: " + code);
    }
    //creating a constructor
    public Base(int n)
    {
        //assigning the fields to the argument
        code = n;
    }
    //creating a constructor
    public Base(Base obj)
    {
        //assigning the fields to the argument
        code = obj.code;
    }
}
//creating a new class that inherits
class myClass : Base
{
    //creating a new variable field
    public char symb;
    //creating a public method
    public void display()
    {
        WriteLine("Поле symb: " + symb);
    }
    //creating a new constructor that inherits
    public myClass(int n, char s) : base(n)
    {
        //assigning the fields to the argument
        symb = s;
    }
    //creating a new constructor that inherits
    public myClass(myClass obj) : base(obj)
    {
        //assigning the fields to the argument
        symb = obj.symb;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a new class object
        myClass A = new myClass(100, 'A');

        //creating a new class variable
        Base obj;
        //assigning the variables value
        obj = A;
        WriteLine("Използваме променлива obj: ");
        //using the method show
        obj.show();
        //using the method display of the converted object variable
        ((myClass)obj).display();
        //assigning the fields value
        obj.code = 200;
        //assigning the fields value converted object variable
        ((myClass)obj).symb = 'B';
        WriteLine("Използваме променлива A: ");

        //using the method show
        A.show();
        //using the method display()
        A.display();

        //creating a new class object
        myClass B = new myClass(A);
        //assigning the fields value
        A.code = 0;
        //assigning the fields value
        A.symb = 'O';

        WriteLine("Използваме променлива B: ");
        //using the method show
        B.show();
        //using the method display
        B.display();

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}