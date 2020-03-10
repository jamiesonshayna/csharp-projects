using NonPrimitiveTypes.Math;

namespace NonPrimitiveTypes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Person object
            Person me = new Person();
            me.FirstName = "Shayna";
            me.LastName = "Jamieson";
            me.Introduce();

            // Calculator object
            Calculator calc = new Calculator();
            System.Console.WriteLine(calc.Add(44, 7));
        }
    }
}

/* struct v. class
 *
 *  use a structure when you want to define
 *  a small and light-weight object
 */
