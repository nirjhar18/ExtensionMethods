using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    //we have created an IntExtensions class under the ExtensionMethods namespace in the following example.
    //The IntExtensions class will contain all the extension methods applicable to int data type. (You may use any name for namespace and class.)
    public static class IntExtensions
    {
        // define a static method as an extension method where the first parameter of the extension method specifies the type 
        //on which the extension method is applicable.We are going to use this extension method on int type. So the first parameter must
        //be int preceded with the this modifier.
        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}
