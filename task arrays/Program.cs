// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

#region task5
int[] array = { 2, 4, 5, 3, 7, 9 };
int sum = 0;
for (int i = 0; i < array.length; i++)
{
    sum += array[i];
}
console.writeline(sum);
#endregion
#region task6
int[] arr = { 12, 15, 17, 26, 34 };
int max = arr[0];
for (int i = 1; i < arr.length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
}
console.writeline(max);
#endregion
#region task7
int[] numbers = { 8, 5, 9, 3, 4, 6 };
int summ = 0;
summ = numbers[0] + numbers[numbers.Length - 1];
Console.WriteLine(summ);
#endregion