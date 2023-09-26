using LAB_1;
using LAB_2;

namespace LABs
{
    internal class Hub
    {
        static void Main(string[] args)
        {
            Lab_1 lab_1 = new Lab_1();
            Lab_2 lab_2 = new Lab_2();
            Console.Write("Оберіть номер лабораторної роботи (1-2):");
            int arg = Convert.ToInt32(Console.ReadLine());
            switch(arg)
            {
                case 1: lab_1.calculate(); break;
                case 2: lab_2.calculate(); break; 
                default: Console.WriteLine("Такої лаби ще нема."); break;
            }
        }
    }
}
