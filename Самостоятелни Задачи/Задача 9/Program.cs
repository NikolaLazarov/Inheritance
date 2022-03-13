using static System.Console;
class Base
{
    protected string text1;
    public virtual string txt
    {
        get
        {
            return text1;
        }
        set
        {
            text1 = value;
        }
    }
    public override string ToString()
    {
        string s = "Text field form Base: " + text1;
        return s;
    }
}
class myClass : Base
{
    private string text2;
    public override string txt
    {
        get
        {
            string texts = text1 + " " + text2;
            return texts;
        }
        set
        {
            string[] str;
            str = value.Split(" ");
            text1 = str[0];
            if (str.Length > 1)
            {
                text2 = str[1];
            }
            else
            {
                text2 = "";
            }
        }
    }
    public override string ToString()
    {
        string s = "Text field from Base: " + text1;
        s += "\nText field from myClass: " + text2;
        return s;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Base B = new Base();
        B.txt = "Watermelon";
        WriteLine(B.txt);
        WriteLine(B);
        WriteLine();

        myClass C = new myClass();
        C.txt = "Cup";
        WriteLine(C.txt);
        C.txt = "Bene Gesserit";
        WriteLine(C.txt);
        WriteLine(C);
        
        WriteLine("Press any key to close...");
    }
}