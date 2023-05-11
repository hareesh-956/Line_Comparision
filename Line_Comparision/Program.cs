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
            float x3;
            float x4;
            float y3;
            float y4;
            float length1;
            float length2;
            Console.WriteLine("please enter x1 value");
            float.TryParse(Console.ReadLine(), out x1);

            Console.WriteLine("please enter x2 value");
            float.TryParse(Console.ReadLine(), out x2);

            Console.WriteLine("please enter y1 value");
            float.TryParse(Console.ReadLine(), out y1);

            Console.WriteLine("please enter y2 value");
            float.TryParse(Console.ReadLine(), out y2);

            Console.WriteLine("please enter x3 value");
            float.TryParse(Console.ReadLine(), out x3);

            Console.WriteLine("please enter x4 value");
            float.TryParse(Console.ReadLine(), out x4);

            Console.WriteLine("please enter y3 value");
            float.TryParse(Console.ReadLine(), out y3);

            Console.WriteLine("please enter y4 value");
            float.TryParse(Console.ReadLine(), out y4);

            length1 = (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            length2 = (float)Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            Console.WriteLine("Length of Line" + length1);
            Console.WriteLine("Length of Line" + length2);

            if (length1 == length2)
            {
                Console.WriteLine("Two lengths of lines are equal");
            }
            else if (length1 > length2)
            {
             
                Console.WriteLine("Two lengths of lines are not equal");
            }
            else if (length1 < length2)
            {
                Console.WriteLine("Two lengths of lines are not equal");
            }
            else
            {
                Console.WriteLine("Both are not equal");
            }
            Console.ReadKey();
        }

    }
}