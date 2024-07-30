namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            if (size <= 0)
            {
                throw new Exception("There is no data to save");
            }
            for (int i = 0; i < size; i++)
            { 
                arr[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            string[] strings = new string[arr.Length];
            for (int i = 0;i < strings.Length; i++)
            {
                strings[i] = arr[i].ToString();
            }
            Console.WriteLine("Enter file name: ");
            string parth = Console.ReadLine();
            if (parth is null || !File.Exists(parth))
            {
                throw new Exception("File not found");
            }
            foreach (int i in arr)
            {
                File.WriteAllLines(parth, strings);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            try
            {
                if (!File.Exists(parth))
                {
                    throw new FileNotFoundException("File not found");
                }
                string[] strings1 = File.ReadAllLines(parth);
                foreach (var item in strings1)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           

        }
    }
}

//Задание 2:
//Пользователь вводит значения для элементов массива с клавиатуры. 
//Приложение предоставляет возможность сохранения содержимого массива в файл.
//Задание 3:
//Добавьте ко второму заданию возможность загрузки массива из файла.
