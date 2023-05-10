namespace Line_Comparision
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Welcome Line Comparsion");
            float x1;
            float x2;
            float y1;
            float y2;
            float length;
            Console.WriteLine("please enter x1 value");
            float.TryParse(Console.ReadLine(), out x1);

            Console.WriteLine("please enter x2 value");
            float.TryParse(Console.ReadLine(), out x2);

            Console.WriteLine("please enter y1 value");
            float.TryParse(Console.ReadLine(), out y1);

            Console.WriteLine("please enter y2 value");
            float.TryParse(Console.ReadLine(), out y2);

            length = (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of Line" + length);







        }
    }
}