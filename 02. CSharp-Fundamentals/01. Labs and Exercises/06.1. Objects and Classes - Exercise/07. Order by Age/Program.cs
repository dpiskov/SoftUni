namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split();

            List<Person> peopleList = new List<Person>();

            while (commands[0] != "End")
            {
                var person = new Person(commands[0], commands[1], int.Parse(commands[2]));
                peopleList.Add(person);

                commands = Console.ReadLine().Split();
            }

            //Print #1
            peopleList
                .OrderBy(person => person.Age)
                .ToList()
                .ForEach(person => Console.WriteLine(person));

            //Print #2
            //foreach (var person in peopleList.OrderBy(person => person.Age))
            //{
            //    Console.WriteLine($"{person}");
            //}
        }
    }

    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString() => $"{Name} with ID: {ID} is {Age} years old.";
    }
}