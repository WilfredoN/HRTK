namespace LAB_4
{
    internal class Lab_4
    {
        public void calculate()
        {
            // Task1();
            Task2();

        }
        public void Task1()
        {
            Console.WriteLine("Введіть кількість рядків:");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть кількість стовпців:");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[row, column];
            Random random = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = random.Next(0, 50);
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int count = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (isPrime(array[i, j]))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Кількість простих чисел в масиві: " + count);
        }
        public void Task2()
        {
            Console.Write("Рандомна генерація - 1, Заповнення власноруч - 2: ");
            int select = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть кількість рядків:");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть кількість стовпців:");
            int column = Convert.ToInt32(Console.ReadLine());
            double[] average = new double[row];
            int[,] array = new int[row, column];
            if (select == 1)
            {
                Random random = new Random();
                for (int i = 0; i < row; i++)
                {
                    double sum = 0;
                    for (int j = 0; j < column; j++)
                    {
                        array[i, j] = random.Next(0, 50);
                        sum += array[i, j];
                        Console.Write(array[i, j] + "\t");
                    }
                    average[i] = sum / row;
                    Console.WriteLine();
                }
            }
            else if (select == 2)
            {
                for (int i = 0; i < row; i++)
                {
                    double sum = 0;
                    for (int j = 0; j < column; j++)
                    {
                        Console.Write($"ar[{i}][{j}] = ");
                        array[i, j] = Convert.ToInt32(Console.ReadLine());
                        sum += array[i, j];
                    }
                    average[i] = sum / row;
                    Console.WriteLine();
                }
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
                for (int i = 0; i < row; i++)
                {
                    Console.WriteLine($"Середнє арифметичне {i + 1} рядка: {average[i]}");
                }

        }
        public static bool isPrime(int number)
        {
            if (number == 1)
            {
                return false;
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
