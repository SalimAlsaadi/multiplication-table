namespace Nested_For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
       for(int a = 1; a<=12; a++)
            {
                Console.WriteLine("multiplication table of  " + a + " ");
                for(int b = 1; b<=12; b++)
                {
                    int num = a * b;

                    Console.WriteLine( a + " * "+ b + " = "+ num);
                    
                }
            }

              
        
        }
    }
}