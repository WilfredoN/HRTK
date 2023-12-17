namespace LAB_6
{
    internal class Lab_6
    {
        public void calculate()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string[] folders = Directory.GetDirectories(desktopPath);
            Console.WriteLine("Список папок:");
            foreach (string folder in folders)
            {
                Console.WriteLine(folder);
            }
            string[] docx = Directory.GetFiles(desktopPath, "*.docx");
            string[] pdf = Directory.GetFiles(desktopPath, "*.pdf");
            if (docx.Length == 0)
            {
                Console.WriteLine("Файлів із розширенням .docx не знайдено. Створення нового...");
                File.WriteAllText(Path.Combine(desktopPath, "new.docx"), "TEXT");
            }
            if (pdf.Length == 0)
            {
                Console.WriteLine("Файлів із розширенням .pdf не знайдено. Створення нового...");
                File.WriteAllText(Path.Combine(desktopPath, "new.pdf"), "TEXT");
            }
            Console.WriteLine("Розмір у байтах файлів із розширенням .docx:");
            foreach (string file in docx)
            {
                Console.WriteLine("Файл - " + file + "\nРозмір - " + new FileInfo(file).Length);
            }
            Console.WriteLine("Розмір у байтах файлів із розширенням .pdf:");
            foreach (string file in pdf)
            {
                Console.WriteLine("Файл - " + file + "\nРозмір - " + new FileInfo(file).Length);
            }
            string userFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string hiddenFolder = Path.Combine(userFolder, "hidden");
            Directory.CreateDirectory(hiddenFolder);
            File.SetAttributes(hiddenFolder, FileAttributes.Hidden);
            string[] files = Directory.GetFiles(desktopPath);
            foreach (string file in files)
            {
                if (File.Exists(Path.Combine(hiddenFolder, Path.GetFileName(file))))
                {
                    File.Delete(Path.Combine(hiddenFolder, Path.GetFileName(file)));
                }
                File.Copy(file, Path.Combine(hiddenFolder, Path.GetFileName(file)));
            }
            files = Directory.GetFiles(hiddenFolder);
            Console.WriteLine("Файли, скопійовані з десктопу у приховану папку - ");
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Console.WriteLine("\n\n\n\n\n");
            // task1();
            task2();
        }

        private void task1()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string lastName = "Афанасьєв";
            Directory.CreateDirectory(Path.Combine(desktopPath, lastName));
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string fileWriter = Path.Combine(desktopPath + "\\" + lastName, "directoryinfo.txt");
            using (StreamWriter sw = new StreamWriter(fileWriter))
            {
                sw.WriteLine($"Список папок у папці юзера {folderPath}");
                string[] files = Directory.GetDirectories(folderPath);
                foreach (string file in files)
                {
                    sw.WriteLine(file);
                }
            }
        }
        private void task2()
        {
            string inputFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "input.txt");
            Random random = new Random();
            using (StreamWriter sw = new StreamWriter(inputFile))
            {
                for (int i = 0; i < 100; i++)
                {
                    sw.WriteLine($"{random.Next(1, 30)}\t");
                }
            }
            string[] nums = File.ReadAllLines(inputFile);
            var numbers = nums.Select(int.Parse).ToList();
            string outputFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "output.txt");
            using (StreamWriter sw = new StreamWriter(outputFile))
            {
                foreach (var num in numbers)
                {
                    sw.WriteLine(num);
                }
                int max = numbers.Max();
                int maxCounter = numbers.Count(x => x == max);
                sw.WriteLine($"Максимальне число {max} зустрічається стільки разів - {maxCounter}");
            }
        }
    }
}