namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // .NET24 Erik Bäckdahl

            //skapar nummer och kollar om det är större än 10
            int number = 20;

            if (number > 10)
            {
                Console.WriteLine("Talet är stort!");
            }
            else
            {
                Console.WriteLine("Oj. Lågt tal!");
            }
            //frågar efter anvädarens namn

            Console.WriteLine("Vad heter du?");

            string name = Console.ReadLine();
            Console.WriteLine($"hej {name}");


            //räknar upp från 0 till det tidigare nummret

            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
