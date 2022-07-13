namespace ConsoleApp1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var phones = new Phone[4]
            {
                new Phone("Test 1", "1234"),
                new Phone("Test 2", "4321"),
                new Phone("Test 3", "3214"),
                new Phone("Test 4", "3412")
            };
            var people = new Person[4]
            {
                new Person("Petya", 18, phones[0]),
                new Person("Anya", 19, phones[1]),
                new Person("Steve", 20, phones[2]),
                new Person("Kevin", 11, phones[3])
            };
            var smartTShirt = new SmartTShirt();
            smartTShirt.Start(people);
            ((ITShirtFunctional)smartTShirt).GenerateInfoInFile();
            smartTShirt.WriteDataToFileAboutPerson();
            smartTShirt.AnalyseData();
        }
    }
}
