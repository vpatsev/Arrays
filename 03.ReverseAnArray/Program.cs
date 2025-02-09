namespace _03.ReverseAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] numbers = new int[number];

            for (int i = 0; i < numbers.Length; i++)
            {
                int value = int.Parse(Console.ReadLine());
                numbers[i] = value;
            }
            for (int position = numbers.Length-1  ; position >=0; position--)
            {
                Console.Write(numbers[position]+" ");
            }
        }
    }
}