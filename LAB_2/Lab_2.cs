namespace LAB_2
{
    internal class Lab_2
    {
        public void calculate()
        {
            Console.WriteLine("while:");
            whileTask();
            Console.WriteLine("for:");
            forTask();
            Console.WriteLine("while + for: ");
            whileFor();
        }
        public void whileTask()
        {
            double h = 0.1;
            double x0 = 0.4;
            double xk = 1.0;
            double y = 0.0;
            double x = x0;
            while (x <= xk)
            {
                y = 1 + Math.Pow(Math.Log(x), 2);
                Console.WriteLine($"f({x:F1}) = {y:F3}");
                x += h;
            }
        }
        public void forTask()
        {
            double a = 1.5;
            double b = 1.2;
            double x0 = -0.75;
            double xk = -1.5;
            double y = x0;
            for (double x = x0; Math.Round(x, 3) >= xk; x -= 0.05)
            {
                y = 1.2 * Math.Pow((a - b), 3) * Math.Exp(Math.Pow(x, 2)) + x;
                Console.WriteLine($"f({x:F2}) = {y:F2}");
            }
        }
        public void whileFor()
        {
            double a = 1.7;
            double b = 6.2;
            double xn = 9.2;
            double xk = 0.4;
            double delta = -0.8;
            double y;
            while (xn >= xk)
            {
                if (xn > a && xn < b)
                {
                    y = Math.Pow(a + Math.Log(Math.Pow(xn, 2)), 1.0/3.0);
                    Console.WriteLine($"y({xn:F2}) = {y:F4}");
                }
                else if (xn > b)
                {
                    y = Math.Pow(Math.Sin(a - xn), 2) + Math.Pow(Math.Abs(a - b), 1.0 / 4.0);
                    Console.WriteLine($"y({xn:F2}) = {y:F4}");
                }
                else 
                {
                    double multiply = 1;
                    for (int k = 4; k <= 8; k++)
                    {
                        multiply *= (10 + Math.Sin(xn)) / (k - xn);
                    }
                    Console.WriteLine($"y({xn:F2}) = {multiply:F4}");
                }
                xn += delta;
                }
            }
        }
}
