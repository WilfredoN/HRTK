using System.Text;
namespace LAB_5
{
    internal class Lab_5
    {
        public void calculate()
        {
            Console.WriteLine("1)");
            task1();
            Console.WriteLine("\n2)");
            task2();
            Console.WriteLine("\n3)");
            task3();

        }
        public void task1()
        {
            string full_name = "Афанасьєв Нікіта Олексійович";
            int len = full_name.Length;
            char second_letter = full_name.Split(' ')[0][1];
            int count = 0;
            foreach (char letter in full_name)
            {
                if (second_letter == letter)
                {
                    count++;
                }
            }
            string[] name = full_name.Split(' ');
            StringBuilder format_name = new StringBuilder();
            Console.WriteLine(name[0] + ' ' + name[1] + ' ' + name[2]);
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < name[i].Length; j++)
                {
                    if (i != 2)
                    {
                        format_name.Append(name[i][j].ToString());
                        format_name.Append(" - ");
                    }
                    else format_name.Append(name[i][j].ToString());
                }
            }
            string patronymic = name[2];
            string formated_patronymic = "";
            foreach (char letter in patronymic)
            {
                if ("аеєиіїоуюя".Contains(letter.ToString().ToLower()))
                {
                    formated_patronymic += letter.ToString().ToUpper();
                }
                else
                {
                    formated_patronymic += letter;
                }
            }
            Console.WriteLine($"Довжина - {len}");
            Console.WriteLine($"Кількість букв {second_letter} - {count}");
            Console.WriteLine($"Видозмінене ПІБ - {format_name.ToString()}");
            Console.WriteLine($"Модифіковане по-батькові - {formated_patronymic}");
            Console.WriteLine("Виконав студент " + full_name + " групи КІ-410.");

        }
        public void task2()
        {
            string second_name = "Афанасьєв";
            int count = 0;
            for (int i = 0; i < second_name.Length; i++)
            {
                if (second_name[i] == 'а')
                {
                    count++;
                }
            }
            Console.WriteLine($"Прізвище " + second_name + " має " + count + " літер 'a'");
        }
        public void task3()
        {
            Console.Write("s = ");
            string s = Console.ReadLine();
            Console.Write("s1 = ");
            string s1 = Console.ReadLine();
            Console.Write("s2 = ");
            string s2 = Console.ReadLine();
            string res = s.Replace(s1, s2);
            Console.WriteLine(res);
        }
    }
}