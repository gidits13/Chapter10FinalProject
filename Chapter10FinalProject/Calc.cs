namespace Chapter10FinalProject
{
    public class Calc : ISum
    {
        public Calc(Ilogger logger)
        { this.logger = logger; }
        Ilogger logger;  
        public double x;
        public double y;
        public double GetInput()
        {
            logger.Event("GetInput started");
            logger.WriteToFile("GetInput started");
            var t = Console.ReadLine();
                try
                {
                    var z = Convert.ToDouble(t);
                    return z;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    logger.Error("Введено не корректное число. Повторите ввод");
                    logger.WriteToFile("Введено не корректное число. Повторите ввод");
                    return GetInput();
                }
        }
        public double sum()
        {
            logger.Event("sum started");
            logger.WriteToFile("sum started");
            return x+y;
        }
    }
}