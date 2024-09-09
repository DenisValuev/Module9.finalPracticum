namespace Module9.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptionsArray = 
            {
                new ArgumentException(),
                new NullReferenceException(),
                new MyException("Мое исключение"),
                new IndexOutOfRangeException(),
                new DivideByZeroException()
            };
            foreach (var item in exceptionsArray)
            {
                ProcessException(item);
            }

        }
        static void ProcessException(Exception exception)
        {
            try
            {
                throw exception;
            }
            catch (NullReferenceException e) { Console.WriteLine(e.Message); }
            catch (ArgumentException e) { Console.WriteLine(e.Message); }
            catch (MyException e) { Console.WriteLine(e.Message); }
            catch (IndexOutOfRangeException e) { Console.WriteLine(e.Message); }
            catch (DivideByZeroException e) { Console.WriteLine(e.Message); }
            catch (Exception e) { Console.WriteLine("Что то пошло не так"); }
        }
    }
}
