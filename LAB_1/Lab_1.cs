namespace LAB_1
{
    internal class Lab_1
    {
        public void calculate()
        {
            Console.Write("1) A = ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("B = ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Площадь прямоугольника S = {A} * {B} = {rectangleSquare(A, B)}");
            Console.Write("2) M = ");
            double M = Convert.ToDouble(Console.ReadLine());
            Console.Write("L1 = ");
            double L1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("L2 = ");
            double L2 = Convert.ToDouble(Console.ReadLine());
            double P = Math.Pow(M, 2) + (Math.Pow(L1, 2) - Math.Pow(L2, 2));
            Console.WriteLine($"Z = {calculateZ(M, P, L1, L2)}\nY = {calculateY(L2, P, M)}");
            Console.Write("3) Z = ");
            double Z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Q = {conditionCheck(Z)}");
            Console.Write("4) Start Interval Value = ");
            double startInterval = Convert.ToDouble(Console.ReadLine());
            Console.Write("End Interval Value = ");
            double endInterval = Convert.ToDouble(Console.ReadLine());
            Console.Write("Value to check = ");
            double key = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Чи входить число до інтервалу - {ifInInterval(key, startInterval, endInterval)}");
        }
        static double rectangleSquare(double A, double B)
        {
            return A * B;
        }
        static double calculateZ(double M, double P, double L1, double L2)
        {
            return (M / P - L1 * P) / M * L1;
        }
        static double calculateY(double L2, double P, double M)
        {
            return L2 * Math.Pow(P, 2) * M / P;
        }
        static double conditionCheck(double Z)
        {
            if (Z <= -3) return Math.Pow(Z, 2);
            else if (Z > 3) return Math.Pow(Z, 3);
            else if (Z == -3) return Z - 4;
            else return Z;
        }
        static bool ifInInterval(double digit, double start, double end)
        {
            return digit >= start && digit <= end;
        }
    }
}