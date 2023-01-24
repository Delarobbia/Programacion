//Matrices

//Crear un array

int[] array = {1,2,3,4 };

//Array 2D

int[,] array2D = new int[2, 2];
int[,] array22D = { { 1, 3, 5 }, { 2, 4, 6 } };
for (int j = 0; j < 2; j++)
{
    for (int k = 0; k < 2; k++)
    {
        array2D[j, k] = j + k;
        Console.Write(array2D[j,k]+ " ");
    }
    Console.WriteLine();
}