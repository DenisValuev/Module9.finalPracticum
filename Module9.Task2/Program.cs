namespace Module9.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberReader numberReader = new NumberReader();
            numberReader.NumberEnteredEvent += ShowNumber;
            while (true)
            {
                try
                {
                    numberReader.Read();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Не верно выбран вариант сортировки, попробуйте еще раз"); ;
                }
            }
        }

        static void ShowNumber(int number, string[] _array)
        {
            switch (number)
            {
                case 1:
                    {
                        Console.WriteLine("Сортировка списка А-Я");
                        Array.Sort( _array );
                        foreach (var item in _array)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    } 
                case 2:
                    {
                        Console.WriteLine("Сортировка списка Я-А");
                        Array.Sort(_array, (a,b) => b.CompareTo(a));
                        foreach (var item in _array)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    }
            }
        }
    }
    class NumberReader
    {
        public delegate void NumberReaderDelegate(int value, string[] _array);
        public event NumberReaderDelegate NumberEnteredEvent;

        public void Read()
        {
            Console.WriteLine("----------------------------------------------------");
            string[] array = { "Иванов", "Петров", "Сидоров", "Иванилов", "Пупкин" };
            Console.WriteLine("Список фамилий до сортировки:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Выберите вариант сортировки: \n1 - Сортировка списка А-Я\n2 - Сортировка списка Я-А");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number != 1 && number != 2) throw new FormatException();

            
            NumberEntered(number, array);
        }

        protected virtual void NumberEntered(int number, string[] _array)
        {
            NumberEnteredEvent.Invoke(number, _array);
        }
    }
}

