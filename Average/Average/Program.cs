class Average
{
    public static void licz_srednia()
    {
        int[] numbers = {4, 6, 8, 10, 12};
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        double average = (double)sum / numbers.Length;
        Console.WriteLine("Average: " + average);
    }
    static void Main()
    {
        Average.licz_srednia();
    }
}
