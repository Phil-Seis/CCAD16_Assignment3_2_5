//create a function that finds the index of a given item in the array
//example: Search([1, 5, 3], 5) -> 1

namespace CCAD16_Assignment3_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an array of numbers (space after each number), or type 'exit' to exit the program: ");
            string input = Console.ReadLine();
            int[] userArray = Array.ConvertAll(input.Split(' '), int.Parse);

            Console.WriteLine($"Original array: {string.Join(", ", userArray)}");

            Console.WriteLine("What number would you like to search for in the array: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            int index = Find(userArray, userChoice);

            if (index != -1)
            {
                Console.WriteLine($"{userChoice} is located at index {index}");
            }

            else
            {
                Console.WriteLine($"{userChoice} is not found in the array. Try again");
            }
        }

        //Create the find function
        static int Find(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }
            return -1;  
        }
    }
}