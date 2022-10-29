using System;
using System.Collections.Generic;
{
    Dictionary<char, int> digits = new Dictionary<char, int>()
    {
        { 'A', 10 },
        { 'B', 11 },
        { 'C', 12 },
        { 'D', 13 },
        { 'E', 14 },
        { 'F', 15 },
        { 'G', 16 },
        { 'H', 17 },
        { 'I', 18 },
        { 'J', 19 },
        { 'K', 20 },
        { 'L', 21 },
        { 'M', 22 },
        { 'N', 23 },
        { 'O', 24 },
        { 'P', 25 },
        { 'Q', 26 },
        { 'R', 27 },
        { 'S', 28 },
        { 'T', 29 },
        { 'U', 30 },
        { 'V', 31 },
        { 'W', 32 },
        { 'X', 33 },
        { 'Y', 34 },
        { 'Z', 35 },
    };
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        int n = 0;
        int.TryParse(Console.ReadLine(), out n);
        string[] number;
        if (s.Contains(","))
        {
            number = number = s.Split(',');
        }
        else
        {
            number = s.Split(',');
        }
        double decimalNumber = 0;
        int c = number[0].Length - 1;
        int tmp = 0;
        for (int i = 0; i < number[0].Length; i++)
        {
            if (!int.TryParse(number[0][i].ToString(), out tmp))
            {
                tmp = digits[number[0][i]];
            }
            decimalNumber += tmp * Math.Pow(n, c);
            c--;
        }
        if (number.Length > 1)
        {
            for (int i = 1; 1 <= number[1].Length; i++)
            {
                decimalNumber += Convert.ToInt32(number[1][i - 1].ToString()) * Math.Pow(n, -i);
            }
        }
        Console.WriteLine($"{s} ({n}) = {decimalNumber} (10)");
    }
}
