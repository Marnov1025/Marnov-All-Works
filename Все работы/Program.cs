Console.WriteLine("Мартынов Сергей, работы по С#.");
Console.WriteLine("Выберете работу, которую хотите просмотреть");
Console.WriteLine("1. Линейный поиск");//закончено
Console.WriteLine("2. Сортировка пузырьком");//закончено
Console.WriteLine("3. Созвездия");//в процессе
Console.WriteLine("4. Транспонирование матрицы и дискретно-косинусное преобразование");//закончено
Console.WriteLine("5. Бинарный поиск");//в процессе
int work = Convert.ToInt32(Console.ReadLine());
switch (work)
{
    case 1://start
           LineSearch();
        break;//end
    case 2:
        BubbleSort();
        break;
    case 3:
        Stars();
        break;
    case 4:
        Matrix();
        break;
    case 5:
        BinarySearch();
        break;
}
static void LineSearch()
{
    Console.WriteLine("Линейный поиск:");
    int[] arr1 = new int[50];
    Random rand = new Random();
    for (int i = 0; i < arr1.Length; i++)
        arr1[i] = rand.Next(0, 100);
    var str = string.Join(" ", arr1);
    Console.WriteLine(str);
    Console.Write("Ввести элемент поиска:");
    int j = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Бинарный поиск:");
    int k = -1;
    for (int h = 0; h < arr1.Length; h++)
    {
        if (arr1[h] == j)
        {
            k = h + 1;
        }
    }
    if (k > -1)
    {
        Console.WriteLine("Номер элемента = {0}", k);
    }
}
static void BubbleSort()
{
    Console.WriteLine("Введите значения для сортировки их методом пузырька:");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int c = Convert.ToInt32(Console.ReadLine());
    int d = Convert.ToInt32(Console.ReadLine());
    int e = Convert.ToInt32(Console.ReadLine());
    int[] arr = {a, b, c, d, e};
    int temp;
    for (int write = 0; write < arr.Length; write++)
    {
        for (int sort = 0; sort < arr.Length - 1; sort++)
        {
            if (arr[sort] > arr[sort + 1])
            {
                temp = arr[sort + 1];
                arr[sort + 1] = arr[sort];
                arr[sort] = temp;
            }
        }
    }
    Console.WriteLine("Выведем значения, отсортированные методом пузырька:");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " "); 
    }
}
static void Stars()
{
    Console.WriteLine("Звездное небо:");
int lenght = 33;
int height = 180;
for    (int i = 0; i < lenght; i++)
{
    for (int j = 0; j < height; j++)
    {
        if (i == 0 || i == (lenght - 1))
        {
            Console.Write("=");
        }
        else        {
            if (j == 0 || j == (height - 1))
            {
                Console.Write("|");
            }
            else            {
                Console.Write(" ");
            }
        }
    }
    Console.WriteLine();
}

//Волосы Вероники
Console.SetCursorPosition(2, 10); Console.Write('*');
Console.SetCursorPosition(2, 3); Console.Write('*');
Console.SetCursorPosition(15, 3); Console.Write('*');
Console.SetCursorPosition(2, 2); Console.Write("Волосы Вероники");
//Ящерица
Console.SetCursorPosition(30, 5); Console.Write('*');
Console.SetCursorPosition(30, 3); Console.Write("Ящерица");
Console.SetCursorPosition(33, 1); Console.Write('*');
Console.SetCursorPosition(36, 5); Console.Write('*');
Console.SetCursorPosition(33, 8); Console.Write('*');
Console.SetCursorPosition(35, 12); Console.Write('*');
Console.SetCursorPosition(40, 17); Console.Write('*');
//Лев (Малый)
Console.SetCursorPosition(50, 5); Console.Write('*');
Console.SetCursorPosition(60, 4); Console.Write('*');
Console.SetCursorPosition(70, 5); Console.Write('*');
Console.SetCursorPosition(65, 3); Console.Write("Лев (Малый)");
Console.SetCursorPosition(87, 6); Console.Write('*');
//Кассиопея
Console.SetCursorPosition(100, 3); Console.Write('*');
Console.SetCursorPosition(107, 5); Console.Write('*');
Console.SetCursorPosition(115, 4); Console.Write('*');
Console.SetCursorPosition(123, 6); Console.Write('*');
Console.SetCursorPosition(130, 3); Console.Write('*');
Console.SetCursorPosition(111, 1); Console.Write("Кассиопея");
//Жираф
Console.SetCursorPosition(150, 1); Console.Write('*');
Console.SetCursorPosition(160, 1); Console.Write("Жираф");
Console.SetCursorPosition(154, 5); Console.Write('*');
Console.SetCursorPosition(156, 10); Console.Write('*');
Console.SetCursorPosition(141, 8); Console.Write('*');

//Лира
Console.SetCursorPosition(2, 20); Console.Write('*');
Console.SetCursorPosition(5, 15); Console.Write('*');
Console.SetCursorPosition(20, 14); Console.Write('*');
Console.SetCursorPosition(16, 19); Console.Write('*');
Console.SetCursorPosition(29, 13); Console.Write('*');
Console.SetCursorPosition(12, 13); Console.Write("Лира");
//Конь (Малый)
Console.SetCursorPosition(60, 12); Console.Write('*');
Console.SetCursorPosition(65, 11); Console.Write('*');
Console.SetCursorPosition(68, 17); Console.Write('*');
Console.SetCursorPosition(57, 15); Console.Write('*');
Console.SetCursorPosition(60, 10); Console.Write("Конь (Малый)");
//Медведица (Малая)
Console.SetCursorPosition(90, 12); Console.Write('*');
Console.SetCursorPosition(93, 10); Console.Write("Медведица (Малая)");
Console.SetCursorPosition(93, 18); Console.Write('*');
Console.SetCursorPosition(109, 13); Console.Write('*');
Console.SetCursorPosition(107, 18); Console.Write('*');
Console.SetCursorPosition(115, 19); Console.Write('*');
Console.SetCursorPosition(120, 21); Console.Write('*');
Console.SetCursorPosition(123, 23); Console.Write('*');
Console.ReadKey();
}
static void Matrix()
{
    Console.WriteLine("Зададим матрицу:");
    Console.WriteLine("Укажите кол-во столбцов матрицы:");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Укажите кол-во строк матрицы:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("А вот и наша матрица:");
    int[,] matrix = new int [rows, cols];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = rnd.Next(0, 100);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    int[,] trans = new int [cols, rows];
    Console.WriteLine();
    Console.WriteLine("Теперь мы транспонируем нашу матрицу:");
    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            trans[i, j] = matrix[j, i];
            Console.Write(trans[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();


    double[,] marnov =
    {
        { 1, 2, 3, 4, 5, 6, 7, 8, }, { 1, 2, 3, 4, 5, 6, 7, 8, }, { 1, 2, 3, 4, 5, 6, 7, 8, }, { 1, 2, 3, 4, 5, 6, 7, 8, },
        { 1, 2, 3, 4, 5, 6, 7, 8, }, { 1, 2, 3, 4, 5, 6, 7, 8, }, { 1, 2, 3, 4, 5, 6, 7, 8, }, { 1, 2, 3, 4, 5, 6, 7, 8, }
    };

    Console.WriteLine();
    Console.WriteLine("Дискретно-косинусное преобразование:");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (j == 0) marnov[i, j] = (0.353553);
            if (j > 0) marnov[i, j] = 0.5 * Math.Cos((2 * i + 1) * j * Math.PI / (2 * 8));
            Console.Write($"{marnov[i, j]} \t");
        }

        Console.WriteLine();
    }
}
static void BinarySearch()
{
    Console.WriteLine("Выполним бинарный поиск:");
    int[] array = new int[50];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rand.Next(0, 100);
    Console.WriteLine("Выведем наш массив на экран:");
    var str = string.Join(" ", array);
    Console.WriteLine(str);

    int left = 25;
    int right = 25;
    int SearchedValue = Convert.ToInt32(Console.ReadLine());
    while (left <= right)
    {
        var middle = left + (left - right) / 2;
        if (SearchedValue == array[middle])
        {
        }
        else
        {
            left = middle + 1;
        }
        
    }
    int j = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Бинарный поиск:");
    int k = -1;
    for (int h = 0; h < array.Length; h++)
    {
        if (array[h] == j)
        {
            k = h + 1;
        }
    }

    if (k > -1)
    {
        Console.WriteLine("Номер элемента = {0}", k);
    }

}
Console.ReadKey();