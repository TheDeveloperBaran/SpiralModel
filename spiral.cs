  using System;

class SpiralCounter
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int[,] matrix = new int[num, num];
        int value = 1;
        int x = 0, y = 0;
        int dx = 0, dy = 1;

        while (value <= num * num)
        {
            matrix[x, y] = value++;
            if (x + dx < 0 || x + dx == num || y + dy < 0 || y + dy == num || matrix[x + dx, y + dy] != 0)
            {
                int temp = dx;
                dx = dy;
                dy = -temp;
            }
            x += dx;
            y += dy;
        }

        // Print out the matrix in a spiral pattern
        for (int i = 0; i < num; i++)
        {
            for (int j = 0; j < num; j++)
            {
                Console.Write("{0,-3}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
