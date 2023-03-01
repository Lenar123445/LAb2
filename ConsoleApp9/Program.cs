namespace Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число людей: ");
            int n = int.Parse(Console.ReadLine());
            Person[] people = new Person[n];
            for (int i = 0; i < n; i++)
            {
                people[i] = new Person();
                people[i].Read();
            }
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine(people[i].FirstName);
                Console.WriteLine(people[i].LastName);
                Console.WriteLine(people[i].Age(people[i].DateOfBirth));
                Console.WriteLine(people[i].Gender);
            }
        }
    }
}