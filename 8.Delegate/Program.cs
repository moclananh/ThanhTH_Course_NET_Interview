class Program
{
    delegate int MyDelegate(string s);
    static void Main(string[] args)
    {
        //MyDelegate myDelegate = new MyDelegate(ConvertStringToInt);
        //Console.WriteLine("Result: " + myDelegate("32"));

        //ex for mutilcast
        /*MyDelegate myDelegate2 = new MyDelegate(ShowString);
        MyDelegate mutilcast = myDelegate + myDelegate2;
        Console.WriteLine(mutilcast("22"));*/

        //application in callback function || using delegate like a para of func
        MyDelegate showString = new MyDelegate(ShowString);
        ShowName(showString);

    }

    static int ConvertStringToInt(string s)
    {
        int valueInt = 0;
        Int32.TryParse(s, out valueInt);
        Console.WriteLine("Parse successfully!"); 
        return valueInt;
    }

    static int ShowString(string s)
    {
        Console.WriteLine("String here: " + s);
        return 0;
    }

    static void ShowName(MyDelegate name)
    {
        Console.WriteLine("Enter name: ");
        var n = Console.ReadLine();
        name(n);
    }
}