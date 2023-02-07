namespace GenericsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintOut<string>("salam");   //1st task// 
            Swap<int>(5, 10);                   //2nd task  value//
            Swap<string>("Salam", "Sagol");     //2nd task  reference//

        }


        /////////1////////
      
        static void PrintOut<T>(T type)
        {
            Console.WriteLine(type);
        }


       
        /////////2//////////
      

        static void Swap<T>(T a, T b)
        {
            T temporalis = a;
            a = b;
            b = temporalis;

            Console.WriteLine($"{a} swapped with {b}");
        }

    }
}