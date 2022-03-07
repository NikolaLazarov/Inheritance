using static System.Console;
//creating a new class
class Base{
    //creating an int type variable field
    public int code;
    //creating a public class
    public void show(){
        //displaying the field
        WriteLine("Поле code: " + code);
    }
}
//creating a new class that inherits from Base
class myClass : Base{
    //creating a char type variable field
    public char symb;
    //creating a public method
    public void display(){
        //displaying the field
        WriteLine("Поле symb: " + symb);
        //using the show method
        show();
    }
    //creating an int type property
    public int number{
        //defining a get accessor
        get{
            //returns the Base int field
            return code;
        }
        //defining a set accessor
        set{
            //assigning the Base int fields value to the value of the assignment
            code = value;
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a new class object
        myClass obj = new myClass();
        //assigning the fields value
        obj.code = 100;
        //assigning the fields value
        obj.symb = 'A';

        //using the display method
        obj.display();
        //assigning the properties value
        obj.number = 200;

        //displaying the properties field
        WriteLine("Свойство number: " + obj.number);
        //using the show method
        obj.show();
        
        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}