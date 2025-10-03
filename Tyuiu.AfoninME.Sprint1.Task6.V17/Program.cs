using Tyuiu.AfoninME.Sprint1.Task6.V17.Lib;

    internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        
        Console.WriteLine("Введите тескт:");
        string z = Console.ReadLine();



        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.CheckPalindrome(z));




        Console.ReadLine();

    }
}
