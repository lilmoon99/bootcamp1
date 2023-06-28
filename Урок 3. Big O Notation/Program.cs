// int n = 5;
// int[] array = new int[n];
// for (int i = 0; i < n; i++)  array[i] = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("[" + string.Join(',', array)+ "]");
// System.Console.WriteLine(array[3]); // Сложность алгоритма O(1)
// // [4,5,3,1,2]
// // O(n)
// // [1,2,3,4,5] - O(n * log2(n)) быстрая сортировка
// // ((5+1)/2)*5 - O(1) сумма арифметической прогрессии
// // n < log2(n) + 1 время работы O(log2(n)) будет больше чем O(n)
// int summa = 0;
// for(int i = 0;i < n;i++) summa += i;
// // O(n)

// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[n, n];
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         matrix[i,j] = (i+1)*(j+1);
//         System.Console.Write(String.Format("{0,3}", matrix[i,j]));
//     }
//     System.Console.WriteLine();
// }
// // O(n^2)

int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {

            matrix[i, j] = (i+1)*(j+1);
            matrix[j, i] = (i+1)*(j+1);
        System.Console.Write(String.Format("{0,3}", matrix[i,j]));
        
    }
    System.Console.WriteLine();
}