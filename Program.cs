using System;

class Program
{
    static void Main()
    {
        // قراءة عدد حالات الاختبار
        int testCases = int.Parse(Console.ReadLine());

        for (int t = 0; t < testCases; t++)
        {
            // قراءة عدد الصفوف والأعمدة
            string[] dimensions = Console.ReadLine().Split(' ');
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);

            // مصفوفة لحفظ الجدول
            char[][] table = new char[rows][];

            // قراءة كل صف من الجدول
            for (int i = 0; i < rows; i++)
            {
                table[i] = Console.ReadLine().ToCharArray();
            }

            int maxBorder = 0;

            // حساب الحد الأقصى في كل صف
            for (int i = 0; i < rows; i++)
            {
                int currentBorder = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (table[i][j] == '#')
                    {
                        currentBorder++;
                        maxBorder = Math.Max(maxBorder, currentBorder);
                    }
                    else
                    {
                        currentBorder = 0;
                    }
                }
            }

            // حساب الحد الأقصى في كل عمود
            for (int j = 0; j < cols; j++)
            {
                int currentBorder = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (table[i][j] == '#')
                    {
                        currentBorder++;
                        maxBorder = Math.Max(maxBorder, currentBorder);
                    }
                    else
                    {
                        currentBorder = 0;
                    }
                }
            }

            // طباعة الحد الأقصى للحدود
            Console.WriteLine(maxBorder);
        }
    }
}

