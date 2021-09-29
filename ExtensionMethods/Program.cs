using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            /* applyling extension method */

            int a = 10;
            int b = 20;

            int result = b.SumAable(a);
            Console.WriteLine(result);

            string gretting = "Hello";
            string name = "Mridul";

            var grettingPerson = gretting.Gretting(name);
            Console.WriteLine(grettingPerson);
            
        }
    }


    public static class AddExtensionMethod
    {

        // you can use any data type for apply extension method
        // add a method for int data type
        public static int SumAable(this int x,int y)
        {
            return x + y;
        }



        // add a method for string data type
        public static string Gretting(this string gretting,string name)
        {
            return gretting + ", " + name +"!";
        }
    }


}
