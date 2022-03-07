using static System.Console;
//creating a new class
class Alpha
{
    //creating a private int type variable field
    private int num;
    //creating a protected char type variable field
    protected char symb;
    //creating a method
    public int getNum()
    {
        //returns the int field
        return num;
    }
    //creating a method
    public char getSymb()
    {
        //returns the char field
        return symb;
    }
    //creating a method
    public void setNum(int num)
    {
        //assigning the fields value to the arguments
        this.num = num;
    }
    //creating a method
    public void setSymb(char symb)
    {
        //assigning the fields value to the arguments
        this.symb = symb;
    }
}
//creating a new class that inherits form from class Alpha
class Bravo : Alpha
{
    //creating a property
    public char symbol
    {
        //defining a get accessor
        get
        {
            //returns the char fields value
            return symb;
        }
        //defining a set accessor
        set
        {
            //assigning the char fields value
            symb = value;
        }
    }
    //creating a property
    public int number
    {
        //defining a get accessor
        get
        {
            //returns the method getNum
            return getNum();
        }
        //defining a set accessor
        set
        {
            //using the method setNum
            setNum(value);
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        //creating a new class object
        Alpha A = new Alpha();
        //using a method from object A
        A.setNum(100);
        //using a method from object A
        A.setSymb('A');
        //displaying the objects
        WriteLine("Обект А: {0} и {1}", A.getNum(), A.getSymb());

        Bravo B = new Bravo();
        //using a method from object B
        B.setNum(200);
        //using a method from object B
        B.setSymb('B');
        //displaying the objects
        WriteLine("Обект А: {0} и {1}", B.getNum(), B.getSymb());

        //using a property from object B
        B.number = 300;
        //using a property from object B
        B.symbol = 'C';
        //displaying the objects
        WriteLine("Обект А: {0} и {1}", B.number, B.symbol);

        WriteLine("Press any key to close...");
        ReadKey(true);
    }
}