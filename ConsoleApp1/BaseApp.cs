namespace ConsoleApp1
{
    public class BaseApp
    {
        public static void Main(string[] args)
        {
            Console.Write("Vvedite number: ");
            int number = int.Parse(Console.ReadLine());

            if(number > 7)
            {
                Console.WriteLine("Hello");
            }

            Console.Write("Vvedite name: ");
            string name = Console.ReadLine();

            if (name == "John") 
            {
                Console.WriteLine("Hello, John");
            }
            else
            {
                Console.WriteLine("There is no such name");
            }

            Console.Write("Vvedite array: ");
            int[] numbers = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            List<int> multipledNumbers = new List<int>();

            foreach(int num in numbers)
            {
                var multipledNumber = num * num * num;
                multipledNumbers.Add(multipledNumber);
            }

            foreach(int num in multipledNumbers)
            {
                Console.Write(string.Join(", ", num));
            }
        }
    }
}
