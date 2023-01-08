using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    static List<int> primes = new List<int>();
    async static Task Main(string[] args)
    {
        int extreme = GetMaxNumber();
        int[] numArray = CreateArray(extreme);
        int number = 0;
        for (int i = 0; i< numArray.Length; i++) 
        {
            number = numArray[i];
            await FindPrimesAsync(number);
        }
        string primesList = string.Join(", ", primes);
        Console.WriteLine(primesList);
    }
    static int GetMaxNumber()
    {
        Console.WriteLine("Enter the extreme number");
        int extremenum = Convert.ToInt32(Console.ReadLine());
        return extremenum;
    }
    static int[] CreateArray(int extreme)
    {
        int[] numArray = new int[extreme]; 
        for (int i = 0; i < numArray.Length; i++)
        {
            numArray[i] = i+1;
        }
        return numArray;
    }
    static async Task FindPrimesAsync(int number)
    {
        bool result = true;
            for (int index = 2; index < number; index++)
            {
                if (number % index == 0)
                    result = false;
            }
        if (result == true)
        {
            primes.Add(number);
        }
    }
}
