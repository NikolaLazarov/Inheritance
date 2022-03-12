using static System.Console;
class Base
{
    protected string text;
    public Base(string text)
    {
        this.text = text;
    }
    public override string ToString()
    {
        string txt = "Field from class Base: " + text;
        return txt;
    }
}
class myClass : Base
{
    protected new string text;
    public myClass(string txt) : base(txt)
    {
        this.text = txt;
    }
    public myClass(string a, string b) : base(b)
    {
        this.text = a;
    }
    public override string ToString()
    {
        string txt;
        if (this.text == base.text)
        {
            txt = "Field from class Alpha: " + text;
        }
        else
        {
            txt = "Field from class Alpha: " + this.text;
            txt += "\nField form class Base: " + text;
        }
        return txt;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Base B = new Base("Cat");
        WriteLine(B);

        myClass A = new myClass("Dog");
        WriteLine(A);

        myClass C = new myClass("Window", "Garden");
        WriteLine(C);

        WriteLine("Press any key to close...");
    }
}