using System;
using StaticNamespace;

namespace NamespacesTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new StaticNamespace.Class();
            Console.WriteLine($"{Class.COUNT}");
            Console.WriteLine($"{Class.NAME}");
            Console.WriteLine($"{Class.AGE}");
        }
    }
}
