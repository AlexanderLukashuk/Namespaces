using System;

namespace NamespacesTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringLibrary.Person person = new StringLibrary.Person();
            Console.WriteLine($"{StringLibrary.StaticPerson.Info(person)}");
        }
    }
}
