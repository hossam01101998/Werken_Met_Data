namespace Werken_Met_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello");

            //MyDBContext contect = new MyDBContext();
            using(var context = new MyDBContext())
            {
                // context 
                if(!context.Klanten.Any())
                context.InitiateDatabase();
            }
        }
    }
}