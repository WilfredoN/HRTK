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
            string full_name = "��������� ͳ��� ����������";
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
                if ("��賿����".Contains(letter.ToString().ToLower()))
                {
                    formated_patronymic += letter.ToString().ToUpper();
                }
                else
                {
                    formated_patronymic += letter;
                }
            }
            Console.WriteLine($"������� - {len}");
            Console.WriteLine($"ʳ������ ���� {second_letter} - {count}");
            Console.WriteLine($"���������� ϲ� - {format_name.ToString()}");
            Console.WriteLine($"������������ ��-������� - {formated_patronymic}");
            Console.WriteLine("������� ������� " + full_name + " ����� ʲ-410.");

        }
        public void task2()
        {
            string second_name = "���������";
            int count = 0;
            for (int i = 0; i < second_name.Length; i++)
            {
                if (second_name[i] == '�')
                {
                    count++;
                }
            }
            Console.WriteLine($"������� " + second_name + " �� " + count + " ���� 'a'");
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