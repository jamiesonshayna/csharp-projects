using System; // name space in .NET framework

namespace HelloWorld 
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;

            // naming conventions
            // local vars -> camelCase
            // constant vars -> PascalCase

            // variables and constants
            byte number = 100;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string name = "Shayna";
            bool isWorking = true;

            const float Pi = 2.14f;

            // keyboard shortcut for console.write -> cw + tab
            Console.WriteLine(number);
            Console.WriteLine(count + totalPrice);
            Console.WriteLine(character + " name is " + name);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            // implicit type conversion (won't compile if data loss is percieved)
            byte b = 1;
            int i = b;

            // force the type conversion (explicit type conversion (cast))
            int l = 1;
            byte b2 = (byte) l;

            // non-compatible types won't compile (unless converted)
            string s = "1";
            int i2 = Convert.ToInt32(s); // conversions with Convert class
            int j = int.Parse(s); // primitives all have parse method
        }
    }
}