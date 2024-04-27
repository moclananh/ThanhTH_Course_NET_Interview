class Program
{
    static void DoSomething(int second, string mgs, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine($"{mgs,10}...start");
        Console.ResetColor();   
        for (int i = 1; i <= second; i++)
        {
            Console.ForegroundColor= color;
            Console.WriteLine($"{mgs, 10} {i, 2}");
            Thread.Sleep(1000);
        }
        Console.ForegroundColor = color ;
        Console.WriteLine($"{mgs,10}...end");
        Console.ResetColor();
    }

    static async Task<string> Task4()
    {
        Task<string> t4 = new Task<string>(
            () =>
            {
                DoSomething(10, "T1", ConsoleColor.Green);
                return "Return form T1";
            }
            );
        t4.Start();
        var result = await t4;
        Console.WriteLine("T1 finished");
        return result;
    }

    static async Task<string> Task5()
    {
        Task<string> t5 = new Task<string>(
            () =>
            {
                DoSomething(7, "T2", ConsoleColor.Yellow);
                return "Return form T2";
            }
            );
        t5.Start();
        var result = await t5;
        Console.WriteLine("T2 finished");
        return result;
    }
    static async Task Main(string[] args)
    {
        Task<string> t4 = Task4();
        Task<string> t5 = Task5();

        DoSomething(6, "T3", ConsoleColor.Red);
        

        var result4 = await t4;
        var result5 = await t5;
        Console.WriteLine("End");
        Console.ReadKey();  

        
    }
}