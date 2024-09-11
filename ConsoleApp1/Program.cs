namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr =new int[10];

            arr[0] = 100;
            arr[^1] = 1000;

            Console.WriteLine($"The number of first index = {arr[0]}");
            Console.WriteLine($"The number of last index = {arr[^1]}");
            Console.WriteLine($"The number of  index 4 = {arr[4]}");
            
        }
    }
}

