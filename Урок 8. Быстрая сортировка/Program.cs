int[] QuickSort(int[] arr)
{
    if (arr.Length <= 1) return arr;
    else
    {
        int pivot = arr[0];
        int[] left = arr.Skip(1).Where(x => x < pivot).ToArray();
        int[] right = arr.Skip(1).Where(x => x >= pivot).ToArray();
        return QuickSort(left).Concat(new int[] { pivot }).Concat(QuickSort(right)).ToArray();

    }
}

int[] array = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };

int[] array_result = QuickSort(array);
foreach (var item in array_result)
{
    System.Console.Write($"{item} ");
}