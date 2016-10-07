using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Wolf wolf=new Wolf
            {
                CommonName="Timber Wolf",
                GestationDay=60,
                CoatColor="Grey",
                IsDomesticated=false
            };
            string range=wolf.GetRange(wolf.CommonName);

            Console.WriteLine($"The {wolf.CommonName}  is very beautiful!");
            Console.WriteLine($"{range}");
        }
    }
}
