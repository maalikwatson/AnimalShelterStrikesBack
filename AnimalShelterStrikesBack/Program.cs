using System.Security.Cryptography.X509Certificates;

namespace AnimalShelterStrikesBack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void CreateMethod(string createMethod, string voidMethod, string parametersMethod)
            {
                Console.WriteLine($"public static {voidMethod} {createMethod} ({parametersMethod})\n");
            }
            string createMethod = "CreatePyramid";
            string voidMethod = "void";
            string parametersMethod = "int HeightOfPyramid";

            CreateMethod(createMethod, voidMethod, parametersMethod);

            static string NameFunction(string name)
            {
                Console.WriteLine($"Your name is: {name}\n");
                return name;
            }

            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();

            NameFunction(firstName);

            static string BirthdayFunction(string birthday)
            {
                Console.WriteLine($"Your birthday is on: {birthday} \n");
                return birthday;
            }

            Console.Write("Please enter your birthday (ex: 01/22/93): ");
            string birthday = Console.ReadLine();

            BirthdayFunction(birthday);

            static int NumberInputFunction(string prompt, int number)
            {
                Console.WriteLine($"Your number is: {number}\n");
                return number;
            }

            string prompt = "Input a number: ";
            Console.Write($"{prompt}");
            int number = Convert.ToInt32( Console.ReadLine() );

            NumberInputFunction(prompt, number);


            static int DogFunction(int dogs)
            {
                Console.WriteLine($"Total Dogs: {dogs}\n");
                return dogs;
            }

            Console.Write($"Input total dogs: ");
            int dogs = Convert.ToInt32( Console.ReadLine() );

            DogFunction(dogs);

            static int CatFunction(int cats)
            {
                Console.WriteLine($"Total Cats: {cats}\n");
                return cats;
            }

            Console.Write($"Input total cats: ");
            int cats = Convert.ToInt32(Console.ReadLine());

            CatFunction(cats);


            static int OtherPetsFunction(int others)
            {
                Console.WriteLine($"Total Other Pets: {others}\n");
                return others;
            }

            Console.Write($"Input total other pets: ");
            int others = Convert.ToInt32(Console.ReadLine());

            OtherPetsFunction(others);


            static void DisplayFunction (string name, string birthday, int dogs, int cats, int others)
            {
                Console.WriteLine($"{name}, born {birthday}, has {dogs}, {cats}, and {dogs + cats + others} pets in total.");
            }

            DisplayFunction(firstName, birthday, dogs, cats, others);
            Console.ReadKey();
        }
    }
}
