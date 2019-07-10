using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    //Extension methods, as the name suggests, are additional methods. Extension methods allow you to inject additional methods without modifying,
    //deriving or recompiling the original class, struct or interface. Extension methods can be added to your own custom class, .NET framework classes,
    //or third party classes or interfaces.

    class Program
    {
        //Now, you can include the ExtensionMethods namespace wherever you want to use this extension method.
        static void Main(string[] args)
        {
            int i = 10;

            bool result = i.IsGreaterThan(100);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
