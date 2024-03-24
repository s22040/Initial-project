class Max
{
    public static void find_max()
    {
        int[] numbers = {1, 3, 2, 5, 6, 7, 12, 34, 50, 99, 97, 96, 111, 110};

        int max_num = numbers[0];
        for (int index = 1; index < numbers.Length; index++)
        {
            if (numbers[index] > max_num)
                max_num = numbers[index];
        }
        Console.WriteLine("Max: " + max_num);
    }
    static void Main()
    {
        Max.find_max();
    }
}
