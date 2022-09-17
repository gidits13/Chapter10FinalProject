namespace Chapter10FinalProject
{
    public interface Ilogger
    {
        void Error(string message);
        void Event(string message);
        void WriteToFile(string message);
    }
    public interface ISum
    {
        double sum();
    }
    internal class Program
    {
        static Ilogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger(@"c:\2\log.txt");
            Calc calc = new Calc(Logger);
            
           // Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Введите Х");
            calc.x = calc.GetInput();
           
           // Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Введите Y");
            calc.y = calc.GetInput();

            double result = calc.sum();
          //  Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(result);
        }
    }
}