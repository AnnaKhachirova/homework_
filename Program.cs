// // Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// // в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// void ShowNumbers (int start, int end)
// {
//     if (start > end)
//     {
//         Console.Write("Число M должно быть меньше числа N");
//         return;
//     }
//     if (start == end)
//     {
//         Console.Write(start);
//         return;
//     }
//     Console.Write(start + " ");
//     ShowNumbers(start + 1, end);
// }

// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// ShowNumbers(M, N);


// // Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два 
// // неотрицательных числа m и n.

// int Ackermann(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0) return Ackermann(m - 1, 1);
//     else return Ackermann(m - 1, Ackermann(m, n - 1));    
// }

// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Ackermann({m},{n}) = {Ackermann(m, n)}");


// // Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// // Использовать рекурсию, не использовать циклы.

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(101);
//         // В условии этого нет, но я ввожу ограничение по максимуму в рандоме, иначе выводит огромные числа
//     }
//     return array;
// }

// void PrintRverseArray (int[] array, int j)
// {
//     if (j == 0)
//     {
//         Console.Write(array[j]);
//         return;                
//     }
//     Console.Write(array[j] + " ");
//     PrintRverseArray(array, j - 1);
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] res = CreateArray(size);
// Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
// PrintRverseArray(res, size - 1);
