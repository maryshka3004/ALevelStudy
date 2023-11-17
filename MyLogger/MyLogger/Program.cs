namespace MyLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var logger = new Actions();

            var run = new Run(new Users(new UserRepository(), logger, new Notifications()));
            run.Start();
        }
    }
}