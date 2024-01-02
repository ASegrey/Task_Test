namespace Task_Test
{
    public class Program
    {
        public static void Main()
        {
            //string[] arrayTask = { "Sort", "Arr", "C#" };
            Console.Clear();
            string stringLoad = "Введите размер массива строк (от 1 до 100) => ";
            System.Console.Write(stringLoad);
            int sizeArray = NumberInTerminal(100,stringLoad,1);
            string[] arrayTask = new string[sizeArray];
            for (int i = 0; i < arrayTask.Length; i++)
            {
                System.Console.WriteLine($"Введите значение для строки №{i}");
                string ? numString = Console.ReadLine();
                arrayTask[i] = numString;
            }
            Console.WriteLine($"Заданный массив => [{String.Join(", ", arrayTask)}]");
            Console.WriteLine($"Отсортированный массив => [{String.Join(", ", SortArray(arrayTask,3))}]");
        }

        /// <Сортировка массива строк по количеству симвлов в строке >
        /// 
        /// </summary>
        /// <param name="array"></начальный массив>
        /// <param name="numOfCharSort"></количество <= символов в строке для сортировки>
        /// <returns></сортированный массив по количеству символов в строке>
        static string [] SortArray(string[] array, int numOfCharSort)
        {   
            string[] arrayResult = new string[array.Length];
            int j = 0;
            string tempString = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                tempString = array[i];
                if (tempString.Length <= numOfCharSort)
                {
                    arrayResult[j] = tempString;
                    j++;
                }
            }
            Array.Resize(ref arrayResult,j);
            return arrayResult;
        }
        /*Функция ввода чисел в терминале*/
        public static int NumberInTerminal(int numberDigits, string repeatString, int minValueSet)
        {
            string ? numString = Console.ReadLine();
            int numInt = 0;
            while ((!Int32.TryParse(numString,out numInt)) 
                    || !(numInt >= minValueSet) 
                    || !(numInt <= numberDigits)
                  )
            {
                System.Console.WriteLine("Ошибка ввода, повторите");
                System.Console.Write(repeatString);
                numString = Console.ReadLine(); 
            }
            return numInt;
        }
    }
}
