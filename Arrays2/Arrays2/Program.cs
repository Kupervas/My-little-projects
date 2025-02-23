/*using System;
using System.Linq;

int[] myArrray = { 4, 6, 86, 978, 756, 45, 23, 16, 9, 53, 74 };
int firstMax = int.MinValue;
int secondMax = int.MinValue;
foreach (int num in myArrray)
{
    if (num > firstMax)
    {
        secondMax = firstMax;
        firstMax = num;
    }
    else if (num > secondMax && num != firstMax)
    {
        secondMax = num;
    }
    
}
Console.WriteLine($" Друге найбільше значення: {secondMax}");                                          1 dz */




/* int[,] matrix =
{
   {3,76,89,9},
   {43,65,7,87},
   {91,4,65,0}
};
int rows = matrix.GetLength(0);
int cols = matrix.GetLength(1);
for (int i = 0; i < rows; i++)
{
   int[] row = new int[cols];
   for (int j = 0; j < cols; j++)
   {
       row[j] = matrix[i, j];
   }
   Array.Sort(row);

   for (int j = 0; j < cols; j++)
   {
       matrix[i, j] = row[j];
   }
}
for (int i = 0;i < rows; i++)
{ 
   for (int j = 0; j < cols; j++)
   {
       Console.Write(matrix[i, j] + " ");
   }
   Console.WriteLine();
}                                                                                                          2 dz */

/* int[] myArray = {4,76,54,3,14,7,65,8,9 };
Console.WriteLine("Введіть індекс елемента який потрібно видалити: ");
int myIndex = Convert.ToInt32(Console.ReadLine()) - 1 ;

int [] newArray = new int [myArray.Length - 1];
int j = 0;
for (int i = 0; i < myArray.Length; i++)
{
   if(i == myIndex) 
   continue;
   newArray[j++] = myArray[i];
}
foreach (int num in newArray)
{
   Console.WriteLine(num + "");
}                                                                                            3 dz */


int[,] matrix =
{
   {3,76,89},
   {43,65,7},
   {91,4,65}
};

int firstsum = 0;  
int secondsum = 0;
int size = matrix.GetLength(0);
for (int i = 0; i < matrix.GetLength(0); i++)
{
    firstsum += matrix[i,i];
    secondsum += matrix[i, size - 1 - i];
}
Console.WriteLine($"Сума чисел першої діагоналі: {firstsum}");
Console.WriteLine($"Сума чисел другої діагоналі: {secondsum}");