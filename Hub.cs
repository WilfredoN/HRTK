using LAB_1;
using LAB_2;
using LAB_3;
using LAB_4;
using LAB_5;
using LAB_6;
using System.Text;

namespace LABs
{
    internal class Hub
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Lab_1 lab_1 = new Lab_1();
            Lab_2 lab_2 = new Lab_2();
            Lab_3 lab_3 = new Lab_3();
            Lab_4 lab_4 = new Lab_4();
            Lab_5 lab_5 = new Lab_5();
            Lab_6 lab_6 = new Lab_6();
            Console.Write("Оберіть номер лабораторної роботи (1-6):");
            int arg = Convert.ToInt32(Console.ReadLine());
            switch(arg)
            {
                case 1: lab_1.calculate(); break;
                case 2: lab_2.calculate(); break; 
                case 3: lab_3.calculate(); break;
                case 4: lab_4.calculate(); break;
                case 5: lab_5.calculate(); break;
                case 6: lab_6.calculate(); break;
                default: Console.WriteLine("Такої лаби ще нема."); break;
            }
        }
    }
}
