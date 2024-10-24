namespace kursus
{
    enum DrinkingStatus
    {
        CAN_DRINK,
        CANT_DRINK,
        UNKNOWN,
    }
    class Person
    {
        private string name;
        private int age;
        DrinkingStatus drinking;

        public Person(string name, int age, DrinkingStatus drinking)
        {
            this.name = name;
            this.age = age;
            this.drinking = drinking;
        }
     
        public void PrintInfo()
        {
            Console.WriteLine("[Person] " + name + ", " + age + ", må drikke = " + drinking);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            
            string[] optns = { "Bob", "Mary", "John", "Jeff", "Fred", "Velma", "Shaggy", "Daphne" };
           
            for (int i = 0; i < 3; i++)
            {
                int age = r.Next(0, 50);
                string name = optns[r.Next(optns.Length)];

                Person person = new Person(name, age, age == 0 ? DrinkingStatus.UNKNOWN : (age >= 18 ? DrinkingStatus.CAN_DRINK : DrinkingStatus.CANT_DRINK));
                person.PrintInfo();
            }
        }
    }
}
