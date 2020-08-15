namespace StringLibrary
{
    public class StaticPerson
    {
        public static string Info(Person person)
        {
            string info = person.Name + " " + person.Age;
            return info;
        }
    }
}