using static System.Console;

public static class MyMethods
{
    /// <summary>
    /// Считывание числа из консоли
    /// </summary>
    /// <param name="text">текст выводящийся перед запросом числа</param>
    /// <returns>число</returns>
    public static int ReadInt(string text = "Enter number")
    {
        WriteLine(text);
        return int.Parse(ReadLine()!);
    }
    /// <summary>
    /// Считывание числа из консоли
    /// </summary>
    /// <param name="text">текст выводящийся перед запросом числа</param>
    /// <returns>число</returns>
    public static double ReadDouble(string text = "Enter number")
    {
        WriteLine(text);
        return double.Parse(ReadLine()!);
    }
    /// <summary>
    /// создание двухмерного массива
    /// </summary>
    /// <param name="size">размер массива</param>
    /// <param name="minnumber">наименьшее число массива</param>
    /// <param name="maxnumber">наибольшее число массива</param>
    /// <returns>массив</returns>
    public static int[] GenerateArray(int size, int minnumber = 0, int maxnumber = 10)
    {
        int[] tempArray = new int[size];
        Random rand = new Random();
        for (int i = 0; i < size; i++)
        {
            tempArray[i] = rand.Next(minnumber, maxnumber);
        }
        return tempArray;
    }
    /// <summary>
    /// создание двухмерного массива
    /// </summary>
    /// <param name="size">размер массива</param>
    /// <param name="minnumber">наименьшее число массива</param>
    /// <param name="maxnumber">наибольшее число массива</param>
    /// <returns>массив</returns>
    public static double[] GenerateArray(int size, double minnumber = 0.0, double maxnumber = 10.0)
    {
        double[] tempArray = new double[size];
        Random rand = new Random();
        for (int i = 0; i < size; i++)
        {
            tempArray[i] = rand.NextDouble() * (maxnumber - minnumber) + minnumber;
        }
        return tempArray;
    }
    /// <summary>
    /// печатанье массива
    /// </summary>
    /// <param name="array">массив</param>
    /// <param name="str">разделитель между числами массива</param>
    public static void PrintArray(int[] array, string str = ", ")
    {
        string output = string.Join(str, array);
        WriteLine($"[{output}]");
    }
    /// <summary>
    /// печатанье массива
    /// </summary>
    /// <param name="array">массив</param>
    /// <param name="str">разделитель между числами массива</param>
    public static void PrintArray(double[] array, string str = ", ")
    {
        string output = string.Join(str, array);
        WriteLine($"[{output}]");
    }
    /// <summary>
    /// печатанье массива
    /// </summary>
    /// <param name="array">массив</param>
    /// <param name="str">разделитель между числами массива</param>
    public static void PrintArray(char[] array, string str = ", ")
    {
        string output = string.Join(str, array);
        WriteLine($"[{output}]");
    }
    /// <summary>
    /// печатанье массива
    /// </summary>
    /// <param name="array">массив</param>
    /// <param name="str">разделитель между числами массива</param>
    public static void PrintArray(string[] array, string str = ", ")
    {
        string output = string.Join(str, array);
        WriteLine($"[{output}]");
    }
    /// <summary>
    /// замена символов в строке
    /// </summary>
    /// <param name="txt">текст в котором нужно изменить символы</param>
    /// <param name="oldValue">символ, который нужно заменить</param>
    /// <param name="newValue">символ, на который нужно заменить</param>
    /// <returns>возвращает результат замены</returns>
    public static string Replase(string txt, char oldValue, char newValue)
    {
        string result = string.Empty;
        for (int i = 0; i <= txt.Length - 1; i++)
        {
            if (txt[i] == oldValue)
            {
                result = result + $"{newValue}";
            }
            else
            {
                result = result + $"{txt[i]}";
            }
        }
        return result;
    }
    /// <summary>
    /// сортировка массива выбором
    /// </summary>
    /// <param name="array">массив</param>
    public static void SelectionSortedArray(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minpos = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minpos])
                {
                    minpos = j;
                }
            }
            int temp = array[i];
            array[i] = array[minpos];
            array[minpos] = temp;
        }
    }
    /// <summary>
    /// сортировка массива выбором
    /// </summary>
    /// <param name="array">массив</param>
    public static void SelectionSortedArray(double[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minpos = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minpos])
                {
                    minpos = j;
                }
            }
            double temp = array[i];
            array[i] = array[minpos];
            array[minpos] = temp;
        }
    }
    /// <summary>
    /// поиск числа в двухмерном массиве по строке и колонке
    /// </summary>
    /// <param name="array">массив</param>
    /// <param name="row">строка</param>
    /// <param name="column">колонка</param>
    public static void SearchIntIn2DArray(int[,] array, int row, int column)
    {
        if (row > array.GetLength(0) || column > array.GetLength(1))
        {
            WriteLine("данного числа нет в массиве");
        }
        else
        {
            WriteLine(array[row, column]);
        }
    }
    /// <summary>
    /// поиск числа в двухмерном массиве по строке и колонке
    /// </summary>
    /// <param name="array">массив</param>
    /// <param name="row">строка</param>
    /// <param name="column">колонка</param>
    public static void SearchIntIn2DArray(double[,] array, int row, int column)
    {
        if (row > array.GetLength(0) || column > array.GetLength(1))
        {
            WriteLine("данного числа нет в массиве");
        }
        else
        {
            WriteLine(array[row, column]);
        }
    }
    /// <summary>
    /// создание и заполение двухмерного массива
    /// </summary>
    /// <param name="rows">строки</param>
    /// <param name="columns">колонки</param>
    /// <param name="leftRange">минимальное число</param>
    /// <param name="rihtRange">максимальное число</param>
    /// <returns>матрицу</returns>
    public static int[,] CreateandFill2DIntArray(int rows, int columns, int leftRange, int rihtRange)
    {
        int[,] tempmatrix = new int[rows, columns];
        Random rand = new Random();
        for (int i = 0; i < tempmatrix.GetLength(0); i++)
        {
            WriteLine();
            for (int j = 0; j < tempmatrix.GetLength(1); j++)
            {
                tempmatrix[i, j] = rand.Next(leftRange, rihtRange);
            }
        }
        return tempmatrix;
    }
    /// <summary>
    /// выводит двухмерный массив
    /// </summary>
    /// <param name="array">матрицу</param>
    /// <param name="txt1">отступ вначале</param>
    /// <param name="txt2">отсуп после символа</param>
    public static void Print2DArray(int[,] array, string txt1 = "", string txt2 = " ")
    {
        for (int rows = 0; rows < array.GetLength(0); rows++)
        {
            for (int columns = 0; columns < array.GetLength(1); columns++)
            {
                Write($"{txt1}{array[rows, columns]}{txt2}");
            }
            WriteLine();
        }
    }
    /// <summary>
    /// выводит двухмерный массив
    /// </summary>
    /// <param name="array">матрицу</param>
    /// <param name="txt1">отступ вначале</param>
    /// <param name="txt2">отсуп после символа</param>
    public static void Print2DArray(char[,] array, string txt1 = "", string txt2 = " ")
    {
        for (int rows = 0; rows < array.GetLength(0); rows++)
        {
            for (int columns = 0; columns < array.GetLength(1); columns++)
            {
                Write($"{txt1}{array[rows, columns]}{txt2}");
            }
            WriteLine();
        }
    }
    /// <summary>
    /// выводит двухмерный массив
    /// </summary>
    /// <param name="array">матрицу</param>
    /// <param name="txt1">отступ вначале</param>
    /// <param name="txt2">отсуп после символа</param>
    public static void Print2DArray(double[,] array, string txt1 = "", string txt2 = " ")
    {
        for (int rows = 0; rows < array.GetLength(0); rows++)
        {
            for (int columns = 0; columns < array.GetLength(1); columns++)
            {
                Write($"{txt1}{array[rows, columns]}{txt2}");
            }
            WriteLine();
        }
    }
    /// <summary>
    /// быстрфя сортировка массива
    /// </summary>
    /// <param name="array">массив</param>
    /// <param name="leftIndex">начальный индекс</param>
    /// <param name="rightIndex">конечный индекс</param>
    /// <returns>отсортированный массив</returns>
    public static int[] quickSort(int[] array, int rightIndex, int leftIndex = 0)
    {
        int i = leftIndex, j = rightIndex, pivot = array[leftIndex];
        while (i <= j)
        { // [3, -10, 0, 2, -1, 9, 4, 5, 3]
            while (array[i] < pivot)
            {
                i++;
            }
            while (array[j] > pivot)
            {
                j--;
            }
            if (i <= j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
        }
        if (leftIndex < j)
            quickSort(array, leftIndex, j); // 0, 4
        if (i < rightIndex)
            quickSort(array, i, rightIndex);

        return array;
    }
    /// <summary>
    /// быстрфя сортировка массива
    /// </summary>
    /// <param name="array">массив</param>
    /// <param name="leftIndex">начальный индекс</param>
    /// <param name="rightIndex">конечный индекс</param>
    /// <returns>отсортированный массив</returns>
    public static double[] quickSort(double[] array, int rightIndex, int leftIndex = 0)
    {
        int i = leftIndex, j = rightIndex;
        double pivot = array[leftIndex];
        while (i <= j)
        {
            while (array[i] < pivot)
            {
                i++;
            }
            while (array[j] > pivot)
            {
                j--;
            }
            if (i <= j)
            {
                double temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
        }
        if (leftIndex < j)
            quickSort(array, leftIndex, j); // 0, 4
        if (i < rightIndex)
            quickSort(array, i, rightIndex);

        return array;
    }

}