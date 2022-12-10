using System;
public static class Extensions
{
            public static string Reverse(this string str)
            {
                char[] chars = str.ToCharArray();
                Array.Reverse(chars);
                return new string(chars);
            }
}

        public class Example
        {
            public static void Main()
            {
                string str = "тевирп";

                string reverse = str.Reverse();
                Console.WriteLine(reverse);
                Console.ReadLine();
            }
        }
