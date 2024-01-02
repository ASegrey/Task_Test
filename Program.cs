namespace Task_Test
{
    public class Program
    {
        public static void Main()
        {
            string[] arrayTask = { "Sort", "Arr", "C#" };
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
    }
}
